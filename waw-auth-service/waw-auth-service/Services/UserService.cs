using AutoMapper;
using Serilog;
using waw_auth_service.Authorization.Handlers.Interfaces;
using waw_auth_service.Domain.Models;
using waw_auth_service.Domain.Repositories;
using waw_auth_service.Domain.Services;
using waw_auth_service.Domain.Services.Communication;
using waw_auth_service.Resources;
using BCryptNet = BCrypt.Net.BCrypt;
namespace waw_auth_service.Services;

public class UserService : IUserService {
  private readonly IUserRepository repository;
  private readonly IUnitOfWork unitOfWork;
  private readonly IJwtHandler jwtHandler;
  private readonly IMapper mapper;

  public UserService(IUserRepository repository, IUnitOfWork unitOfWork, IJwtHandler jwtHandler, IMapper mapper) {
    this.repository = repository;
    this.unitOfWork = unitOfWork;
    this.jwtHandler = jwtHandler;
    this.mapper = mapper;
  }

  public async Task<AuthResponse> Authenticate(AuthRequest request) {
    try {
      var user = await repository.FindByEmail(request.Email);

      if (user == null || !BCryptNet.Verify(request.Password, user.Password)) {
        return new AuthResponse("Invalid username or password");
      }

      var response = mapper.Map<AuthResource>(user);
      response.Token = jwtHandler.GenerateToken(user);
      return new AuthResponse(response);
    } catch (Exception e) {
      Log.Error(e, "An error occurred during authentication");
      return new AuthResponse($"An error occurred during authentication: ${e.Message}");
    }
  }

  public Task<IEnumerable<User>> ListAll() {
    return repository.ListAll();
  }

  public Task<IList<UserEducation>?> ListEducationByUser(long userId) {
    return repository.ListEducationByUser(userId);
  }

  public Task<IList<UserExperience>?> ListExperienceByUser(long userId) {
    return repository.ListExperienceByUser(userId);
  }

  public Task<IList<UserProject>?> ListProjectsByUser(long userId) {
    return repository.ListProjectsByUser(userId);
  }

  public Task<User?> FindById(long id) {
    return repository.FindById(id);
  }

  public async Task<IList<User>?> BatchFindById(IEnumerable<long> ids) {
    var users = new List<User>();
    foreach (var id in ids) {
      var user = await FindById(id);
      if (user is null) {
        return null;
      }

      users.Add(user);
    }

    return users;
  }

  public async Task<UserResponse> Register(User user) {
    if (repository.ExistsByEmail(user.Email)) {
      return new UserResponse($"Email {user.Email} already has an account");
    }

    user.Password = BCryptNet.HashPassword(user.Password);

    try {
      await repository.Add(user);
      await unitOfWork.Complete();
      return new UserResponse(user);
    } catch (Exception e) {
      return new UserResponse($"An error occurred while saving the user: {e.Message}");
    }
  }

  public async Task<UserResponse> Update(long id, UserUpdateRequest request) {
    var current = await repository.FindById(id);
    if (current == null) return new UserResponse("User not found");

    current.CopyFrom(request, new[] {"Id", "Email", "Password",});

    try {
      repository.Update(current);
      await unitOfWork.Complete();
      return new UserResponse(current);
    } catch (Exception e) {
      return new UserResponse($"An error occurred while updating the user: {e.Message}");
    }
  }
}

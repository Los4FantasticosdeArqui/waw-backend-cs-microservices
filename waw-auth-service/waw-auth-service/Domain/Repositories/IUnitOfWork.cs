namespace waw_auth_service.Domain.Repositories;

public interface IUnitOfWork {
  Task Complete();
}

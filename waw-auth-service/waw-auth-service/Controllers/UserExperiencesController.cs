using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using waw_auth_service.Authorization.Attributes;
using waw_auth_service.Domain.Models;
using waw_auth_service.Domain.Services;
using waw_auth_service.Resources;

namespace waw_auth_service.Controllers;

[Authorize]
[ApiController]
[Route("users/me/experience")]
[SwaggerTag("Create, read, update and delete the current User experience info")]
public class UserExperiencesController : ControllerBase {
  private readonly IUserExperienceService service;
  private readonly IMapper mapper;

  public UserExperiencesController(IUserExperienceService service, IMapper mapper) {
    this.service = service;
    this.mapper = mapper;
  }

  [HttpGet]
  public async Task<IEnumerable<UserExperienceResource>> ListAll() {
    var user = (User) HttpContext.Items["User"]!;
    var results = await service.ListByUserId(user.Id);
    return mapper.Map<IEnumerable<UserExperience>, IEnumerable<UserExperienceResource>>(results);
  }

  [HttpPost]
  public async Task<IActionResult> Create([FromBody] UserExperienceRequest request) {
    var user = (User) HttpContext.Items["User"]!;
    var mapped = mapper.Map<UserExperienceRequest, UserExperience>(request);
    mapped.UserId = user.Id;
    var result = await service.Add(mapped);
    return result.ToResponse<UserExperienceResource>(this, mapper);
  }

  [HttpPut("{id:long}")]
  public async Task<IActionResult> Update([FromRoute] long id, [FromBody] UserExperienceRequest request) {
    var user = (User) HttpContext.Items["User"]!;
    var mapped = mapper.Map<UserExperienceRequest, UserExperience>(request);
    mapped.UserId = user.Id;
    var result = await service.Update(id, mapped);
    return result.ToResponse<UserExperienceResource>(this, mapper);
  }

  [HttpDelete("{id:long}")]
  public async Task<IActionResult> Delete([FromRoute] long id) {
    var user = (User) HttpContext.Items["User"]!;
    var result = await service.Remove(id, user.Id);
    if (!result) return BadRequest("Unable to remove request entity");
    return NoContent();
  }
}

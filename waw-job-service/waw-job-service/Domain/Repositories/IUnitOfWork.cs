namespace waw_job_service.Domain.Repositories;

public interface IUnitOfWork
{
    Task Complete();
}
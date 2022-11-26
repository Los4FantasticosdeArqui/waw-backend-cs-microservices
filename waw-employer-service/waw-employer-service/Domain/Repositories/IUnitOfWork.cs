namespace waw_employer_service.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task Complete();
    }
}

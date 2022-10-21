namespace AuthMicroservice.Domain.Repositories;

public interface IUnitOfWork {
  Task Complete();
}

namespace waw_chat_service.Domain.Repositories;

public interface IUnitOfWork {
    Task Complete();
}
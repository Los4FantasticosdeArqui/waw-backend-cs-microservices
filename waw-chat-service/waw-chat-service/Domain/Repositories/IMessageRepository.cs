using waw_chat_service.Domain.Models;

namespace waw_chat_service.Domain.Repositories;

public interface IMessageRepository {
    Task<IEnumerable<Message>> ListAll();
    Task Add(Message message);
    Task<Message?> FindById(long id);
    void Delete(Message message);
}
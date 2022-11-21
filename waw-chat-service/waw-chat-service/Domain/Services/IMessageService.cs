using waw_chat_service.Domain.Models;
using waw_chat_service.Domain.Services.Communication;

namespace waw_chat_service.Domain.Services;

public interface IMessageService {
    Task<IEnumerable<Message>> ListAll();
    Task<MessageResponse> Create(Message message);
    Task<MessageResponse> Delete(long id);
}
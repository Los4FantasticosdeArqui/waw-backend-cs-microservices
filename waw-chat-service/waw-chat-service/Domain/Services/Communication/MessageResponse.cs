using waw_chat_service.Domain.Models;

namespace waw_chat_service.Domain.Services.Communication;

public class MessageResponse  : BaseResponse<Message>{
    public MessageResponse(string message) : base(message) {}
    public MessageResponse(Message resource) : base(resource) {}
}
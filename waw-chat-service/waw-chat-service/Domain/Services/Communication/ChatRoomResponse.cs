using waw_chat_service.Domain.Models;

namespace waw_chat_service.Domain.Services.Communication;

public class ChatRoomResponse : BaseResponse<ChatRoom> {
    public ChatRoomResponse(string message) : base(message) {}
    public ChatRoomResponse(ChatRoom resource) : base(resource) {}
}
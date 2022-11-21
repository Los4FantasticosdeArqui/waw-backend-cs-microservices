using waw_chat_service.Domain.Models;
using waw_chat_service.Domain.Services.Communication;

namespace waw_chat_service.Domain.Services;

public interface IChatRoomService {
    Task<IEnumerable<ChatRoom>> ListAll();
    Task<IEnumerable<Message>?> ListMessagesByChatRoomId(long chatRoomId);
    //Task<IEnumerable<User>?> ListParticipantsByChatRoomId(long chatRoomId);
    Task<ChatRoomResponse> Create(ChatRoom chatRoom);
    Task<ChatRoomResponse> Update(long id, ChatRoom chatRoom);
    Task<ChatRoomResponse> Delete(long id);
}
using waw_chat_service.Domain.Models;

namespace waw_chat_service.Domain.Repositories;

public interface IChatRoomRepository {
    Task<IEnumerable<ChatRoom>> ListAll();
    Task Add(ChatRoom chatRoom);
    Task<ChatRoom?> FindById(long id);
    Task<IEnumerable<Message>?> FindMessagesByChatRoomId(long chatRoomId);
    //Task<IEnumerable<User>?> FindParticipantsByChatRoomId(long chatRoomId);
    void Update(ChatRoom chatRoom);
    void Remove(ChatRoom chatRoom);
}
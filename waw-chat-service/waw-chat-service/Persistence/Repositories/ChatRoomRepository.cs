using Microsoft.EntityFrameworkCore;
using waw_chat_service.Domain.Models;
using waw_chat_service.Domain.Repositories;
using waw_chat_service.Persistence.Context;

namespace waw_chat_service.Persistence.Repositories;

public class ChatRoomRepository : BaseRepository, IChatRoomRepository {
    public ChatRoomRepository(AppDbContext context) : base(context) {}
    
    public async Task<IEnumerable<ChatRoom>> ListAll() {
        return await context.ChatRooms.ToListAsync();
    }

    public async Task Add(ChatRoom chatRoom) {
        await context.ChatRooms.AddAsync(chatRoom);
    }

    public async Task<ChatRoom?> FindById(long id) {
        return await context.ChatRooms.FindAsync(id);
    }

    public async Task<IEnumerable<Message>?> FindMessagesByChatRoomId(long chatRoomId) {
        var chatRoom = await context.ChatRooms.FindAsync(chatRoomId);
        return chatRoom?.Messages;
    }
    
    /*
    public async Task<IEnumerable<User>?> FindParticipantsByChatRoomId(long chatRoomId) {
        var chatRoom = await context.ChatRooms.FindAsync(chatRoomId);
        return chatRoom?.Participants;
    }
    */
    
    public void Update(ChatRoom chatRoom) {
        context.ChatRooms.Update(chatRoom);
    }

    public void Remove(ChatRoom chatRoom) {
        context.ChatRooms.Remove(chatRoom);
    }
}
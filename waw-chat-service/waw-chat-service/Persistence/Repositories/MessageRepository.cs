using Microsoft.EntityFrameworkCore;
using waw_chat_service.Domain.Models;
using waw_chat_service.Domain.Repositories;
using waw_chat_service.Persistence.Context;

namespace waw_chat_service.Persistence.Repositories;

public class MessageRepository : BaseRepository, IMessageRepository {
    public MessageRepository(AppDbContext context) : base(context) {}

    public async Task<IEnumerable<Message>> ListAll() {
        return await context.Messages.ToListAsync();
    }

    public async Task Add(Message message) {
        await context.Messages.AddAsync(message);
    }

    public async Task<Message?> FindById(long id) {
        return await context.Messages.FindAsync(id);
    }

    public void Delete(Message message) {
        context.Messages.Remove(message);
    }
}
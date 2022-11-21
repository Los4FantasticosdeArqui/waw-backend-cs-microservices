using waw_chat_service.Domain.Repositories;
using waw_chat_service.Persistence.Context;

namespace waw_chat_service.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork {
    private readonly AppDbContext context;

    public UnitOfWork(AppDbContext context) {
        this.context = context;
    }

    public async Task Complete() {
        await context.SaveChangesAsync();
    }
}
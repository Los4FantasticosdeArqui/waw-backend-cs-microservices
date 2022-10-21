using waw_chat_service.Persistence.Context;

namespace waw_chat_service.Persistence.Repositories;

public class BaseRepository {
    protected readonly AppDbContext context;

    public BaseRepository(AppDbContext context) {
        this.context = context;
    }
}
using waw_chat_service.Domain.Repositories;
using waw_chat_service.Domain.Services;
using waw_chat_service.Persistence.Repositories;
using waw_chat_service.Services;

namespace waw_chat_service.Injection;

public static class ChatInjections {
    public static void Register(IServiceCollection services) {
        services.AddScoped<IChatRoomRepository, ChatRoomRepository>();
        services.AddScoped<IChatRoomService, ChatRoomService>();
        services.AddScoped<IMessageRepository, MessageRepository>();
        services.AddScoped<IMessageService, MessageService>();
    }
}
using waw_chat_service.Domain.Repositories;
using waw_chat_service.Persistence.Repositories;

namespace waw_chat_service.Injection;

public static class AppInjections {
    public static void Register(IServiceCollection service) {
        
        ChatInjections.Register(service);
        
        service.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
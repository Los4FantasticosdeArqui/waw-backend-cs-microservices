using AutoMapper;

namespace waw_chat_service.Mapping;

public class ResourceToModelProfile : Profile {
    public ResourceToModelProfile() {
        ChatResourceToModelProfile.Register(this);
    }
}
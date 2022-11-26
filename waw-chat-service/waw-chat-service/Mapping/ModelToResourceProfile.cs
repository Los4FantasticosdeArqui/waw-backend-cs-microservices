using AutoMapper;

namespace waw_chat_service.Mapping;

public class ModelToResourceProfile : Profile {
    public ModelToResourceProfile() {
        ChatModelToResourceProfile.Register(this);
    }
}
using AutoMapper;
using waw_chat_service.Domain.Models;
using waw_chat_service.Resources;

namespace waw_chat_service.Mapping;

public class ChatModelToResourceProfile {
    public static void Register(IProfileExpression profile) {
        profile.CreateMap<ChatRoom, ChatRoomResource>();
        profile.CreateMap<Message, MessageResource>();
    }
}
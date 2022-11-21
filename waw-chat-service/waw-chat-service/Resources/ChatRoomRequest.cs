using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace waw_chat_service.Resources;

public class ChatRoomRequest {
    [SwaggerSchema("Chat room participants", Nullable = false)]
    [Required]
    public IList<long>? Participants { get; set; }
}
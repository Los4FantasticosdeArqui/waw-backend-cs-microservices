﻿using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace waw_chat_service.Resources;

public class MessageRequest {
    [SwaggerSchema("Message content", Nullable = false)]
    [Required]
    public string? Content { get; set; }

    [SwaggerSchema("Chat room identifier", Nullable = false)]
    [Required]
    public long? ChatRoomId { get; set; }
}
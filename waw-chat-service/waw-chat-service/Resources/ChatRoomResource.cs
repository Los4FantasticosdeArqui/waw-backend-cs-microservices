﻿using Swashbuckle.AspNetCore.Annotations;

namespace waw_chat_service.Resources;

public class ChatRoomResource {
    [SwaggerSchema("Chat room identifier", ReadOnly = true)]
    public long Id { get; set; }

    [SwaggerSchema("Chat room creation date", Nullable = false)]
    public DateTime CreationDate { get; set; }

    [SwaggerSchema("Chat room last update date", Nullable = false)]
    public DateTime LastUpdateDate { get; set; }

    /*[SwaggerSchema("Chat room participants", Nullable = false)]
    public IList<UserResource> Participants { get; set; } = new List<UserResource>();*/
}
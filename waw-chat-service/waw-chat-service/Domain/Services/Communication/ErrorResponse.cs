﻿namespace waw_chat_service.Domain.Services.Communication;

public class ErrorResponse {
    public string Message { get; }

    public ErrorResponse(string message) {
        Message = message;
    }
}
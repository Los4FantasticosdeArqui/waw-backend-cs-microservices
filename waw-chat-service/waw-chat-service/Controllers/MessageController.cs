﻿using System.Net.Mime;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using waw_chat_service.Domain.Models;
using waw_chat_service.Domain.Services;
using waw_chat_service.Extensions;
using waw_chat_service.Resources;

namespace waw_chat_service.Controllers;

[ApiController]
[Route("[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Create, read, update and delete Messages")]
public class MessageController : ControllerBase {
    private readonly IMessageService service;
    private readonly IMapper mapper;

    public MessageController(IMessageService service, IMapper mapper) {
        this.service = service;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<MessageResource>), 200)]
    [SwaggerResponse(200, "All the stored messages were retrieved successfully", typeof(MessageResource))]
    public async Task<IEnumerable<MessageResource>> GetAll() {
        var messages = await service.ListAll();
        return mapper.Map<IEnumerable<Message>, IEnumerable<MessageResource>>(messages);
    }

    [HttpPost]
    [ProducesResponseType(typeof(MessageResource), 200)]
    [ProducesResponseType(typeof(List<string>), 400)]
    [ProducesResponseType(500)]
    [SwaggerResponse(200, "The message was created successfully", typeof(MessageResource))]
    [SwaggerResponse(400, "The message data is invalid")]
    public async Task<IActionResult> Post(
        [FromBody] [SwaggerRequestBody("The message object about to create", Required = true)] MessageRequest messageRequest
    ) {
        if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

        var message = mapper.Map<MessageRequest, Message>(messageRequest);
        var result = await service.Create(message);
        return result.ToResponse<MessageResource>(this, mapper);
    }

    [HttpDelete("{id:long}")]
    [ProducesResponseType(typeof(NoContentResult), 204)]
    [ProducesResponseType(typeof(List<string>), 400)]
    [ProducesResponseType(500)]
    [SwaggerResponse(204, "The message was deleted successfully", typeof(NoContentResult))]
    [SwaggerResponse(400, "The selected message to delete does not exist")]
    public async Task<IActionResult> DeleteAsync(
        [FromRoute] [SwaggerParameter("Message identifier", Required = true)] long id
    ) {
        await service.Delete(id);
        return NoContent();
    }
}
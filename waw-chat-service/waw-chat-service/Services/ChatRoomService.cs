﻿using waw_chat_service.Domain.Models;
using waw_chat_service.Domain.Repositories;
using waw_chat_service.Domain.Services;
using waw_chat_service.Domain.Services.Communication;

namespace waw_chat_service.Services;

public class ChatRoomService : IChatRoomService {
    private readonly IChatRoomRepository repository;
    private readonly IUnitOfWork unitOfWork;
    
    public ChatRoomService(IChatRoomRepository repository, IUnitOfWork unitOfWork) {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
    }
    
    public Task<IEnumerable<ChatRoom>> ListAll() {
        return repository.ListAll();
    }
    
    public Task<IEnumerable<Message>?> ListMessagesByChatRoomId(long chatRoomId) {
        return repository.FindMessagesByChatRoomId(chatRoomId);
    }

    /*
     public Task<IEnumerable<User>?> ListParticipantsByChatRoomId(long chatRoomId) {
        return repository.FindParticipantsByChatRoomId(chatRoomId);
    }
    */

    public async Task<ChatRoomResponse> Create(ChatRoom chatRoom) {
        var currentDate = DateTime.Now;
        chatRoom.CreationDate = currentDate;
        chatRoom.LastUpdateDate = currentDate;
        try {
            await repository.Add(chatRoom);
            await unitOfWork.Complete();
            return new ChatRoomResponse(chatRoom);
        } catch (Exception e) {
            return new ChatRoomResponse($"An error occurred while saving the chatroom: {e.Message}");
        }
    }

    public async Task<ChatRoomResponse> Update(long id, ChatRoom chatRoom) {
        var current = await repository.FindById(id);
        if (current == null) return new ChatRoomResponse("Chatroom not found");

        chatRoom.CopyTo(current);

        current.LastUpdateDate = DateTime.Now;

        try {
            repository.Update(current);
            await unitOfWork.Complete();
            return new ChatRoomResponse(current);
        } catch (Exception e) {
            return new ChatRoomResponse($"An error occurred while updating the chat: {e.Message}");
        }
    }

    public async Task<ChatRoomResponse> Delete(long id) {
        var current = await repository.FindById(id);
        if (current == null) return new ChatRoomResponse("Chatroom not found");

        try {
            repository.Remove(current);
            await unitOfWork.Complete();
            return new ChatRoomResponse(current);
        } catch (Exception e) {
            return new ChatRoomResponse($"An error occurred while deleting the chat: {e.Message}");
        }
    }
}
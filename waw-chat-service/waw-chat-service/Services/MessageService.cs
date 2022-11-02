using waw_chat_service.Domain.Models;
using waw_chat_service.Domain.Repositories;
using waw_chat_service.Domain.Services;
using waw_chat_service.Domain.Services.Communication;

namespace waw_chat_service.Services;

public class MessageService : IMessageService{
    private readonly IMessageRepository repository;
    private readonly IUnitOfWork unitOfWork;

    public MessageService(IMessageRepository repository, IUnitOfWork unitOfWork) {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
    }

    public Task<IEnumerable<Message>> ListAll() {
        return repository.ListAll();
    }

    public async Task<MessageResponse> Create(Message message) {
        var currentDate = DateTime.Now;
        message.Date = currentDate;
        try {
            await repository.Add(message);
            await unitOfWork.Complete();
            return new MessageResponse(message);
        } catch (Exception e) {
            return new MessageResponse($"An error occurred while saving the message: {e.Message}");
        }
    }

    public async Task<MessageResponse> Delete(long id) {
        var current = await repository.FindById(id);
        if (current == null) return new MessageResponse("Message not found");

        try {
            //repository.Remove(current);
            repository.Delete(current);
            await unitOfWork.Complete();
            return new MessageResponse(current);
        } catch (Exception e) {
            return new MessageResponse($"An error occurred while deleting the message: {e.Message}");
        }
    }
}
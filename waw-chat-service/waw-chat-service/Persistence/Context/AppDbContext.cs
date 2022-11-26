using Microsoft.EntityFrameworkCore;
using waw_chat_service.Domain.Models;
using waw_chat_service.Extensions;

namespace waw_chat_service.Persistence.Context;

public class AppDbContext : DbContext {
    private DbSet<ChatRoom>? chatRooms;
    private DbSet<Message>? messages;
    
    public DbSet<ChatRoom> ChatRooms {
        get => GetContext(chatRooms);
        set => chatRooms = value;
    }

    public DbSet<Message> Messages {
        get => GetContext(messages);
        set => messages = value;
    }
    
    public AppDbContext(DbContextOptions options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);

        var chatRoomEntity = builder.Entity<ChatRoom>();
        chatRoomEntity.ToTable("ChatRoom");
        chatRoomEntity.HasKey(p => p.Id);
        chatRoomEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        chatRoomEntity.Property(p => p.CreationDate).IsRequired();
        chatRoomEntity.Property(p => p.LastUpdateDate).IsRequired();
        chatRoomEntity.HasMany(p => p.Messages).WithOne(p => p.ChatRoom).HasForeignKey(p => p.ChatRoomId);
        chatRoomEntity.HasMany(p => p.Messages).WithOne(p => p.ChatRoom).HasForeignKey(p => p.ChatRoomId);

        var messageEntity = builder.Entity<Message>();
        messageEntity.ToTable("Message");
        messageEntity.HasKey(p => p.Id);
        messageEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        messageEntity.Property(p => p.Content).IsRequired().HasMaxLength(512);
        messageEntity.Property(p => p.Date).IsRequired();
        
        builder.UseSnakeCase();
    }
    
    private static T GetContext<T>(T? ctx) {
        if (ctx == null) throw new NullReferenceException();
        return ctx;
    }
}
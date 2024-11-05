
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoProject.Models.Entities;
using TodoProject.Models.Entities.Enum;

namespace TodoProject.Repository.Configurations;

public class TodoConfiguration : IEntityTypeConfiguration<Todo>
{
    public void Configure(EntityTypeBuilder<Todo> builder)
    {
        builder.ToTable("Todos").HasKey(c=>c.Id);
        builder.Property(c => c.Id).HasColumnName("TodoId");
        builder.Property(c => c.User).HasColumnName("TodosUser");
        builder.Property(c => c.StartDate).HasColumnName("StartDateTime");
        builder.Property(c => c.Priority).HasColumnName("Priority");


        builder.HasData(new Todo
        {
            Id = new Guid("{2298A460-CB0E-473E-9CC1-6BF6C7D5B7F3}"),
            CategoryId = 1,
            Priority = Priority.High,
            Completed = false,
            CreatedDate = DateTime.Now,
            Description = "Description",
            StartDate = DateTime.Now,
            Title = "Title",
            
        });
    }
}

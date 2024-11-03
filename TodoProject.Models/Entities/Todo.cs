﻿

using Core.Entities;
using TodoProject.Models.Entities.Enum;

namespace TodoProject.Models.Entities;

public sealed class Todo : Entity<Guid>
{

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public Priority Priority { get; set; }
    public int CategoryId { get; set; }
    public bool Completed { get; set; }
    public Category Category { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
}

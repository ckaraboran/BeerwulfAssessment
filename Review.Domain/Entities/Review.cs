using Review.Domain.Enums;
using Review.Domain.Interfaces;

namespace Review.Domain.Entities;

public class Review : BaseEntity, ISoftDelete
{
    public string Title { get; set; }
    //todo https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types
    public double Score { get; set; } 
    public bool IsDeleted { get; set; }
    public Decision Decision { get; set; }
}
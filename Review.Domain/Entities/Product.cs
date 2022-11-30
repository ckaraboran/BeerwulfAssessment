namespace Review.Domain.Entities;

public class Product : BaseEntity, ISoftDelete
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool IsDeleted { get; set; }
}
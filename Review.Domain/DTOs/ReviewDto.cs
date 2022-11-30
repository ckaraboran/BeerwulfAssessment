using Review.Domain.Enums;

namespace Review.Domain.DTOs;

public class ReviewDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Score { get; set; } 
    public bool IsDeleted { get; set; }
    public Decision Decision { get; set; }
}
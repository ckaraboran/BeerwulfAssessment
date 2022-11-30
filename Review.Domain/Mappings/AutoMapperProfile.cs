namespace Review.Domain.Mappings;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Entities.Review, ReviewDto>().ReverseMap();
        CreateMap<Product, ProductDto>().ReverseMap();
    }
}
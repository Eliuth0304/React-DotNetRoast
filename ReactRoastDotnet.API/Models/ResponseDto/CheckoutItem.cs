namespace ReactRoastDotnet.API.Models.ResponseDto;

public record CheckoutItem
{
    public int ProductItemId { get; init; }
    
    public required string Name { get; init; }
    
    public int Quantity { get; init; }
    
    public decimal Price { get; init; }
}
namespace AdminProvider.Domain.Models;

public class ProductRequest 
{
    public string Name { get; set; } = null!; //Obligatorisk
    public string? Description { get; set; } //Valbart

    public decimal Price { get; set; } //ändra till obligatorisk samt string
    public object? Picture { get; set; } //Valbart
}


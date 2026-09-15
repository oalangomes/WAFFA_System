namespace WaffaSystem.Legacy.Domain;

public sealed class Product
{
    public int Code { get; init; }
    public required string Name { get; set; }
    public string? Category { get; set; }
    public string? Supplier { get; set; }
    public int Quantity { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SalePrice { get; set; }
    public int MinimumQuantity { get; set; }
    public int MaximumQuantity { get; set; }
    public string? Serial { get; set; }
    public string? Location { get; set; }

    public decimal UnitProfit => SalePrice - PurchasePrice;

    public bool IsBelowMinimum => Quantity <= MinimumQuantity;
}

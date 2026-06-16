namespace MutirithiaYou_MeBoutique.Models;

public class BoutiqueItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ItemCategory Category { get; set; }
    public string SizeRange { get; set; } = string.Empty; // e.g., "M, L, XL" or "UK 40, 42"
    public string ImageUrl { get; set; } = "/images/placeholder.jpeg"; // Fallback image
    public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    public bool IsNewArrival => (DateTime.UtcNow - DateAdded).TotalDays <= 14;
    public List<string> AvailableColors { get; set; } = new();
}

public enum ItemCategory
{
    Clothing,
    Footwear
}

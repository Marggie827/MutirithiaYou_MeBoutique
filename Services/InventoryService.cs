using MutirithiaYou_MeBoutique.Models;

namespace MutirithiaYou_MeBoutique.Services;

public class InventoryService
{
    private readonly List<BoutiqueItem> _items = new()
    {
        new BoutiqueItem
        {
            Name = "Classic Slim-Fit Blazer",
            Description = "Elegant semi-casual outerwear perfect for meetings.",
            Category = ItemCategory.Clothing,
            SizeRange = "S, M, L  EL",
            DateAdded = DateTime.UtcNow.AddDays(-2),
            AvailableColors = new() { "All-Colors", "Charcoal" }
        },
        new BoutiqueItem
        {
            Name = "Air-Comfort Urban Sneakers",
            Description = "Lightweight running and streetwear shoes with flexible soles.",
            Category = ItemCategory.Footwear,
            SizeRange = "UK 36, 41, 42, 43, 44, 45, 46",
            DateAdded = DateTime.UtcNow.AddDays(-1),
            AvailableColors = new() { "White", "All-Colors" }
        }
    };

    public Task<List<BoutiqueItem>> GetNewArrivalsAsync() =>
        Task.FromResult(_items.Where(i => i.IsNewArrival).OrderByDescending(i => i.DateAdded).ToList());

    public Task<List<BoutiqueItem>> GetItemsByCategoryAsync(ItemCategory category) =>
        Task.FromResult(_items.Where(i => i.Category == category).ToList());
}


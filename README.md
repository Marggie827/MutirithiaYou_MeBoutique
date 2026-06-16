
# Mutirithia You & Me Boutique 👗👟

An online catalog for tracking and filtering footwear and clothing arrivals built with **.NET 10 Blazor Server**. 

Instead of showing fixed item costs, customers can look through the available inventory online and bargain directly via integrated WhatsApp buttons.

---

## ✨ Main Features
Customers can filter the catalog instantly by name, description, or shoe size.
- **💬 Smart WhatsApp Routing**: Button clicks automatically direct the user to the correct phone line based on what they want to buy:
  - **Clothing Items** ➔ Routed to your clothing manager line.
  - **Footwear Items** ➔ Routed to your shoe manager line (`254720688992`).
:  Built ready to be downloaded directly onto phone home screens or compiled for the Google Play Store.

---

## 📁 Key Folders to Know

- 📂 **Components/Pages**: Holds your website page layouts (`Home.razor`, `ClothingCatalog.razor`, `FootwearCatalog.razor`).
- 📂 **Models**: Holds `BoutiqueItem.cs` which defines item rules (Name, Description, Sizes, Colors).
- 📂 **Services**: Holds `InventoryService.cs` which manages the stock listing data.
- 📂 **wwwroot/images**: Put all your `.jpeg` product photos here.

---

## 🚀 How to Run the Project Locally

1. Open the project in **Visual Studio 2022**.
2. Press **`Ctrl + F5`** on your keyboard to compile and run the boutique site.
3. The catalog will launch automatically in your web browser.

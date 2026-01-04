using BestBuyApp.Models;

namespace BestBuyApp.Data;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    Product GetProduct(int id);
    void UpdateProduct(Product product);
    public void InsertProduct(Product productToInsert);
    public IEnumerable<Category> GetCategories();
    public Product AssignCategory();
}
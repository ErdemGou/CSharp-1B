using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

internal class Program
{
    //SOLID
    //Open Closed Principle
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetAllByUnitPrice(40,100))
        {
            Console.WriteLine(product.ProductName);
        }
    }
}
using System;
namespace Methods
{
    public class BoxManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to box: "+ product.productName);

        }
        public void Add2(string productName)
        {
            Console.WriteLine("Added to box: " + productName);
        }
    }
}

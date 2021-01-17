using System;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.productName = "Apple";
            product1.productPrice = 15;
            product1.explanation = "From Amasya";

            Product product2 = new Product();
            product2.productName = "Watermelon";
            product2.productPrice = 40;
            product2.explanation = "From Diyarbakir";

            Product[] products = new Product[] {product1,product2 };

            //type-safe
            foreach(Product product in products)
            {
                Console.WriteLine(product.productName);
                Console.WriteLine(product.productPrice);
                Console.WriteLine(product.explanation);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("------------Methods--------");
            //instance
            BoxManager boxManager = new BoxManager();
            boxManager.Add(product1);
            boxManager.Add(product2);
            boxManager.Add2("Pear", "yellow", 12);
        }
    }
}


//don't repeat yourself - clean code
using MYAZ_203_03;

Product product1 = new Product();
product1.ProductName = "Defter";
product1.Price = 13;

Product product2 = new Product();
product2.ProductName = "KalemTıraş";
product2.Price = 8;

CartItem item1 = new CartItem();
item1.Quantity = 2;
item1.Product = product1;
item1.CartId = 0;
CartItem item2 = new CartItem();
item2.Quantity = 1;
item2.Product = product2;
item2.CartId = 1;


ShoppingCart cart1 = new ShoppingCart();
cart1.Add(item1);
cart1.Add(item2);
cart1.GetList();
Console.WriteLine("-------------");
cart1.Remove(0);
cart1.GetList();
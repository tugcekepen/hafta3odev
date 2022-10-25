using hafta3odev;
Product product1 = new Product(15000, 1, "Phone");
Product product2 = new Product(10000, 2, "Phone");
Product product3 = new Product(30000, 3, "TV");
Product product4 = new Product(12000, 4, "Computer");
Product product5 = new Product(25000, 5, "Tv");

CartItem cartItem1 = new CartItem(1, "Phone", 5);
CartItem cartItem2 = new CartItem(2, "TV", 3);
CartItem cartItem3 = new CartItem(3, "Computer", 4);

ShoppingCart shoppingCart = new ShoppingCart();
shoppingCart.Add(cartItem1);
shoppingCart.Add(cartItem2);
shoppingCart.Add(cartItem3);

shoppingCart.GetList();

Console.WriteLine("");

shoppingCart.Remove(2);

shoppingCart.GetList();

Console.WriteLine("");

shoppingCart.GetBalance(cartItem2.Quantity, product3.Price);
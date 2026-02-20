
Console.WriteLine("Online Store Order");
Console.Write("Product Name: ");
string product = Console.ReadLine();

Console.Write("Quantity: ");
int quantity = Convert.ToInt32(Console.ReadLine());

 Console.Write("Price per Item: ");
double price = Convert.ToDouble(Console.ReadLine());

Console.Write("Discount Percentage: ");
double discountPercent = Convert.ToDouble(Console.ReadLine());

Console.Write("Delivery Distance: ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.Write("First Letter of Payment Method: ");
char paymentLetter = Convert.ToChar(Console.ReadLine());

Console.Write("Is Express Delivery true or false: ");
bool express = Convert.ToBoolean(Console.ReadLine());

double totalPrice = quantity * price;
double discountAmount = totalPrice * discountPercent / 100;
double finalPrice = totalPrice - discountAmount;

Console.WriteLine("Entered Values");
Console.WriteLine(" ");
Console.WriteLine("Product: " + product);
Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Price: " + price);
Console.WriteLine("Discount %: " + discountPercent);
Console.WriteLine("Distance: " + distance);
Console.WriteLine("Payment Letter: " + paymentLetter);
Console.WriteLine("Express Delivery: " + express);
Console.WriteLine(" ");
Console.WriteLine("Data Types");
Console.WriteLine(" ");
Console.WriteLine(quantity.GetType());
Console.WriteLine(price.GetType());
Console.WriteLine(express.GetType());
Console.WriteLine(" ");
Console.WriteLine("Calculations");
Console.WriteLine(" ");
Console.WriteLine("Total Price: " + totalPrice);
Console.WriteLine("Discount Amount: " + discountAmount);
Console.WriteLine("Final Price: " + finalPrice);

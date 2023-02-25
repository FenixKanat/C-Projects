 
internal class Product{
private string name;
private double price;
private int quantity;
 
private double amountToPay;
 
 
public void ReadName(){
 
    Console.WriteLine("Please enter the name of the product");
 
    name= Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("Thanks " + name + " !");
}
 
public void ReadPrice(){
    Console.WriteLine("Enter the price of the product");
 
    String string_price = Console.ReadLine();
    price = double.Parse(string_price);
    Console.WriteLine();
    Console.WriteLine("The price of " + name + " is " + price + "!");
}
 
public void ReadQuantity(){
    Console.WriteLine("How many of the product do you want?");

    String productQuantity = Console.ReadLine();
    quantity = int.Parse(productQuantity);
    Console.WriteLine();
    Console.WriteLine("The amount of the product chosen is/are " + quantity + " .");
}

public void ReadAmountToPay(){
    Console.WriteLine("The amount to pay for your chosen product is: ");
    amountToPay = quantity * price ;
    Console.WriteLine();
    Console.WriteLine("The amount to pay for your products is: " + amountToPay);
}

public void ReadInput(){
ReadName();
ReadPrice();
ReadQuantity();
ReadAmountToPay();
}
 
}
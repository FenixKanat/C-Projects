internal class TicketSeller{

    private String name;
    private double price = 99;
    private int numOfAdults;
    private int numOfChildren;
    private double amountToPay;

//Asks for customer name, assigns the input value to the instance variable "name". 
    public void customerName(){
        Console.WriteLine("Please enter the name of the buyer: ");
        name = Console.ReadLine();
    }

//Asks for the number of adults to buy tickets for in string, converts to int and assigns it to "numOfAdults".
    public void adults(){
        Console.WriteLine("Please enter the number of adults you want to buy tickets for: ");
        String countAdults = Console.ReadLine();
        numOfAdults= int.Parse(countAdults);
    }

//Asks for number of children to buy tickets for, takes input as string, converts it to int and assigns it to numOfChildren.
    public void children(){
        Console.WriteLine("Please enter the number of children you want to buy tickets for: ");
        String countChildren = Console.ReadLine();
        numOfChildren = int.Parse(countChildren);
    }

//Calculated amountToPay by multiplying numOfAdults with price, and numOfChildren with price, and adding these two to get a total.
    public void Total(){
        amountToPay = numOfAdults * price + numOfChildren * price ;

    }

//Calls to the methods customerName(), adults(), children() and Total() and prints these out. 
    public void TicketSellerStart(){

        customerName();
        adults();
        children();
        Total();

        Console.WriteLine("Customer Name: " + name + "\nAdults: " + numOfAdults + "\nChildren: " + numOfChildren + "\nYour total is: " + amountToPay + " kr.");
    }

}
internal class TicketSeller{

    private String name;
    private double price = 99;
    private int numOfAdults;
    private int numOfChildren;
    private double amountToPay;

    public void customerName(){
        Console.WriteLine("Please enter the name of the buyer: ");
        name = Console.ReadLine();
    }

    public void adults(){
        Console.WriteLine("Please enter the number of adults you want to buy tickets for: ");
        String countAdults = Console.ReadLine();
        numOfAdults= int.Parse(countAdults);
    }

    public void children(){
        Console.WriteLine("Please enter the number of children you want to buy tickets for: ");
        String countChildren = Console.ReadLine();
        numOfChildren = int.Parse(countChildren);
    }

    public void Total(){
        amountToPay = numOfAdults * price + numOfChildren * price ;

    }

    public void TicketSellerStart(){

        customerName();
        adults();
        children();
        Total();

        Console.WriteLine("Customer Name: " + name + "\nAdults: " + numOfAdults + "\nChildren: " + numOfChildren + "\nYour total is: " + amountToPay + " kr.");
    }

}
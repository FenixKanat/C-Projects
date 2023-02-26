// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public partial class Program{
 
    static void main(String [] args){
        Console.WriteLine("Welcome to my shop");
        Product product = new Product();
        product.ReadInput();
    }
}
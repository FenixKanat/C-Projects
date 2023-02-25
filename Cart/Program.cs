// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
internal class Program{
 
    static void Main(String [] args){
        Console.WriteLine("Welcome to my shop");
        Product product = new Product();
        product.ReadInput();
    }
}
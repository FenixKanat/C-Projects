
public partial class MainProgram{

//Calls Start() method from FunFeatures class. 
//Calls its own method "ContinueNextPart()"
static void Main(String [] args){
FunFeatures fun = new FunFeatures();
fun.Start();

ContinueToNextPart();
}

//Takes input from user, clears the console.
private static void ContinueToNextPart(){
    Console.WriteLine("\nPress Enter to continue to the next part!");
    Console.ReadLine();
    Console.Clear();
}

}
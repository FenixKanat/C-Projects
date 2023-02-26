internal partial class FunFeatures{
private string email = "";
private string firstName = "";
private string lastName = "";

private string name = "";


public void CalculateStrengthLength(){
    Console.WriteLine("\n---- STRENGTH LENGTH -----");
    Console.WriteLine("\nWrite a text with any number of characters and press Enter.\nYou can even copy text from a file and paste it here!\n");
    string userText = Console.ReadLine();
    Console.WriteLine("\n"+userText.ToUpper());
    int countChars = userText.Length;
    Console.WriteLine("\nNumber of chars = " + countChars);

}

private void Introduce(){

    Console.WriteLine("My name is Fenix and I am a student of the Spring 2023 semester. ");
    Console.WriteLine();
    Console.WriteLine("Let me know about yourself! ");

ReadName();
ReadEmail();
    String [] newName = name.Split(" ");
    Console.WriteLine("\nNice to meet you " + newName[1] + "," + newName[0] );
    Console.WriteLine("Your email is: " + email);

CalculateStrengthLength();
PredictMyDay();
    
}

public void PredictMyDay(){
    int chosenDay;

    Console.WriteLine("***** Predict MY DAY *****n"); 
    Console.WriteLine("Select a number betwee 1 and 7");
    String dayNum = Console.ReadLine();
    chosenDay = int.Parse(dayNum);

    switch(chosenDay){
        case 1: 
        Console.WriteLine("\nKeep calm on Mondays! You can fall apart!");
        break;

        case 2: 
        Console.WriteLine("\nTuesdays break your heart!");
        break;

        case 3:
        Console.WriteLine("\nWednesdays dont matter! ");
        break; 

        case 4: 
        Console.WriteLine("\nThursday is your lucky day, don't wait for Friday!");
        break;

        case 5:
        Console.WriteLine("\nFriday, you are in love!");
        break; 

        case 6: 
        Console.WriteLine("\nSaturday, do nothing and do plenty of it!");
        break;

        case 7: 
        Console.WriteLine("\nAnd Sunday always comes too soon");
        break;

        default:
        Console.WriteLine("\nNo day? is a good day but it doesn't exist!");
        break;
        
    }

    

}

public void ReadEmail(){

    Console.WriteLine("Your email please: ");
    email = Console.ReadLine();
    

}

public void ReadName(){
    Console.WriteLine("Your first name please:");
    firstName = Console.ReadLine();

    Console.WriteLine("Your last name please: ");
    lastName = Console.ReadLine(); 

    name = firstName + " " + lastName.ToUpper();
}

private bool RunAgain(){

    return true;
}

public void Start(){
    Introduce();
}
}
internal partial class FunFeatures{
private string email = "";
private string firstName = "";
private string lastName = "";

private string name = "";

/*
Asks the user to input a sentence. 
Assigns the input to a string var called userText. 
Prints the string in capital letters. 
Assigns the length of the string to int var called countChars. 
Prints it to the console. 
*/
public void CalculateStrengthLength(){
    Console.WriteLine("\n---- STRENGTH LENGTH -----");
    Console.WriteLine("\nWrite a text with any number of characters and press Enter.\nYou can even copy text from a file and paste it here!\n");
    string userText = Console.ReadLine();
    Console.WriteLine("\n"+userText.ToUpper());
    int countChars = userText.Length;
    Console.WriteLine("\nNumber of chars = " + countChars);

}

/*
Introduction about me. 
Calls the methods that takes input of users name and email. 
Creates a new string array called newName that stores two elements. 
Prints the second element first that being last name, and first element as second that being first name. 
Calls the methods CalculateStrengthLength() and PredictMyDay()
*/
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

/*
Asks user for input
Takes input as string, converts to int and stores in an int variable. 
Switch(int) in order to determine what user has chosen and what value will be returned to the user.
If not between 1-7 then default value which says "there is no such day". 
*/
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

/*
Asks for users email, stores input in a string var. 
*/
public void ReadEmail(){

    Console.WriteLine("Your email please: ");
    email = Console.ReadLine();
    

}

/*
Asks for users first and last name, stores in diff string vars. 
Stores firstName, space and lastName in its converted form into the string variable "name". 
*/
public void ReadName(){
    Console.WriteLine("Your first name please:");
    firstName = Console.ReadLine();

    Console.WriteLine("Your last name please: ");
    lastName = Console.ReadLine(); 

    name = firstName + " " + lastName.ToUpper();
}


/*
Asks user for input, if yes, returns true. If no , returns false. if something else, prints "invalid" and asks for input again.
*/
private bool RunAgain(){
    Console.WriteLine("Continue with another round? (yes/no)\n");
    String userChoice = Console.ReadLine();

    if(userChoice == "yes"){
        return true;
    }
    else if(userChoice == "no"){
    return false;
    }else {
        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
        return RunAgain();
    }
}

/*
The start method for this project
Calls introduce method and RunIteration method. */
public void Start(){
    
    Introduce();
    RunIteration();
   
}

/*
While RunAgain is true, calls CalculateStrengthLength() and PredictMyDay()
*/
public void RunIteration(){
    while(RunAgain()){
        CalculateStrengthLength();
        PredictMyDay();
    }
}
}
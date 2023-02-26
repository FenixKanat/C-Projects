internal partial class FunFeatures{
private string email = "";
private string firstName = "";
private string lastName = "";

private string name = "";


public void CalculateStrengthLength(){

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
    
}

public void PredictMyDay(){

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
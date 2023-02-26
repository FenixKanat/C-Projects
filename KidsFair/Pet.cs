internal class Pet{
    
    private String name; 
    private int age; 
    private bool isFemale; 

//This method asks for the pets name, takes input from user and assigns it to "name".   
    public void petName(){

        Console.WriteLine("Please enter the name of your pet below: ");
        name = Console.ReadLine();
        Console.WriteLine();


    }

//This method asks for the pets age, takes input from user as string, converts it to int and assigns it to "age" 
    public void petAge(){
        
        Console.WriteLine ("Please enter the age of " + name + " below: ");
        String ageofPet = Console.ReadLine();
        age = int.Parse(ageofPet);
        Console.WriteLine();

    }

//This method asks for the pets gender, takes the input as string. Checks if the input is "yes" then isFemale = true if "no" then false.
//If invalid input, asks for input again. 
    public void petGender(){

        Console.WriteLine("Is " + name + " female ? (yes/no)"); 
        String petGender = Console.ReadLine();
        
        if(petGender.ToLower() == "yes"){
            isFemale = true;
        }

        else if (petGender.ToLower() == "no"){
            isFemale = false;
        }

        else{
            Console.WriteLine("Invalid Input, please enter yes or no as answer.");
           
        }

        
    }

//This method calls the methods petName(), petAge() and petGender(). And prints it out. 
    public void StartPet(){
        petName();
        petAge();
        petGender();

        Console.WriteLine("The name of your pet is : " + name + "\nThe age of " + name + " is " + age + " and the gender of " + name + " is " + (isFemale ? "female" : "male") );
    }

   
}

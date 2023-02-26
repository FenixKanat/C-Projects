internal class Pet{

    private String name; 
    private int age; 
    private bool isFemale; 

  
    public void petName(){

        Console.WriteLine("Please enter the name of your pet below: ");
        name = Console.ReadLine();
        Console.WriteLine();


    }

    public void petAge(){
        
        Console.WriteLine ("Please enter the age of " + name + " below: ");
        String ageofPet = Console.ReadLine();
        age = int.Parse(ageofPet);
        Console.WriteLine();

    }

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

    public void StartPet(){
        petName();
        petAge();
        petGender();

        Console.WriteLine("The name of your pet is : " + name + "\nThe age of " + name + " is " + age + " and the gender of " + name + " is " + (isFemale ? "female" : "male") );
    }

   
}

internal class Netflix{


private String userNameFirst;
private String userNameSecond;
private int userAge;
private String userAddress; 
private int numOfSeries; 
private int numOfFilms; 


//Takes user information such as name, age, address.
public void userInformation(){
    Console.WriteLine("Please enter your first name: ");
    userNameFirst = Console.ReadLine();

    Console.WriteLine("Please enter your last name: "); 
    userNameSecond = Console.ReadLine();

    Console.WriteLine ("Please enter your age: "); 
    String ageOfUser = Console.ReadLine();
    userAge=int.Parse(ageOfUser);

    Console.WriteLine("Please enter your address: "); 
    userAddress = Console.ReadLine();

}

//This method returns a string array. Takes input from user in String, converts it to int and assigns it to the array favoriteSeries.
//This decides the length of the array. Later, it asks for the user which series they watch, taking input by using a for loop.
//Assigns the input from the user to the array, and returns the array. 
public String[] SeriesAvailable(){
    Console.WriteLine("\nHow many series are you currently watching ?");
    String seriesByUser = Console.ReadLine();
    numOfSeries = int.Parse(seriesByUser);

    String [] favoriteSeries = new String[numOfSeries];

    Console.WriteLine("\nEnter your most watched series");
    for(int i = 0; i < favoriteSeries.Length; i++){
        favoriteSeries[i] = Console.ReadLine();
    }

     Console.WriteLine();
     

    return favoriteSeries;

}

//This method returns a string array. 
//Asks user the num of films they watch. Converts this to int and assigns it to numOfFilms. 
//Assigns the numOfFilms to the array favoriteFilms, as it being its length. 
//Asks the user their most watched films, takes input within a for loop and assigns the input as elements of the favoriteFilms array.
//Returns the array.
public String[] FilmsAvailable(){
    Console.WriteLine("\nHow many films are you currently watching ?");
    String filmsByUser = Console.ReadLine();
    numOfFilms = int.Parse(filmsByUser);

    String [] favoriteFilms = new String[numOfFilms];

    Console.WriteLine("\nEnter your most watched films");
    for(int i = 0; i < favoriteFilms.Length; i++){
        favoriteFilms[i] = Console.ReadLine();
        
    }

    Console.WriteLine();
   

return favoriteFilms;

    
}

//Calls the method userInformation()
// Creates two string arrays that takes the arrays returned from the methods SeriesAvailable() and FilmsAvailable()
// Prints the array elements out by using a for loop. 
public void NetflixStart(){
    userInformation();


    string[] mostWatchedSeries = SeriesAvailable();
    string[] mostWatchedFilms = FilmsAvailable();

    Console.WriteLine("\nYour first name is: " + userNameFirst + "\nYour last name is: " + userNameSecond + "\nYour address is: " + userAddress + "\nYour age is: " + userAge );

    Console.WriteLine("\nYour most watched Netflix series are: ");
    for(int i=0; i<mostWatchedSeries.Length; i++){
        Console.WriteLine(mostWatchedSeries[i]);
    }

    Console.WriteLine("\nYour most watched Netflix films are: ");
    for(int i=0; i<mostWatchedFilms.Length; i++){
        Console.WriteLine(mostWatchedFilms[i]);
    }

    
    
 
    
}


}
internal class Albume{

private String albumName;
private String artistName;
private int numOfTracks;


public void Album(){

    Console.WriteLine("Enter the name of the albume: ");
    albumName = Console.ReadLine();

}

public void Artist(){

    Console.WriteLine("Enter the name of the artist: ");
    artistName = Console.ReadLine();

}

public void Tracks(){
    Console.WriteLine("Enter the number of tracks: ");
    String numoftr = Console.ReadLine();
    numOfTracks = int.Parse(numoftr);
}

public void StartAlbum(){

    Album();
    Artist();
    Tracks();

    Console.WriteLine ("The name of the album is: " + albumName + "\nThe name of the artist is: " + artistName + "\nThe number of tracks are: " + numOfTracks);

}
}
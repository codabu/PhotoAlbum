//Author - Corry Burton

using Newtonsoft.Json;
using PhotoAlbum;



Logic logic = new Logic();


//while loop to exit program when 0 is entered
while (logic.album != 0)
{

    //get initial input from user
    Console.WriteLine("Which photo album would you like to view? (1 - 100). Type 0 to exit.");
    string? input = Console.ReadLine();
    
   

    while (!logic.CheckUserInput(input))
    {
        Console.WriteLine("Please enter a valid album number.");
        Console.WriteLine("Which photo album would you like to view? (1 - 100). Type 0 to exit.");
        input = Console.ReadLine();
    }

    //check for exit
    if (input == "0") break;

    //get Json for album number
    var responseBody = await logic.GetJson();

    //convert Json to list of photos
    List<Photo> photos = logic.ConvertJson(responseBody);

    //Display album number
    logic.DisplayAlbumNumber(photos);

    //Display photos
    logic.DisplayPhotos(photos);

}





namespace ConsumeServicesWithCSharp
{
    using System;
    
    using MusicSystem.Models;

    public class ConsumeServicesWithCSharp
    {
        static  void Main()
        {
            // Get first song
            // Start here all methods are connected for easier testing!
            // After first start you need to change id in delete method to delete another song!
            MakeGetRequest();
            
            // Get all songs
            // MakeGetRequestAllSongs();

            // Add new song
            // MakePostRequest();

            // Update song with id 1
            // MakePutRequest();

            // Delete song by id
            // MakeDeleteRequest();

            while (true)
            {
                Console.ReadLine();
            }  
        }

        // After every start you need to change number after songs/# with existing sing id
        private static void MakeDeleteRequest()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("     Delete song:");
            Console.WriteLine("=======================");
            var responce = Requester.MakeDeleteRequest("songs/9");
            responce.GetAwaiter()
                .OnCompleted(
                ()=> Console.WriteLine(responce.Result));
        }

        private static void MakePutRequest()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("     Update song:");
            Console.WriteLine("=======================");
            var putSong = new Song
            {
                Id = 1,
                Title = "FirstSong",
                AlbumId = 1,
                ArtistId = 1,
                Year = 2014,
                Genre = Genre.Jazz
            };

            var responce = Requester.MakePutRequest("songs/1", putSong);
            responce.GetAwaiter()
                .OnCompleted(
                    ()=>
                    {
                        Console.WriteLine(responce.Result);
                        MakeDeleteRequest();
                    });
        }

        private static void MakePostRequest()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("     Add new song:");
            Console.WriteLine("=======================");
            var song = new Song
            {
                Title = "Nananana",
                AlbumId = 1,
                ArtistId = 1,
                Year = 2014,
                Genre = Genre.Jazz
            };

            var response = Requester.MakePostRequest("songs", song);
            response.GetAwaiter()
                .OnCompleted(
                    () =>
                    {
                        Console.WriteLine(response.Result);
                        MakePutRequest();
                    });
        }

        private static void MakeGetRequestAllSongs()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("     Get all songs:");
            Console.WriteLine("=======================");
            var songs = Requester.MakeGetRequest("songs");
            songs.GetAwaiter()
                .OnCompleted(
                    () =>
                    {
                        Console.WriteLine(songs.Result);
                        MakePostRequest();
                    });
        }

        private static void MakeGetRequest()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("     Get first songs:");
            Console.WriteLine("=======================");

            var resultSong = Requester.MakeGetRequest("songs/1");
            resultSong.GetAwaiter()
                .OnCompleted(
                    () =>
                    {
                        Console.WriteLine(resultSong.Result);
                        MakeGetRequestAllSongs();
                    });
        }
    }
}

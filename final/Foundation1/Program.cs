using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create videos
        List<Video> videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 300),
            new Video("Video 2", "Author 2", 420),
            new Video("Video 3", "Author 3", 240)
        };

        // Add comments to videos
        videos[0].AddComment("User1", "Great video!");
        videos[0].AddComment("User2", "Nice content!");

        videos[1].AddComment("ViewerX", "Very informative.");
        videos[1].AddComment("ViewerY", "Could use more examples.");

        videos[2].AddComment("JohnDoe", "Short and sweet.");
        videos[2].AddComment("JaneDoe", "Love it!");

        // Display video information and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.Length}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}



using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Video 1 C# 
        Video vid1 = new Video("Introduction C#", "TechGguru", 620);
        vid1.Comments.Add(new Comment("Raul", "Incredible explanation"));
        vid1.Comments.Add(new Comment("Carla", "Very useful for beginners"));
        vid1.Comments.Add(new Comment("Felipe", "Great content, thank you"));

        //Video2 OOP
        Video vid2 = new Video("Object-Oriented Programming Principles", "DevMaster", 950);
        vid2.Comments.Add(new Comment("Ana", "Now I understand everything about classes"));
        vid2.Comments.Add(new Comment("Esteban", "Excellent clarity in the concepts"));
        vid2.Comments.Add(new Comment("Luz", "I would like more practical examples"));

        //Video 3 Abstraction
        Video vid3 = new Video("Abstraction in Programming", "CodeAcademy", 780);
        vid3.Comments.Add(new Comment("Jose", "Topic explained precisely"));
        vid3.Comments.Add(new Comment("Martin", "Very clear, thank you"));
        vid3.Comments.Add(new Comment("Elena", "It helped me a lot to understand the concept"));

        //List of videos
        List<Video> videos = new List<Video> { vid1, vid2, vid3 };

        //Iterate over the list of videos and display details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration (seconds): {video.GetNumberOfDuration()}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" - {comment.AuthorName} {comment.Text}");
            }

            Console.WriteLine();
        }

        //Final message
        Console.WriteLine("All videos have been displayed!");
    }
}
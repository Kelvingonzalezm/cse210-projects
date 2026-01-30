using System;
using System.Collections.Generic;

public class Video
{
    //Attributes
    public string Title { get; set; }
    public string Author { get; set; }
    public int DurationInSeconds { get; set; }

    //List of Comments
    public List<Comment> Comments { get; set; }

    //Constructor
    public Video(string title, string author, int durationInSeconds)
    {
        Title = title;
        Author = author;
        DurationInSeconds = durationInSeconds;
        Comments = new List<Comment>();
    }

    //Method that returns the number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }



    public string GetNumberOfDuration()
    {
        int minutes = DurationInSeconds / 60;
        int seconds = DurationInSeconds % 60;
        return $"{minutes}m {seconds}s";
    }
}
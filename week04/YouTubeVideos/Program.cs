using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Solder", "ElectroMan", 300);
        video1.AddComment(new Comment("Ricardo", "Great video!"));
        video1.AddComment(new Comment("Leticia", "Very helpful."));
        video1.AddComment(new Comment("Carlos", "Excellent explanation."));
        videos.Add(video1);

        Video video2 = new Video("Arduino Basics", "TechWorld", 450);
        video2.AddComment(new Comment("Sofia", "Thanks for the tutorial."));
        video2.AddComment(new Comment("Luis", "Very clear."));
        video2.AddComment(new Comment("Marta", "Just what I needed."));
        videos.Add(video2);

        Video video3 = new Video("3D Printing Tips", "MakersHub", 520);
        video3.AddComment(new Comment("Ana", "I will try this."));
        video3.AddComment(new Comment("Pedro", "Nice trick!"));
        video3.AddComment(new Comment("Diego", "Great contribution."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}

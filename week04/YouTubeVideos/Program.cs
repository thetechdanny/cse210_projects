using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Abstraction and Encapsulation", "Danny", 300);
        video1.AddComment(new Comment("Caleb", "Nice Job!"));
        video1.AddComment(new Comment("Elizabeth", "Continue Learning!"));
        video1.AddComment(new Comment("Chris", "Weldone on your effort."));
        video1.AddComment(new Comment("Danny", "I am impressed."));

        Video video2 = new Video("C# List", "Danny", 400);
        video2.AddComment(new Comment("Sarah", "Great Job!"));
        video2.AddComment(new Comment("James", "Wow, I am impressed"));
        video2.AddComment(new Comment("Emma", "Thanks for this!"));

        Video video3 = new Video("C# Tutorial", "Danny", 900);
        video3.AddComment(new Comment("Chris", "Nice one!"));
        video3.AddComment(new Comment("Nneka", "This is fun"));
        video3.AddComment(new Comment("Grace", "Thanks a lot"));
        video3.AddComment(new Comment("Ted", "Wow, this is amazing"));
        video3.AddComment(new Comment("Jessie", "This is incredible"));


        List<Video> videos = new List<Video> { video1, video2, video3 };


        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}

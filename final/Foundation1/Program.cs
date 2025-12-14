using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Healing Power of Gratitude", "Russell M. Nelson", 706);
        Video video2 = new Video("Estaras En Mi Corazon", "Phill Collins", 233);
        Video video3 = new Video("Gratitude", "Brandon Lake", 354);

        Comment comment1 = new Comment("Rachael", "Love it!");
        Comment comment2 = new Comment("Jessilyn", "So authenthic");
        Comment comment3 = new Comment("jhonatan", "Sounds great!");

        Comment comment4 = new Comment("Ana", "Beautiful song");
        Comment comment5 = new Comment("John", "I love this");
        Comment comment6 = new Comment("Maya", "It sounds great");

        Comment comment7 = new Comment("Alex", "So profound");
        Comment comment8 = new Comment("Kim", "Thanks for sharing!");
        Comment comment9 = new Comment("Jorge", "Give thanks!");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video v in videos)
        {
            v.DisplayInfo();
        }

    }
}
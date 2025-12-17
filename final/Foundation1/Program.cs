using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("The Healing Power of Gratitude", "Russell M. Nelson", 706),
            new Video("Estaras En Mi Corazon", "Phill Collins", 233),
            new Video("Gratitude", "Brandon Lake", 354)
        };

        videos[0].AddComment(new Comment("Rachael", "Love it!"));
        videos[0].AddComment(new Comment("Jessilyn", "So authenthic"));
        videos[0].AddComment(new Comment("jhonatan", "Sounds great!"));

        videos[1].AddComment(new Comment("Ana", "Beautiful song"));
        videos[1].AddComment(new Comment("John", "I love this"));
        videos[1].AddComment(new Comment("Maya", "It sounds great"));

        videos[2].AddComment(new Comment("Alex", "So profound"));
        videos[2].AddComment(new Comment("Kim", "Thanks for sharing!"));
        videos[2].AddComment(new Comment("Jorge", "Give thanks!"));

        foreach (Video v in videos)
        {
            v.DisplayInfo();
        }
    }
}
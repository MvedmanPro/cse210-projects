using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var videos = new List<Video>
        {
            new Video("How to start baking?", "Sweet_Bakery", 460),
            new Video("Learn Abstraction in C#", "Pro IT", 900),
            new Video("Learn/Practice Exponents", "Math In Minutes", 600)
        };

        videos[0].AddComment(new Comment("_Inna234", "Great, clear recipe!"));
        videos[0].AddComment(new Comment("Mary98", "Thanks for sharing."));
        videos[0].AddComment(new Comment("0983info", "I needed this."));
        videos[0].AddComment(new Comment("re_222", "I was searching for this."));

        videos[1].AddComment(new Comment("panda44", "Great video!"));
        videos[1].AddComment(new Comment("spiderman", "Thanks for explaining."));
        videos[1].AddComment(new Comment("MonaLisa", "Very informative and clear."));
        videos[1].AddComment(new Comment("lana0", "I like C#"));
        videos[1].AddComment(new Comment("bird99", "Easy, clear and fun, as for me."));

        videos[2].AddComment(new Comment("student", "I have a test tomorrow, thanks."));
        videos[2].AddComment(new Comment("Sarah", "I knew it was that easy!"));
        videos[2].AddComment(new Comment("2389_human", "My teacher suggested me to watch this, thanks."));

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.title}, Author: {video.author}, Length: {video.length}s, Number of comments: {video.GetNumberOfComments()}");
            foreach (var comment in video.comments)
            {
                Console.WriteLine($"{comment.name}: {comment.text}");
            }
        }
    }
}

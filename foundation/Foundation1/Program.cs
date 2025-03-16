using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Epic", "Johnny Smith", 120);
        Comment comment1 = new Comment("Adam", "Great video!");
        Comment comment2 = new Comment("Kaylee", "Lets goooo");
        Comment comment3 = new Comment("JJ", "WOW!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.DisplayVideo();

        Video video2 = new Video("C# tutorial for beginners", "BroCode", 200);
        Comment comment4 = new Comment("Jonas123", "Great tutorial, thank you:");
        Comment comment5 = new Comment("James", "Thanks for clarifying.");
        Comment comment6 = new Comment("Cody", "nice");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.DisplayVideo();

        Video video3 = new Video("How to tie a tie", "Ty Rogers", 90);
        Comment comment7 = new Comment("Michael Scott", "Thanks bro, it worked");
        Comment comment8 = new Comment("Ty Rhodes", "Thanks, matches my name even");
        Comment comment9 = new Comment("AJ", "Yoooooo");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.DisplayVideo();
    }
}
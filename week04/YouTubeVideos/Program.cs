using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Pepsi Ad", "Pepsi International", 120);
        Video video2 = new Video("Dr. Pepper Ad", "Dr. Pepper", 35);
        Video video3 = new Video("Mott's Ad", "Mott's Juice LLC", 78);

        video1.AddComment(new Comment("Cyrus", "Pepsi is my favorite!"));
        video1.AddComment(new Comment("Aria", "Pepsi tastes like medicine..."));
        video1.AddComment(new Comment("Shilo", "I can't have caffeinated drinks."));

        video2.AddComment(new Comment("Cyrus", "It tastes like cough syrup..."));
        video2.AddComment(new Comment("Aria", "Dr. Pepper is my favorite!"));
        video2.AddComment(new Comment("Shilo", "I can't have caffeinated drinks."));

        video3.AddComment(new Comment("Cyrus", "I like stuff with bubbles"));
        video3.AddComment(new Comment("Aria", "They have good fruit snacks."));
        video3.AddComment(new Comment("Shilo", "I love apple juice!"));
        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine();
            video.DisplayVideo();
        }
    }
}
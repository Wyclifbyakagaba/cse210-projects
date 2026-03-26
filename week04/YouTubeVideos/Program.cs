using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Learn C#", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "This video was very helpful!"));
        video1.AddComment(new Comment("Brian", "I understand classes better now."));
        video1.AddComment(new Comment("Cathy", "Great explanation and examples."));

        Video video2 = new Video("Top 10 Football Skills", "Sports Hub", 480);
        video2.AddComment(new Comment("David", "Amazing skills!"));
        video2.AddComment(new Comment("Emma", "My favorite player was featured."));
        video2.AddComment(new Comment("Frank", "Nice editing on this video."));

        Video video3 = new Video("Best Study Tips for Students", "Success Zone", 720);
        video3.AddComment(new Comment("Grace", "These tips are useful for exams."));
        video3.AddComment(new Comment("Henry", "I will try the time-blocking idea."));
        video3.AddComment(new Comment("Irene", "Very motivating content."));

        Video video4 = new Video("Beginner Workout Routine", "Fit Life", 900);
        video4.AddComment(new Comment("James", "This routine looks easy to follow."));
        video4.AddComment(new Comment("Kelly", "Thanks for sharing this workout."));
        video4.AddComment(new Comment("Leo", "I will start this tomorrow."));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        foreach (Video video in videos)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLength()}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}

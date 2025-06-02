using System;

class Program
{
    static void Main(string[] args)
    {

    // First Video
        Video video1 = new Video();
        video1.Title = "Applications of C# Programming";
        video1.Author = "Jane Smith";
        video1.Length = 360;

        Comment video1Comment1 = new Comment("Emily Miller", "Great video!");
        Comment video1Comment2 = new Comment("Patrick Bean", "I'm glad I can use C# for game development! That's what I want to do and I understand C# the most.");
        Comment video1Comment3 = new Comment("Rebeka Flemming", "This is confusing. Why are getters and setters even used if there are private variables?");
        Comment video1Comment4 = new Comment("Bryce Humphreys", "There are a lot more applications of C# than I thought!");

        // Add comments to video1
        video1.AddComment(video1Comment1);
        video1.AddComment(video1Comment2);
        video1.AddComment(video1Comment3);
        video1.AddComment(video1Comment4);



    // Second Video
        Video video2 = new Video();
        video2.Title = "How to skin a fish";
        video2.Author = "Jackson Brown";
        video2.Length = 452;

        Comment video2Comment1 = new Comment("Stuart Rose", "I have a similar video on my channel! Check it out if you want to see how I do it.");
        Comment video2Comment2 = new Comment("Thomas Johnson", "I have that same knife. It's great for skinning fish!");
        Comment video2Comment3 = new Comment("Mitchell Blevins", "I never knew skinning a fish was so easy! I always thought it was complicated.");
        Comment video2Comment4 = new Comment("Forrest Clayton", "What fishing rod do you use? I want to get into fishing and I need a good rod to start with.");

        // Add comments to video2
        video2.AddComment(video2Comment1);
        video2.AddComment(video2Comment2);
        video2.AddComment(video2Comment3);
        video2.AddComment(video2Comment4);



    // Third Video
        Video video3 = new Video();
        video3.Title = "2015 NCAA Wrestling Championships Highlights";
        video3.Author = "Ally Haze";
        video3.Length = 965;

        Comment video3Comment1 = new Comment("Brian McDaniel", "That one 125 pounder was so fast! I can't believe how quickly he got that takedown!");
        Comment video3Comment2 = new Comment("Tony Carter", "The stamina exhibited by these athletes is incredible! I can barely run a mile without stopping.");
        Comment video3Comment3 = new Comment("Coddy Cubbage", "That head and arm throw was so clean! I love it!");
        Comment video3Comment4 = new Comment("Xavier Black", "I love wrestling! This is awesome!");

        // Add comments to video3
        video3.AddComment(video3Comment1);
        video3.AddComment(video3Comment2);
        video3.AddComment(video3Comment3);
        video3.AddComment(video3Comment4);



    // Fourth Video
        Video video4 = new Video();
        video4.Title = "How to tie a necktie";
        video4.Author = "Eric Clifton";
        video4.Length = 258;

        Comment video4Comment1 = new Comment("Tim McKenzie", "Short and sweet, I like it!");
        Comment video4Comment2 = new Comment("Jason Todd", "I think I prefer the single windsor to the double. I like the smaller knot.");
        Comment video4Comment3 = new Comment("Maria Sanchez", "Do you do other tutorials like this? I like the way you explain things!");
        Comment video4Comment4 = new Comment("Billy Jean", "I bet Michael Jackson tied his ties like this...");

        // Add comments to video2
        video4.AddComment(video4Comment1);
        video4.AddComment(video4Comment2);
        video4.AddComment(video4Comment3);
        video4.AddComment(video4Comment4);






        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Iterate through the list and display video info and number of comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("\nComments:");
            // Iterate through the comments for each video
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommentText} - {comment.GetCommenterName}");
            }
           
           
           
           
            // foreach (var comment in comment.ToString())
            // {
            //     Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            // }
            Console.WriteLine();
        }
    }
}
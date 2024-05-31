using System;

class Program
{
    static void Main(string[] args)
    {
        //Videos
        Video video1 = new Video("The lake history", "Jean walker", 300);
        Video video2 = new Video("Flowers", "Morgan Smith", 420);
        Video video3 = new Video("Animal Life", "George Freire", 457);

        //Comments
        video1.addComment(new Comment("Samuel","I love histories"));
        video1.addComment(new Comment("Charlie","Amazing. This is a great video!"));
        video1.addComment(new Comment("Christian","I'm fascinated"));

        video2.addComment(new Comment("Carl","I loved this video"));
        video2.addComment(new Comment("Jason","This is a good video."));
        video2.addComment(new Comment("Marya","Wow, I learned a lot."));

        video3.addComment(new Comment("Spencer","Incredible!"));
        video3.addComment(new Comment("Jhon","Very interesting"));
        video3.addComment(new Comment("Paul","I liked it so much!"));

        List<Video> videos = new List<Video>{video1, video2, video3};

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.getTitle()}");
            Console.WriteLine($"Author: {video.getAuthor()}");
            Console.WriteLine($"Duration: {video.getVideoSeconds()}");
            Console.WriteLine($"Number of Comments: {video.getnumberComments()}");
            Console.WriteLine("Comments: ");

            foreach (Comment comment in video.getComments())
            {
                Console.WriteLine($"{comment.getCommenterName()}: {comment.getCommenterContent()}");
            }
        }

    }
}
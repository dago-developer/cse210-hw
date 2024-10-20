class Program
{
    static void Main()
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Juan Pérez", 300);
        video1.AddComment(new Comment("Ana", "Great tutorial!"));
        video1.AddComment(new Comment("Luis", "It helped me a lot, thanks."));
        video1.AddComment(new Comment("Carlos", "Excellent explanation."));
        videos.Add(video1);

        Video video2 = new Video("Introduction to Programming", "María López", 250);
        video2.AddComment(new Comment("Sofía", "Very clear and concise."));
        video2.AddComment(new Comment("Pedro", "Interesting, I want more."));
        videos.Add(video2);

        Video video3 = new Video("Advanced C#", "Pedro Martínez", 450);
        video3.AddComment(new Comment("Fernando", "The content is very useful."));
        video3.AddComment(new Comment("Luis", "I hope for more videos like this."));
        video3.AddComment(new Comment("Javier", "I would like to see more examples."));
        videos.Add(video3);

        Video video4 = new Video("C# Tips and Tricks", "Laura García", 360);
        video4.AddComment(new Comment("Diego", "Very helpful tips!"));
        video4.AddComment(new Comment("Sofia", "I learned a lot from this video."));
        video4.AddComment(new Comment("Miguel", "Thanks for sharing!"));
        videos.Add(video4);

        // Iterate the list
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}

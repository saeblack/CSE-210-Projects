using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        Video _video1 = new Video("The Next Big Thing", "Jack Mark", 120);
        Video _video2 = new Video("THIS IS A WASTE OF TIME", "?", 300);
        Video _video3 = new Video("Get A Look At This", "POOKIE", 240);

        // Add comments to the videos
        _video1.AddComment(new Comment("TROLL", "Great video!"));
        _video1.AddComment(new Comment("Shaddy", "Thanks for the info."));
        _video1.AddComment(new Comment("NoobMaster", "Very helpful!"));

        _video2.AddComment(new Comment("Cupcake", "Awesome content!"));
        _video2.AddComment(new Comment("Bigdaddy", "Loved it!"));
        _video2.AddComment(new Comment("Bigmama", "Please make more."));

        _video3.AddComment(new Comment("superdog", "Informative video."));
        _video3.AddComment(new Comment("chickenbut", "I learned a lot."));
        _video3.AddComment(new Comment("chaddercheese", "Well explained."));

        // Add videos to the list
        AbstractVideo.AddVideo(_video1);
        AbstractVideo.AddVideo(_video2);
        AbstractVideo.AddVideo(_video3);

        // Display all videos and their comments
        AbstractVideo.DisplayVideos();
    }
}



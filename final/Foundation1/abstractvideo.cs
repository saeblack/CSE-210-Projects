using System;
using System.Collections.Generic;

public static class AbstractVideo
{
    public static List<Video> _VideosList { get; } = new List<Video>();

    public static void DisplayVideos()
    {
        foreach (var video in _VideosList)
        {
            Console.WriteLine(video);
            foreach (var _comment in video.GetComments())
            {
                Console.WriteLine(_comment);
            }
            Console.WriteLine();
        }
    }

    public static void AddVideo(Video _video)
    {
        _VideosList.Add(_video);
    }
}
using System;
using System.Collections.Generic;

public class Video
{
    public string _Title { get; set; }
    public string _Author { get; set; }
    public int _Length { get; set; } // Length in seconds
    private List<Comment> _Comments { get; set; }

    public Video(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;
        _Comments = new List<Comment>();
    }

    public void AddComment(Comment _comment)
    {
        _Comments.Add(_comment);
    }

    public int GetNumberOfComments()
    {
        return _Comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _Comments;
    }

    public override string ToString()
    {
        return $"Title: {_Title}, Author: {_Author}, Length: {_Length} seconds, Number of Comments: {GetNumberOfComments()}";
    }
}




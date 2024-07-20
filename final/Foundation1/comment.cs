public class Comment
{
    public string _Author { get; set; }
    public string _Text { get; set; }

    public Comment(string author, string text)
    {
        _Author = author;
        _Text = text;
    }

    public override string ToString()
    {
        return $"{_Author}: {_Text}";
    }
}




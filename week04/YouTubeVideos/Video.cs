public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments= new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title=title;
        _author=author;
        _length=length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CommentNumber()
    {
        return _comments.Count;
    }
    public string GetDisplayText()
    {
        return $"Title: {_title}, Author: {_author}, Video Length: {_length}, Number of comments: {CommentNumber()}";
        
    }
    public void GetComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayText());

        }
    }

}
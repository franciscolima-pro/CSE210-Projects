class Video
{
    string _title;
    string _author;
    int _videoSeconds;
    List<Comment> _comments;
    public Video(string title, string author, int videoSeconds)
    {
        _title = title;
        _author = author;
        _videoSeconds = videoSeconds;
        _comments  = new List<Comment>();
    }
    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int getnumberComments()
    {
        return _comments.Count;
    }
    public List<Comment> getComments()
    {
        return _comments;
    }
    public string getTitle()
    {
        return _title;
    }
    public string getAuthor()
    {
        return _author;
    }
    public int getVideoSeconds()
    {
        return _videoSeconds;
    }

}
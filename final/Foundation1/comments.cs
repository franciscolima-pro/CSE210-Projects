class Comment
{
    private string _commenterName;
    private string _commentContent;
    public Comment(string commenterName, string commentContent)
    {
        _commenterName = commenterName;
        _commentContent = commentContent;
    }
    public string getCommenterName()
    {
        return _commenterName;
    }
    public string getCommenterContent()
    {
        return _commentContent;
    }
}

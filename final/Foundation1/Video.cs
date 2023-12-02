using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Length { get; private set; }
    public List<Comment> Comments { get; private set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video { _title = "C# Basics", _author = "John", _length = 300 };
        v1._comments.Add(new Comment { _name = "Amy", _text = "Great!" });
        v1._comments.Add(new Comment { _name = "Bob", _text = "Helpful!" });
        v1._comments.Add(new Comment { _name = "Sam", _text = "Nice!" });

        Video v2 = new Video { _title = "OOP Concepts", _author = "Sarah", _length = 450 };
        v2._comments.Add(new Comment { _name = "Tom", _text = "Awesome!" });
        v2._comments.Add(new Comment { _name = "Lisa", _text = "Clear explanation!" });
        v2._comments.Add(new Comment { _name = "Max", _text = "Thanks!" });

        Video v3 = new Video { _title = "Inheritance", _author = "Mike", _length = 350 };
        v3._comments.Add(new Comment { _name = "Anna", _text = "Very helpful!" });
        v3._comments.Add(new Comment { _name = "Jake", _text = "Cool!" });
        v3._comments.Add(new Comment { _name = "Ella", _text = "Great video!" });

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.Display();
            Console.WriteLine();
        }
    }
}
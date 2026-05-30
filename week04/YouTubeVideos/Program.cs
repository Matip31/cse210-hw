using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1=new Video("My new Minecraft Hardcore World!","Matip31",1800);
        Video video2=new Video("Fortnite is Back!","Matip31",1900);
        Video video3=new Video("Anatomy for students","Roberto Profe",6767);
        List<Video> videos=new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        Comment video1Comment1=new Comment("Luli0401","You are amazing! I love minecraft!");
        Comment video1Comment2=new Comment("ElRichMC","Try doing it better next time!");
        Comment video1Comment3=new Comment("Dream","This is gold bro");
        video1.AddComment(video1Comment1);
        video1.AddComment(video1Comment2);
        video1.AddComment(video1Comment3);
        Comment video2Comment1=new Comment("Luli0401","You are amazing! I love Fortnite!");
        Comment video2Comment2=new Comment("Booga","Try doing it better next time!");
        Comment video2Comment3=new Comment("King","Let's go this is awesome");
        video2.AddComment(video2Comment1);
        video2.AddComment(video2Comment2);
        video2.AddComment(video2Comment3);
        Comment video3Comment1=new Comment("Luli0401","You are amazing! With this I will pass my test!");
        Comment video3Comment2=new Comment("MatiProfe","Try doing it better next time!");
        Comment video3Comment3=new Comment("Facultad de Medicina","Vamo arriba");
        video3.AddComment(video3Comment1);
        video3.AddComment(video3Comment2);
        video3.AddComment(video3Comment3);
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            video.GetComments();

        }

    }
}
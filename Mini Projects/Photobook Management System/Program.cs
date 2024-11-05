using System;

class PhotoBook
{
    private int numPages;

    public PhotoBook()
    {
        numPages = 16;
    }

    public PhotoBook(int numPages)
    {
        if(numPages < 16 || numPages > 64)
        {
            throw new ArgumentException("Error");
        }
        this.numPages = numPages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }
}

class BigPhotoBook : PhotoBook
{
    public BigPhotoBook():base(64)
    {}
}

class Program
{
    static void Main()
    {
        PhotoBook pb = new PhotoBook();
        Console.WriteLine("Default Photo Book Pages : "+pb.GetNumberPages());

        try{
            PhotoBook cpb = new PhotoBook(int.Parse(Console.ReadLine()));
            Console.WriteLine("Custom Photo Book Pages : "+cpb.GetNumberPages());
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        BigPhotoBook bpb = new BigPhotoBook();
        Console.WriteLine("Large Photo Book : "+bpb.GetNumberPages());
    }
}

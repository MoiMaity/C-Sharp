// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string sec = Console.ReadLine();
        int wordcount = await CountWords(sec);
        Console.WriteLine($"The number of words in the sentence is : {wordcount}");
    }

    static async Task<int> CountWords(string s)
    {
        await Task.Delay(1);
        int wc = s.Split(new[]{ ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        return wc;
    }
}

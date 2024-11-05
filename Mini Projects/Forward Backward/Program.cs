// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class BrowserHistory
{
    private Stack<string> backStack;
    private Stack<string> forwardStack;
    private string currentPage;

    public BrowserHistory()
    {
        backStack = new Stack<string>();
        forwardStack = new Stack<string>();
        currentPage = null;
    }

    public void GoBack()
    {
        if(backStack.Count > 0)
        {
            forwardStack.Push(currentPage);
            currentPage = backStack.Pop();
            Console.WriteLine($"Went back to : {currentPage}");
        }
        else
        {
            Console.WriteLine("No pages in back history");
        }
    }

    public void GoForward()
    {
        if(forwardStack.Count > 0)
        {
            backStack.Push(currentPage);
            currentPage = forwardStack.Pop();
            Console.WriteLine($"Went forward to : {currentPage}");
        }
        else
        {
            Console.WriteLine("No pages in forward history");
        }
    }

    public void VisitPage(string url)
    {
        if(currentPage != null)
        {
            backStack.Push(currentPage);
        }
        currentPage = url;
        forwardStack.Clear();
    }

    public void DisplayHistory()
    {
        Console.WriteLine("Back History");
        foreach(string url in backStack)
        {
            Console.WriteLine(url);
        }
        Console.WriteLine("Forward history :");
        foreach(string url in forwardStack)
        {
            Console.WriteLine(url);
        }
        Console.WriteLine($"current page : {currentPage ?? "None"}");
    }
}

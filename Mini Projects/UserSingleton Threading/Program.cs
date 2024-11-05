// See https://aka.ms/new-console-template for more information
using System;

public sealed class UserSingleton
{
    private static UserSingleton instance = null;
    private static readonly object lockObj = new object();
    private int accessCounter = 0;

    private UserSingleton() 
    {}

    public static UserSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if(instance == null)
                    {
                        instance = new UserSingleton();
                    }
                }
            }
            return instance;
        }
        
    }

    public int GetAccessCounter()
    {
        return accessCounter;
    }

    public void IncrementAccessCounter()
    {
        accessCounter++;
    }

    public void DisplayGreeting(string username)
    {
        Console.WriteLine("Welcome, "+username+"!");
    }
}

class Program
{
    static void Main()
    {
        string us = Console.ReadLine();
        UserSingleton ug = UserSingleton.Instance;
        ug.IncrementAccessCounter();
        ug.IncrementAccessCounter();
        Console.WriteLine("Access Counter :"+ug.GetAccessCounter());
        ug.DisplayGreeting(us);
    }
}
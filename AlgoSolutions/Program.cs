// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using AlgoSolutions;

class Program
{
    private static Testing FirstTest = new Testing("Tests\\FirstTest.txt");

    public static void Main()
    {
        FirstTest.RunFirstTaskTests();
    }
}
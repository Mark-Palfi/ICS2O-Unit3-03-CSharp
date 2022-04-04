// Created by: Mark Palfi
// Created on: Mar 2022
//
// This program does math 

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double lenght;
        double width;
        double height;
        double volume;


        Console.WriteLine("This program calculates the volume of a square based pyramid.");
        Console.WriteLine("");
        
        // input
        Console.Write("Enter lenght: ");
        lenght = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter width: ");
        width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        height = Convert.ToDouble(Console.ReadLine());
        
        // process
        volume = lenght * width * height /3

        // output
        Console.WriteLine("The volume is = $" + volume + );

        Console.WriteLine("\nDone.");
    }
}
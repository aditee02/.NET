﻿using System;

class Program
{
    static void Main()
    {
        //create structure instance
        Category category = new Category (20,"General");


        //initialize fields through properties
        category.CategoryID = 20;
        category.CategoryName = "General";

        //access methods
        Console.WriteLine(category.CategoryID);
        Console.WriteLine(category.CategoryName);
        Console.WriteLine(category.GetCategoryNameLength());

        Console.ReadKey();
    }
}
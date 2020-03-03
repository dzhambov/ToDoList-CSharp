using System.Collections.Generic;
using ToDoList.Models;
 using System;

 namespace ToDoList
 {
   public class Program
   {
     public static void Main()
     {


       Console.WriteLine("Welcome to the To Do List.");
       Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");

       string response1 = Console.ReadLine();

      if (response1 == "Add" || response1 == "add")
      {
        Console.WriteLine("Please enter the description for the new item:");
         
         string newTask = Console.ReadLine();

         Item newItem = new Item(newTask);

        Console.WriteLine(newItem.Description + " has been added to your list. Would you like to add an item to your list or view your list?");

        string response2 = Console.ReadLine();
        
        if (response2 == "view" || response2 == "View")
        {
        int count = 0;

        foreach (Item thisItem in Item.GetAll())
          {
          count ++;

          Console.WriteLine(count + ". " + thisItem.Description);
          }
        } 
        Main();
      } 
        
        else
        {
          int count = 0;

          foreach (Item thisItem in Item.GetAll())
          {
            count ++;

            Console.WriteLine(count + ". " + thisItem.Description);
           
        }
      Main();
      }
      
     }
   }
 }

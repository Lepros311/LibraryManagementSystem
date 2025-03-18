﻿using Spectre.Console;

namespace LibraryManagementSystem.Models
{
    internal class Book : LibraryItem
    {
        internal string Author { get; set; }
        internal string Category { get; set; }
        internal int Pages { get; set; }

        
        // Could also initialize fields with default values:
        //string Name = "Unknown";
        //int Pages = 0;

        internal Book(int id, string name, string author, string category, string location, int pages) : base(id, name, location)
        {
            Author = author;
            Category = category;
            Pages = pages;
        }

        public override void DisplayDetails()
        {
            var panel = new Panel(new Markup($"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]") +
                              $"\n[bold]Pages:[/] {Pages}" +
                              $"\n[bold]Category:[/] [green]{Category}[/]" +
                              $"\n[bold]Location:[/] [blue]{Location}[/]")
            {
                Border = BoxBorder.Rounded
            };

            AnsiConsole.Write(panel);
        }

    }
}

namespace LibraryManagementSystem
{
    internal class Book
    {
        public string Name { get; set; } = "Unknown";
        public int Pages { get; set; } = 0;

        public Book(string name, int pages)
        {
            Name = name;
            Pages = pages;
        }
        
        // Could also initialize fields with default values:
        //string Name = "Unknown";
        //int Pages = 0;

        internal Book()
        {
            Name = "Uknown";
            Pages = 0;
        }

        internal Book(int pages)
        {
            Name = "Unknown";
            Pages = pages;
            Console.WriteLine($"Name: {Name}, Pages: {Pages}");
        }

        //internal Book(string name, int pages)
        //{
        //    Name = name;
        //    Pages = pages;
        //    Console.WriteLine($"Name: {Name}, Pages: {Pages}");
        //}
    }
}

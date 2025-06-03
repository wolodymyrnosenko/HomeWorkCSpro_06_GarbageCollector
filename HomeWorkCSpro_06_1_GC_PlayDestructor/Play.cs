using System;

namespace HomeWorkCSpro_06_1_GC_PlayDestructor
{
    internal class Play
    {
        public string Name {get; private set; }
        public string Author {get; private set; }
        public string Genre {get; private set; }
        public int Year {get; private set; }

        public Play(string name, string author, string genre, int year)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
        }
        ~Play()
        {
            Console.WriteLine($"Destructor for {this.Name} is processing");
        }
        public override string ToString()
        {
            return $"{Environment.NewLine}Назва п'єси: {Name}" +
                $"{Environment.NewLine}Автор: {Author}" +
                $"{Environment.NewLine}Жанр: {Genre}" +
                $"{Environment.NewLine}Рік: {Year}{Environment.NewLine}";
        }
    }
}

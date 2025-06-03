using System;

namespace HomeWorkCSpro_06_3_GC_PlayStoreUpdateDisposePattern
{
    internal class Play : IDisposable//Implement with Dispose pattern by Visual Studio
    {
        private bool _disposedValue;

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
            
            Console.WriteLine($"constructor: {this.Name}");
        }

        public override string ToString()
        {
            return $"{Environment.NewLine}Назва п'єси: {Name}" +
                $"{Environment.NewLine}Автор: {Author}" +
                $"{Environment.NewLine}Жанр: {Genre}" +
                $"{Environment.NewLine}Рік: {Year}";
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    Console.WriteLine($"Dispose(true) method for {this.Name}");
                }
                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;

                //if(!disposing)//For testing
                //{
                //    Console.WriteLine($"Dispose(false) method for {this.Name}");
                //    Console.ReadKey();
                //}
            }
        }
        // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~Play()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            
            Console.WriteLine($"Destructor for {this.Name} is processing");//Add to test method

            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
using System;

namespace HomeWorkCSpro_06_3_GC_PlayStoreUpdateDisposePattern
{
    internal class Store : IDisposable//Implement with Dispose pattern by Visual Studio
    {
        private bool _disposedValue;

        public string Name { get; private set; }
        public string Address { get; private set; }
        public StoreType StoreType { get; private set; }
        public Store(string name, string address, StoreType storeType)
        {
            Name = name;
            Address = address;
            StoreType = storeType;
        }
        public override string ToString()
        {
            return $"{Environment.NewLine}Назва магазину: {Name}" +
                $"{Environment.NewLine}Адреса: {Address}" +
                $"{Environment.NewLine}Тип: {StoreType}{Environment.NewLine}";
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

                if (!disposing)//For testing
                    Console.WriteLine($"Dispose(false) method for {this.Name}");
            }
        }

        // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~Store()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
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

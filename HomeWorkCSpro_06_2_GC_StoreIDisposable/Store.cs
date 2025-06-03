using System;

namespace HomeWorkCSpro_06_2_GC_StoreIDisposable
{
    internal class Store : IDisposable//Implement interface without Dispose pattern
    {
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

        public void Dispose()
        {
            Console.WriteLine($"Dispose method for {this.Name}");
        }
    }
}

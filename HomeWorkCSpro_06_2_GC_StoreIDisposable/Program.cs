using System.Text;

namespace HomeWorkCSpro_06_2_GC_StoreIDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            using (Store testStore1 = new Store("nameStore1", "addressStore1", StoreType.продовольчий))
            {
                Console.WriteLine(testStore1);
            };
            using Store testStore2 = new Store("nameStore2", "addressStore2", StoreType.господарський);
            Console.WriteLine(testStore2);
            Store testStore3 = new Store("nameStore3", "addressStore3", StoreType.взуття);
            try
            {
                Console.WriteLine(testStore3);
            }
            finally
            {
                testStore3.Dispose();
            }
        }
    }
}

using System.Text;

namespace HomeWorkCSpro_06_3_GC_PlayStoreUpdateDisposePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            using Play testPlay1 = new Play("namePlay1", "authorPlay1", "genrePlay1", 2000);
            Play testPlay2 = new Play("namePlay2", "authorPlay2", "genrePlay2", 2010);
            Console.WriteLine(testPlay1);
            Console.WriteLine(testPlay2);
            testPlay2 = null;//To demonstrate Destructor. Output: nothing

            using (Store testStore = new Store("nameStore", "addressStore", StoreType.одяг))
                Console.WriteLine(testStore);

            GC.Collect();
            GC.WaitForPendingFinalizers();
            //List<Play> plays = new List<Play>();
            //for (int i = 0; ; i++)
            //{
            //    plays.Add(new Play($"{i.ToString()}", $"{ i.ToString() }", $"{ i.ToString() }", 0));
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; ; i++)
            //{
            //    Play playTest = new Play($"{i.ToString()}", $"{i.ToString()}", $"{i.ToString()}", 0);
            //    Console.WriteLine(i);
            //}
        }
    }
}

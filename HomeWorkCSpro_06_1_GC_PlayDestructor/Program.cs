using System.Text;

namespace HomeWorkCSpro_06_1_GC_PlayDestructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Play testPlay1 = new Play("namePlay1", "authorPlay1", "genrePlay1", 2000);
            Play testPlay2 = new Play("namePlay2", "authorPlay2", "genrePlay2", 2010);
            Console.WriteLine(testPlay1);
            Console.WriteLine(testPlay2);
            testPlay1 = null;//To demonstrate Destructor. Output: nothing
            //testPlay2 = null;//To demonstrate Destructor
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.ReadLine();
        }
    }
}

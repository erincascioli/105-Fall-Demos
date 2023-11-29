namespace TextFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read from the file myFile.txt:");
            FileReader myFileReader = new FileReader("../../../MyFile.txt");

            Console.WriteLine("\nWrite to the file myWrittenFile.txt:");
            FileWriter myFileWriter = new FileWriter("../../../MyWrittenFile.txt");

            Console.WriteLine("\nRead from the file myWrittenFile.txt:");
            FileReader myFileReader2 = new FileReader("../../../MyWrittenFile.txt");
        }
    }
}
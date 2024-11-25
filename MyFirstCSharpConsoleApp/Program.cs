namespace MyFirstCSharpConsoleApp
{
    class Program
    {
        string textWritten = "";


        static void Main(string[] args)
        {
            Console.WriteLine("Ala ma kota");

            HttpClient client = new HttpClient();

            //int number = "sdf";


            Write("Ala ma kota");

        }

        static void Write(string textToWrite)
        {
            textToWrite += textToWrite;
            //Console.WriteLine(textToWrite);
            //textToWrite;
            ///
        }
    }
}

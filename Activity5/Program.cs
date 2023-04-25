namespace Activity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lines;

            StreamReader sR = new StreamReader("C:\\Users\\Administrator\\source\\repos\\hehe.txt");

            lines = sR.ReadLine();

            while (lines != null)
            {
                Console.WriteLine(lines);
                lines = sR.ReadLine();
            }

            sR.Close();

            StreamWriter sW = new StreamWriter("C:\\Users\\Administrator\\source\\repos\\hehe.txt");

            sW.WriteLine("Activity ni Inan");
            sW.WriteLine("hehe");

            sW.Close();

        }
    }
}
namespace practice6;

public class Program
{
    static void Main(string[] args)
    {
        double x = 0.1;
        double h = 0.05;
        int n = 30;
        double slag = 0;

        while (x <= 1 + h)
        {
            double y = (x * x / 4 + x / 2 + 1) * Math.Exp(x / 2);
            double s = 1;
            for (int i = 1, a = 2, b = 1; i <= n; i++, b += 2, a += b)
            {
                int k = 1;
                for (int j = 2; j <= i; j++)
                {
                    k *= j;
                    Console.WriteLine($"i={i}\t| s={Math.Round(s, 7)}\t| k={k}\t| slag={Math.Round(slag, 7)}\n");
                }
                slag = Math.Pow(x / 2, i) * a / k;
                s += slag;
            }
            Console.WriteLine($"{Math.Round(x, 3)}\t| {Math.Round(y, 7)}\t| {Math.Round(s, 7)}\n");
            x += h;
        }



        // 3
        //double x = 0.1;
        //double h = 0.05;
        //int n = 25;
        //double slag = 0;

        //while (x <= 1 + h)
        //{
        //    double y = Math.Exp(x * Math.Cos(Math.PI / 4)) * Math.Cos(x * Math.Sin(Math.PI / 4));
        //    double s = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        int k = 1;
        //        for (int j = 2; j <= i; j++)
        //        {
        //            k *= j;
        //            Console.WriteLine($"i={i}\t| s={Math.Round(s, 7)}\t| k={k}\t| slag={Math.Round(slag, 7)}\n");
        //        }
        //        slag = Math.Cos(i * Math.PI / 4) / k * Math.Pow(x, i);
        //        s += slag;
        //    }
        //    Console.WriteLine($"{Math.Round(x, 3)}\t| {Math.Round(y, 7)}\t| {Math.Round(s, 7)}\n");
        //    x += h;
        //}



        // 4
        //double x = 0.1;
        //double h = 0.05;
        //int n = 10;

        //while (x <= 1 + h)
        //{
        //    double y = Math.Cos(x);
        //    double s = 1;
        //    int sign = -1;
        //    for (int i = 2; i <= n; i += 2) 
        //    {
        //        int k = 1;
        //        for (int j = 2; j <= i; j++)
        //            k *= j;
        //        double slag = Math.Pow(x, i) / k;
        //        s += slag * sign;
        //        sign *= -1;
        //    }
        //    Console.WriteLine($"{Math.Round(x, 3)}\t| {Math.Round(y, 7)}\t| {Math.Round(s, 7)}\n");
        //    x += h;
        //}
    }

    private static void Log(string message)
    {
        string filePath = $"log {DateTime.Now.ToString("yyyy-MM-dd_HH-mm")}.txt";

        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss:fff") + ": " + message);
        }
    }
}
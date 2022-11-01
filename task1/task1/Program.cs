internal class task
{
    static void Main(string[] args)
    {
        int[] ededler = { -6, 3, 9, 15, 18, 30 };
        int cem = 0;

        for (int i = 0; i < ededler.Length; i++)
        {
            if (ededler[i] > 0 && ededler[i] % 6 == 0)
            {
                Console.WriteLine(ededler[i]);
                cem += ededler[i];
            }
        }
        Console.WriteLine("cem :" + cem);

    }
}


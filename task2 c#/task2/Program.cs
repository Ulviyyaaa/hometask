class task2
{
    static void Main()
    {
        List<long> list = new List<long> { 150, 300, 400, 350, 450, 550, 600 };
        foreach (long ele in list)
        {
            Console.WriteLine(ele);
        }

        long max_num = list.AsQueryable().Max();


        Console.WriteLine("Largest number = {0}", max_num);
    }
}
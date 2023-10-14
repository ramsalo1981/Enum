namespace CAEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Month.FEB);
            Console.WriteLine((int)Month.FEB);
            Console.WriteLine("------------------");

            var day = Day.Saturday | Day.Sunday;
            if (day.HasFlag(Day.Weekend))
            {
                Console.WriteLine("Enjoy your weekend");
                Console.WriteLine(day);
                Console.WriteLine((int)day);

            }
            Console.WriteLine("------------------");

            Console.Write("Enter the day: ");
            string dayMonth = Console.ReadLine().ToUpper();

            if (Enum.TryParse(dayMonth, out Month month))
            {
                Console.WriteLine(month);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }

            //Console.WriteLine(Enum.Parse(typeof(Month), dayMonth));

            Console.WriteLine("------------------");


            foreach (var month1 in Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine($"{month1} = {(int)Enum.Parse(typeof(Month),month1)}");
            }
            Console.WriteLine("------------------");


            foreach (var month1 in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"{month1} = {(int)month1}");
            }

        }
    }
    enum Month
    {
        // by default the first value start from 0 ´<=> JAN = 0 FEB = 1 MAR = 2....
        // u can chang value JAN = 1 FEB = 2 MAR = 3....
        JAN = 1,
        FEB,
        MAR,
        APR,
        MAY,
        JUN,
        JUL,
        AUG,
        SEP,
        OCT,
        NOV,
        DEC
    }
    // choose day you work ; none day or 2 days or three day or ...
    // value of day must be binary 0b_0000_0000 = 0

    [Flags]
    enum Day
    {
        None = 0,
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7,
        Weekend = Saturday | Saturday ,

    }
}
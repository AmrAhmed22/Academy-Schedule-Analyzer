namespace Academy_Schedule_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] sessionNames =
            {
                "C# Basics",
                "Arrays",
                "Functions",
                "Date and Time",
                "Exception Handling"
            };

            DateTime[] sessionDates =
            {
                new DateTime(2026, 9, 10, 18, 0, 0),
                new DateTime(2026, 9, 13, 18, 0, 0),
                new DateTime(2026, 9, 17, 18, 0, 0),
                new DateTime(2026, 9, 20, 18, 0, 0),
                new DateTime(2026, 9, 24, 18, 0, 0)
            };

            int[] sessionDurations = { 180, 240, 180, 240, 180 };



        }




        // Part 2: Display all sessions

        private static void DisplaySessions(string[] names, DateTime[] dates, int[] durations)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]}");
                DisplaySessionDetails(i, names, dates, durations);
                Console.WriteLine();
            }
        }

        private static void DisplaySessionDetails(int index, string[] names, DateTime[] dates, int[] durations)
        {
            Console.WriteLine($"Date: {dates[index]:dd MMMM yyyy}");
            Console.WriteLine($"Start Time: {dates[index]:hh:mm tt}");
            Console.WriteLine($"Duration: {durations[index]} minutes");
        }




        // Part 3: Search for a session
      

        // return the index of the found session if we need it in the future.
        private static int SearchSession(string[] names, DateTime[] dates, int[] durations, string sessionName)
        {
            int index = Array.IndexOf(names, sessionName);

            if (index == -1)
            {
                Console.WriteLine("Session not found.");
                return -1;
            }

            Console.WriteLine(names[index]);
            DisplaySessionDetails(index, names, dates, durations);
            return index;
        }




        // Part 4: Array methods practice
       

        //4.1
        private static void SortSessionNames(string[] names)
        {
            string[] sortedCopy = new string[names.Length];
            Array.Copy(names, sortedCopy, names.Length);
            Array.Sort(sortedCopy);

            Console.WriteLine("Sorted session names:");
            foreach (string name in sortedCopy)
                Console.WriteLine(name);
        }


        //4.2
        private static void ReverseSessionNames(string[] names)
        {
            string[] reversedCopy = new string[names.Length];
            Array.Copy(names, reversedCopy, names.Length);
            Array.Reverse(reversedCopy);

            Console.WriteLine("Reversed session names:");
            foreach (string name in reversedCopy)
                Console.WriteLine(name);
        }



    }
}

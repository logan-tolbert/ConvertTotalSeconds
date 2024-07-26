namespace convertTotalSeconds
{
    internal class Program
    {
        /// <summary>
        /// Convert total seconds to total minutes and seconds
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // Variable declarations/initializations
            int totalSeconds = 500;
            const int SecondsPerMinute = 60;

            // Output message with total of seconds to be converted 
            Console.WriteLine($"- Converting {totalSeconds} seconds into total minutes and seconds -");
            // Ouput formatted conversion
            Console.WriteLine(((int)totalSeconds / SecondsPerMinute) + " minutes " + ((int)totalSeconds % SecondsPerMinute) + " seconds");



        }
    }
}

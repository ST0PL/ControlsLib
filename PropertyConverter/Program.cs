namespace PropertyConverter
{
    internal class Program
    {
        // Convert from HorizontalAlignment="Right" to <Setter Property="HorizontalAlignment" Value="Right"/>
        static void Main(string[] args)
        {
            bool isRunning = true;
            var convertedProperties = new List<string>();
            while (isRunning)
            {
                Console.WriteLine("Start typing properties:\n");
                while (isRunning)
                {
                    var property = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(property))
                    {
                        var splitted = property.Split("=");
                        convertedProperties.Add($"<Setter Property=\"{splitted[0].Replace(" ","")}\" Value={splitted[1]}/>");
                    }
                    else
                        break;
                }
                Console.Clear();
                convertedProperties.ForEach(Console.WriteLine);
                convertedProperties.Clear();
                Console.WriteLine("\n\nPress ENTER to continue or any button for exit.");
                if (Console.ReadKey().Key != ConsoleKey.Enter)
                    isRunning = false;
                Console.Clear();
            }
        }
    }
}

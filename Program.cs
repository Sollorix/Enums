// See https://aka.ms/new-console-template for more information
internal class Program
{
    static void Main(string[] args)
    {
        // Sets intergers for birth information
        int myBirthMonth = (int)Months.Jun;
        int myBirthDay = 30;
        int myBirthYear = 2006;

        // Creates string and states birthday
        string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

        // Writes and prints to console
        File.WriteAllText("myFile.txt", "This is my text file!\n");
        Console.WriteLine(File.ReadAllText("myFile.txt"));

        //
        File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
        Console.WriteLine(File.ReadAllText("myFile.txt"));

        // Creates if and else statement for copy and replace
        if (!File.Exists("newFile.txt"))
        {
            File.Copy("myFile.txt", "newFile.txt");
        }
        else
        {
            File.Replace("myFile.txt", "newFile.txt", "backupFile.txt");
        }

        //Appends text and prints to the console
        File.AppendAllText("newFile.txt", myBirthDate);
        Console.WriteLine(File.ReadAllText("newFile.txt"));
    }

    // Creates enum for months
    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec,
    }
}

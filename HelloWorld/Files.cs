namespace HelloWorld
{
    public class Files
    {
        public static void WorkWithFiles()
        {
            var sourcePath = @"C:\Maculatura\Testing\C#Automation\C#Mosh\HelloWorld\HelloWorld\";
            var destinationPath = @"C:\Users\vasile.mosan\Desktop\";
            var file = "Program.cs";

            if (File.Exists(destinationPath))
            {
                File.Copy($"{sourcePath}{file}", $"{destinationPath}{file}");
                Console.WriteLine($"File {file} copied successfully");
            }
            else
            {
                File.Delete($"{destinationPath}{file}");
                File.Copy($"{sourcePath}{file}", $"{destinationPath}{file}");
                Console.WriteLine($"File {file} copied successfully");
            }


        }

        public static void NumberOfWordsInFile()
        {
            var filePath = @"C:\Users\vasile.mosan\Desktop\New Text Document.txt";
            string fileContents = File.ReadAllText(filePath);

            // Split the contents into words using whitespace as the delimiter
            string[] words = fileContents.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Display the number of words
            Console.WriteLine($"The number of words in the file is: {words.Length}");
        }

        public static void DisplayLongestWordInFile()
        {
            // Get the path of the text file
            string filePath = @"C:\Users\vasile.mosan\Desktop\New Text Document.txt";

            // Read the contents of the text file
            string fileContents = File.ReadAllText(filePath);

            // Split the contents into words using whitespace as the delimiter                       //TrimEntries RemoveEmptyEntries
            string[] words = fileContents.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.TrimEntries);

            // Initialize a variable to store the longest word
            string longestWord = "";

            // Iterate through each word in the array
            foreach (string word in words)
            {
                // Check if the current word is longer than the stored longest word
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            // Display the longest word
            Console.WriteLine($"The longest word in the file is: {longestWord}");
        }
    }
}

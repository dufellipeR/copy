string sourceFile = "";
string destinationFile = "";

while (!File.Exists(sourceFile))
{
    Console.WriteLine("What's the source file name? ");
    sourceFile = Console.ReadLine();
}

while (destinationFile == "")
{
    Console.WriteLine("What's the destination file name? ");
    destinationFile = Console.ReadLine();
}

File.Copy(sourceFile, destinationFile);
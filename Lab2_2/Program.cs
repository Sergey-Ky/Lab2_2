string inputFilePath = "C:\\Users\\ser20\\RiderProjects\\Lab2_2\\Lab2_2\\text.txt";
SplitParagraphsToFiles(inputFilePath);



static void SplitParagraphsToFiles(string inputPath)
{
    string[] paragraphs = File.ReadAllText(inputPath)
        .Split(new[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i < paragraphs.Length; i++)
    {
        string outputPath = "C:\\Users\\ser20\\RiderProjects\\Lab2_2\\Lab2_2\\" + $"paragraph_{i + 1}.txt";
        File.WriteAllText(outputPath, paragraphs[i].Trim());
    }
}
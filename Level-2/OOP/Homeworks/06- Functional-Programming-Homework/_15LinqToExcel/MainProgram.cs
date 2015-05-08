using System;
using System.Collections.Generic;
using System.Linq;

public class MainProgram
{
    public static void Main()
    {
        /* You can find the result excel file in the files folder after executing the programn */

        try
        {
            string inputFileName = @"..\..\files\Students-data.txt";

            TextFileReader fileReader = new TextFileReader(inputFileName, hasHeader: true);

            List<string> headerTitles = 
                fileReader
                .GetHeaderTitlesFromFile(
                    splitPattern: @"\t", 
                    titlesToAdd: new string[] { "Result" });

            List<Student> studentsList = fileReader.GetStudentDataFromFile(splitPattern: @"\t");

            string outputFileName = @"..\..\files\online-students.xlsx";

            var onlineStudentsByResult = 
                studentsList
                .Where(s => s.StudentType == StudentType.Online)
                .OrderByDescending(s => s.Result)
                .ToList();

            ExcelCreator<Student> excelCreator = new ExcelCreator<Student>(
                headerTitles, 
                onlineStudentsByResult, 
                outputFileName, 
                "OOP Results",
                new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase) 
                { 
                    { "Email", 9000 }
                });
            excelCreator.CreateExcelFromDataCollection();
        }
        catch (Exception e)
        {
            // No time to handle exceptions separately
            Console.WriteLine(e.Message);
            Console.WriteLine("Stack trace:\n" + e.StackTrace);
        }
    }
}
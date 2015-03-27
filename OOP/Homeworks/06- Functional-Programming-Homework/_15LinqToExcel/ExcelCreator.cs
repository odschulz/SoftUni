using System;
using System.Collections.Generic;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

public class ExcelCreator<T>
{
    private IList<string> headerTitles;
    private IList<T> dataCollection;
    private string outputFileName;
    private string sheetName;

    // This dictionary is an optional value with custom width sizes for cell columns with predifened names
    private Dictionary<string, int> customColumnSizes;

    public ExcelCreator(
        IList<string> headerTitles,
        IList<T> dataCollection,
        string outputFileName,
        string sheetName,
        Dictionary<string, int> customColumnSizes = null)
    {
        this.HeaderTitles = headerTitles;
        this.DataCollection = dataCollection;
        this.OutputFileName = outputFileName;
        this.SheetName = sheetName;
        this.CustomColumnSizes = customColumnSizes;
    }

    public IList<string> HeaderTitles
    {
        get
        {
            return this.headerTitles;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                    "The excel creator class must be innitiated with a collection of header titels that is not null.");
            }

            this.headerTitles = value;
        }
    }

    public IList<T> DataCollection
    {
        get
        {
            return this.dataCollection;
        }

        set
        {
            this.dataCollection = value;
        }
    }

    public string OutputFileName
    {
        get
        {
            return this.outputFileName;
        }

        set
        {
            ValidationMethods.CheckIfStringIsNullOrEmpty("Output File Name", value);
            this.outputFileName = value;
        }
    }

    public string SheetName
    {
        get
        {
            return this.sheetName;
        }

        set
        {
            ValidationMethods.CheckIfStringIsNullOrEmpty("Sheet Name", value);
            this.sheetName = value;
        }
    }

    public Dictionary<string, int> CustomColumnSizes
    {
        get
        {
            return this.customColumnSizes;
        }

        set
        {
            if (value != null)
            {
                foreach (var pair in value)
                {
                    ValidationMethods.CheckIfStringIsNullOrEmpty(
                        "Keys in the Dictionary collection \"Custom Colum Sizes\"", pair.Key);
                    ValidationMethods.CheckIfNumberIsZeroOrNegative(
                        "Key values in the Dictionary collection \"Custom Colum Sizes\"", pair.Value);
                }
            }

            this.customColumnSizes = value;
        }
    }

    public void CreateExcelFromDataCollection()
    {
        using (FileStream stream = new FileStream(this.outputFileName, FileMode.Create, FileAccess.Write))
        {
            string fileExtension = Path.GetExtension(this.outputFileName);
            IWorkbook wb;
            if (fileExtension == ".xlsx")
            {
                wb = new XSSFWorkbook();
            }
            else
            {
                throw new NotImplementedException(
                    "File format not supported. This program can only create files with extensions .xlsx");
            }

            ISheet sheet = wb.CreateSheet(this.SheetName);
            ICreationHelper cH = wb.GetCreationHelper();
            IRow headerRow = sheet.CreateRow(0);

            // this creates the header row with titles from the HeaderTitles Collection
            for (int columnIndex = 0; columnIndex < this.headerTitles.Count; columnIndex++)
            {
                ICell cell = headerRow.CreateCell(columnIndex);
                cell.SetCellValue(cH.CreateRichTextString(this.headerTitles[columnIndex].ToString()));

                // Check if the current title has a defined custom size 
                if (this.CustomColumnSizes.ContainsKey(this.headerTitles[columnIndex]))
                {
                    sheet.SetColumnWidth(columnIndex, this.CustomColumnSizes[this.headerTitles[columnIndex]]);
                }
                else
                {
                    sheet.AutoSizeColumn(columnIndex);
                }
            }

            // This creates all cells from DataCollection
            for (int rowIndex = 1; rowIndex <= this.DataCollection.Count; rowIndex++)
            {
                IRow row = sheet.CreateRow(rowIndex);
                var dataItemProperties =
                    this.DataCollection[rowIndex - 1] // we start from row 1, but we need 0 index from collection 
                    .ToString()
                    .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                for (int columnIndex = 0; columnIndex < dataItemProperties.Length; columnIndex++)
                {
                    ICell cell = row.CreateCell(columnIndex);
                    cell.SetCellValue(cH.CreateRichTextString(dataItemProperties[columnIndex].ToString()));
                }
            }

            wb.Write(stream);
        }
    }
}
using ClosedXML.Excel;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace FVTC.Utility.Reporting
{
    public static class Excel
    {

        public static void ExportToExcel(string[,] data, string filePath)
        {
            try
            {
                IXLWorkbook wb = new XLWorkbook();
                IXLWorksheet ws = wb.Worksheets.Add("Data");

                PdfWriter writer = new PdfWriter(filePath.Substring(0, filePath.Length - 4) + "pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Add a Header
                Paragraph header = new Paragraph(filePath.Substring(0, filePath.Length - 5))
                    .SetFontSize(18)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                document.Add(header);

                // Add a SubHeader
                Paragraph subheader = new Paragraph(filePath.Substring(0, filePath.Length - 5))
                    .SetFontSize(15)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                document.Add(subheader);

                Table table = new Table(data.GetLength(1));

                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        // Excel
                        ws.Cell(i + 1, j + 1).Value = data[i, j];

                        // PDF
                        table.AddCell(new Cell().Add(new Paragraph(data[i, j])));
                    }
                }

                document.Add(table);
                document.Close();
                wb.SaveAs(filePath);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void ExportToExcel<T>(IEnumerable<T> data, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Data");
                var properties = typeof(T).GetProperties();
                // Add headers
                for (int i = 0; i < properties.Length; i++)
                {
                    worksheet.Cell(1, i + 1).Value = properties[i].Name;
                }
                // Add data
                int row = 2;
                foreach (var item in data)
                {
                    for (int col = 0; col < properties.Length; col++)
                    {
                        worksheet.Cell(row, col + 1).Value = properties[col].GetValue(item)?.ToString() ?? string.Empty;
                    }
                    row++;
                }
                workbook.SaveAs(filePath);
            }
        }
    }
}

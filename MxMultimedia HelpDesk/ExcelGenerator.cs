using System;
using System.Collections.Generic;
using System.Text;
using CarlosAg.ExcelXmlWriter;
using System.Windows.Forms;
using System.Drawing;

namespace DataGridViewToExcel
{
    public static class ExcelGenerator
    {
        public static Workbook Generate(DataGridView dataGridView)
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add("Sheet 1");

            WorksheetRow worksheetRow = new WorksheetRow();
            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                worksheet.Table.Columns.Add(new WorksheetColumn(dataGridViewColumn.Width));
                worksheetRow.Cells.Add(new WorksheetCell(dataGridViewColumn.HeaderText));
            }
            worksheet.Table.Rows.Insert(0, worksheetRow);

            WorksheetStyle worksheetDefaultStyle = GetWorksheetStyle(dataGridView.DefaultCellStyle, "Default");
            workbook.Styles.Add(worksheetDefaultStyle);

            for (int rowIndex = 0; rowIndex < dataGridView.RowCount; ++rowIndex)
            {
                worksheetRow = worksheet.Table.Rows.Add();

                for (int columnIndex = 0; columnIndex < dataGridView.ColumnCount; ++columnIndex)
                {
                    DataGridViewCell cell = dataGridView[columnIndex, rowIndex];
                    WorksheetStyle cellStyle = GetWorksheetStyle(cell.InheritedStyle, "column" + columnIndex + "row" + rowIndex);

                    if (cellStyle != null)
                    {
                        workbook.Styles.Add(cellStyle);
                    }
                    else
                    {
                        cellStyle = worksheetDefaultStyle;
                    }

                    DataType dataType = GetDataType(cell.ValueType);
                    worksheetRow.Cells.Add(cell.FormattedValue.ToString(), dataType, cellStyle.ID);
                }
            }

            return workbook;
        }

        private static WorksheetStyle GetWorksheetStyle(DataGridViewCellStyle dataGridViewCellStyle, string id)
        {
            WorksheetStyle worksheetStyle = null;

            if (dataGridViewCellStyle != null)
            {
                worksheetStyle = new WorksheetStyle(id);
                if (!dataGridViewCellStyle.BackColor.IsEmpty)
                {
                    worksheetStyle.Interior.Color = GetColorName(dataGridViewCellStyle.BackColor);
                    worksheetStyle.Interior.Pattern = StyleInteriorPattern.Solid;
                }

                if (!dataGridViewCellStyle.ForeColor.IsEmpty)
                {
                    worksheetStyle.Font.Color = GetColorName(dataGridViewCellStyle.ForeColor);
                }

                if (dataGridViewCellStyle.Font != null)
                {
                    worksheetStyle.Font.Bold = dataGridViewCellStyle.Font.Bold;
                    worksheetStyle.Font.FontName = dataGridViewCellStyle.Font.Name;
                    worksheetStyle.Font.Italic = dataGridViewCellStyle.Font.Italic;
                    worksheetStyle.Font.Size = (int)dataGridViewCellStyle.Font.Size;
                    worksheetStyle.Font.Strikethrough = dataGridViewCellStyle.Font.Strikeout;
                    worksheetStyle.Font.Underline = dataGridViewCellStyle.Font.Underline ? UnderlineStyle.Single : UnderlineStyle.None;
                }

                worksheetStyle.Borders.Add(StylePosition.Top, LineStyleOption.Continuous, 1, "Black");
                worksheetStyle.Borders.Add(StylePosition.Right, LineStyleOption.Continuous, 1, "Black");
                worksheetStyle.Borders.Add(StylePosition.Bottom, LineStyleOption.Continuous, 1, "Black");
                worksheetStyle.Borders.Add(StylePosition.Left, LineStyleOption.Continuous, 1, "Black");
            }

            return worksheetStyle;
        }

        private static string GetColorName(Color color)
        {
            return "#" + color.ToArgb().ToString("X").Substring(2);
        }

        private static DataType GetDataType(Type valueType)
        {
            if (valueType == typeof(DateTime))
            {
                return DataType.String;
            }
            else if (valueType == typeof(string))
            {
                return DataType.String;
            }
            else if (valueType == typeof(sbyte)
              || valueType == typeof(byte)
              || valueType == typeof(short)
              || valueType == typeof(ushort)
              || valueType == typeof(int)
              || valueType == typeof(uint)
              || valueType == typeof(long)
              || valueType == typeof(ulong)
              || valueType == typeof(float)
              || valueType == typeof(double)
              || valueType == typeof(decimal))
            {
                return DataType.Number;
            }
            else
            {
                return DataType.String;
            }
        }
    }
}

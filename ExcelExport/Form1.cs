using DetailsViewExcelExporting;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.Input.Enums;
using System.Globalization;
using Syncfusion.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.WinForms.DataGridConverter.Events;
using Syncfusion.WinForms.DataGrid.Renderers;


namespace ExcelExport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SampleCustomization();
        }

        private void SampleCustomization()
        {
            // Initialize the DataGrid
            this.Controls.Add(sfDataGrid1);

            // Create sample data
            var data = new List<DataItem>
    {
        new DataItem { SerialNumber = 1, Name = "John" },
        new DataItem { SerialNumber = 2, Name = "Jane" },
        new DataItem { SerialNumber = 3, Name = "Doe" },
        new DataItem { SerialNumber = 4, Name = "Smith" }
    };

            // Bind data to the grid
            sfDataGrid1.DataSource = data;

            // Create and configure the serial number column
            GridTextColumn serialNumberColumn = new GridTextColumn
            {
                MappingName = "SerialNumber",
                HeaderText = "Serial Number"
            };
            sfDataGrid1.Columns.Add(serialNumberColumn);
            this.sfDataGrid1.AllowEditing = true;
            this.sfDataGrid1.AllowGrouping = true;
            this.sfDataGrid1.ShowGroupDropArea = true;
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.SelectionMode = GridSelectionMode.Multiple;
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalDigits = 0;
            nfi.NumberGroupSizes = new int[] { };

            // Create and configure the name column with ComboBox
            GridComboBoxColumn nameColumn = new GridComboBoxColumn
            {
                MappingName = "Name",
                HeaderText = "Name",
                DataSource = new List<string> { "John", "Jane", "Doe", "Smith", "Emily", "Anna" }
                
            };

            // Set the cell style to ensure dropdown button is always visible
            //nameColumn.DropDownStyle = GridDropDownStyle.Exclusive;
           // nameColumn.DropDownListView.EnableAutoSize = true;
           nameColumn.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            nameColumn.HeaderText = "Name";

            sfDataGrid1.Columns.Add(nameColumn);

            // Adjust the width of the columns to fit the content
            sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
        }



        private void ExportAllRecordsToExcel(object sender, EventArgs e)
        {
            ExcelExportingOptions exportingOptions = new ExcelExportingOptions
            {
                ExcelVersion = ExcelVersion.Excel2016
            };
            exportingOptions.Exporting += OnExporting;
            if (shouldCustomizeStyle.Checked)
                exportingOptions.CellExporting += OnCustomizedCellExporting;
            else
                exportingOptions.CellExporting += OnCellExporting;

            var excelEngine = sfDataGrid1.ExportToExcel(sfDataGrid1.View, exportingOptions);
            var workBook = excelEngine.Excel.Workbooks[0];
            SaveFileDialog sfd = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx",
                FileName = "Book1"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    if (sfd.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else
                        workBook.Version = ExcelVersion.Excel2010;
                    workBook.SaveAs(stream);
                }

                if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Open(sfd.FileName);
                }
            }
        }
        private void Open(string fileName)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = fileName,
                    UseShellExecute = true 
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the file: " + ex.Message);
            }
        }


        private void OnCustomizedCellExporting(object sender, DataGridCellExcelExportingEventArgs e)
        {
            if (e.ColumnName == "Discount")
            {
                e.Range.CellStyle.ColorIndex = ExcelKnownColors.Violet;
            }
        }

        private void OnCellExporting(object sender, DataGridCellExcelExportingEventArgs e)
        {
            e.Range.CellStyle.Font.Size = 12;
            e.Range.CellStyle.Font.FontName = "Segoe UI";
        }

        private void OnExporting(object sender, DataGridExcelExportingEventArgs e)
        {
            if (e.CellType == ExportCellType.HeaderCell)
            {
                if (e.Level == 0)
                    e.CellStyle.BackGroundColor = Color.FromArgb(255, 155, 194, 230);
                else
                    e.CellStyle.BackGroundColor = Color.FromArgb(255, 146, 208, 80);

                e.CellStyle.ForeGroundColor = Color.White;
                e.CellStyle.FontInfo.Bold = true;
                e.Handled = true;
            }
        }

        private void ExportSelectedRecordsToExcel(object sender, EventArgs e)
        {
            ExcelExportingOptions exportingOptions = new ExcelExportingOptions();

            exportingOptions.CellExporting += OnSelectedItemsCellExporting;
            if (shouldCustomizeSelectedItems.Checked)
                exportingOptions.Exporting += CustomizeSelectedItemsExporting;
            else
                exportingOptions.Exporting += OnExporting;

            var excelEngine = sfDataGrid1.ExportToExcel(sfDataGrid1.SelectedItems, exportingOptions);
            var workBook = excelEngine.Excel.Workbooks[0];
            SaveFileDialog sfd = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx",
                FileName = "Book1"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    if (sfd.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else
                        workBook.Version = ExcelVersion.Excel2010;
                    workBook.SaveAs(stream);
                }

                if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Open(sfd.FileName);
                }
            }
        }

        private void CustomizeSelectedItemsExporting(object sender, DataGridExcelExportingEventArgs e)
        {
            if (e.CellType == ExportCellType.RecordCell)
            {
                e.CellStyle.BackGroundColor = Color.Violet;
                e.Handled = true;
            }
        }

        private void OnSelectedItemsCellExporting(object sender, DataGridCellExcelExportingEventArgs e)
        {
            e.Range.CellStyle.Font.Size = 12;
            e.Range.CellStyle.Font.FontName = "Segoe UI";
      }

        private void exportAllRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (exportAllRecords.Checked)
            {
                shouldCustomizeStyle.Enabled = true;
                label3.Enabled = true;
                shouldCustomizeSelectedItems.Enabled = false;
                label4.Enabled = false;
            }
        }

        private void exportSelectedRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (exportSelectedRecords.Checked)
            {
                shouldCustomizeStyle.Enabled = false;
                label3.Enabled = false;
                shouldCustomizeSelectedItems.Enabled = true;
                label4.Enabled = true;
            }
        }

        private void exportToExcel_Click(object sender, EventArgs e)
        {
            if (exportAllRecords.Checked)
                ExportAllRecordsToExcel(sender, e);
            else
                ExportSelectedRecordsToExcel(sender, e);
        }
    }
    public class DataItem
    {
        public int SerialNumber { get; set; }
        public string Name { get; set; }
    }
}

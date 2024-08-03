
namespace ExcelExport
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Options = new GroupBox();
            exportToExcel = new Button();
            label4 = new Label();
            shouldCustomizeSelectedItems = new CheckBox();
            label3 = new Label();
            shouldCustomizeStyle = new CheckBox();
            exportSelectedRecords = new RadioButton();
            exportAllRecords = new RadioButton();
            sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            backStageView1 = new Syncfusion.Windows.Forms.BackStageView(components);
            Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sfDataGrid1).BeginInit();
            SuspendLayout();
            // 
            // Options
            // 
            Options.Controls.Add(exportToExcel);
            Options.Controls.Add(label4);
            Options.Controls.Add(shouldCustomizeSelectedItems);
            Options.Controls.Add(label3);
            Options.Controls.Add(shouldCustomizeStyle);
            Options.Controls.Add(exportSelectedRecords);
            Options.Controls.Add(exportAllRecords);
            Options.FlatStyle = FlatStyle.System;
            Options.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Options.Location = new Point(904, 0);
            Options.Margin = new Padding(4, 3, 4, 3);
            Options.Name = "Options";
            Options.Padding = new Padding(4, 3, 4, 3);
            Options.Size = new Size(225, 322);
            Options.TabIndex = 1;
            Options.TabStop = false;
            Options.Text = "Options";
            // 
            // exportToExcel
            // 
            exportToExcel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            exportToExcel.Location = new Point(35, 273);
            exportToExcel.Margin = new Padding(4, 3, 4, 3);
            exportToExcel.Name = "exportToExcel";
            exportToExcel.Size = new Size(161, 35);
            exportToExcel.TabIndex = 16;
            exportToExcel.Text = "Export To Excel";
            exportToExcel.UseVisualStyleBackColor = true;
            exportToExcel.Click += exportToExcel_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(54, 190);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 52);
            label4.TabIndex = 15;
            label4.Text = "Customize style for \r\nSelected records\r\n in Excel";
            // 
            // shouldCustomizeSelectedItems
            // 
            shouldCustomizeSelectedItems.Font = new Font("Microsoft Sans Serif", 8F);
            shouldCustomizeSelectedItems.Location = new Point(27, 194);
            shouldCustomizeSelectedItems.Margin = new Padding(4, 3, 4, 3);
            shouldCustomizeSelectedItems.Name = "shouldCustomizeSelectedItems";
            shouldCustomizeSelectedItems.Size = new Size(20, 46);
            shouldCustomizeSelectedItems.TabIndex = 14;
            shouldCustomizeSelectedItems.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(55, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 60);
            label3.TabIndex = 13;
            label3.Text = "Customize style for \r\nDetailsView Discount \r\nColumn in Excel";
            // 
            // shouldCustomizeStyle
            // 
            shouldCustomizeStyle.Font = new Font("Microsoft Sans Serif", 8F);
            shouldCustomizeStyle.Location = new Point(27, 123);
            shouldCustomizeStyle.Margin = new Padding(4, 3, 4, 3);
            shouldCustomizeStyle.Name = "shouldCustomizeStyle";
            shouldCustomizeStyle.Size = new Size(20, 46);
            shouldCustomizeStyle.TabIndex = 12;
            shouldCustomizeStyle.UseVisualStyleBackColor = true;
            // 
            // exportSelectedRecords
            // 
            exportSelectedRecords.AutoSize = true;
            exportSelectedRecords.Font = new Font("Microsoft Sans Serif", 9F);
            exportSelectedRecords.Location = new Point(27, 73);
            exportSelectedRecords.Margin = new Padding(4, 3, 4, 3);
            exportSelectedRecords.Name = "exportSelectedRecords";
            exportSelectedRecords.Size = new Size(160, 19);
            exportSelectedRecords.TabIndex = 11;
            exportSelectedRecords.TabStop = true;
            exportSelectedRecords.Text = "Export Selected Records";
            exportSelectedRecords.UseVisualStyleBackColor = true;
            exportSelectedRecords.CheckedChanged += exportSelectedRecords_CheckedChanged;
            // 
            // exportAllRecords
            // 
            exportAllRecords.AutoSize = true;
            exportAllRecords.Font = new Font("Microsoft Sans Serif", 9F);
            exportAllRecords.Location = new Point(27, 42);
            exportAllRecords.Margin = new Padding(4, 3, 4, 3);
            exportAllRecords.Name = "exportAllRecords";
            exportAllRecords.Size = new Size(125, 19);
            exportAllRecords.TabIndex = 9;
            exportAllRecords.TabStop = true;
            exportAllRecords.Text = "Export All Records";
            exportAllRecords.UseVisualStyleBackColor = true;
            exportAllRecords.CheckedChanged += exportAllRecords_CheckedChanged;
            // 
            // sfDataGrid1
            // 
            sfDataGrid1.AccessibleName = "Table";
            sfDataGrid1.Location = new Point(0, 0);
            sfDataGrid1.Margin = new Padding(4, 3, 4, 3);
            sfDataGrid1.Name = "sfDataGrid1";
            sfDataGrid1.RowHeight = 21;
            sfDataGrid1.Size = new Size(875, 605);
            sfDataGrid1.Style.BorderColor = Color.FromArgb(100, 100, 100);
            sfDataGrid1.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
            sfDataGrid1.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
            sfDataGrid1.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
            sfDataGrid1.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
            sfDataGrid1.TabIndex = 2;
            sfDataGrid1.Text = "sfDataGrid1";
            // 
            // backStageView1
            // 
            backStageView1.BackStage = null;
            backStageView1.HostControl = null;
            backStageView1.HostForm = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1143, 608);
            Controls.Add(sfDataGrid1);
            Controls.Add(Options);
            Location = new Point(904, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MasterDetails Excel Exporting";
            Options.ResumeLayout(false);
            Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sfDataGrid1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox Options;
        private RadioButton exportAllRecords;
        private Button exportToExcel;
        private Label label4;
        private CheckBox shouldCustomizeSelectedItems;
        private Label label3;
        private CheckBox shouldCustomizeStyle;
        private RadioButton exportSelectedRecords;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private Syncfusion.Windows.Forms.BackStageView backStageView1;
    }
}

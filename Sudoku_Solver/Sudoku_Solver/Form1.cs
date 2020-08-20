using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AddSudokuCells();
        }

        private void AddSudokuCells()
        {
            // add 9 blocks with 3 by 3 cells
            for (int blockNr = 0; blockNr < 9; blockNr++)
            {
                // create a table layout panel with 3 rows and 3 columns
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Fill;

                tableLayoutPanel.RowCount = 3;
                tableLayoutPanel.ColumnCount = 3;
                tableLayoutPanel.RowStyles.Clear();
                tableLayoutPanel.ColumnStyles.Clear();

                for (int i = 0; i < 3; i++)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
                }

                // add 9 rich text boxes to the table layout panel
                for (int i = 0; i < 9; i++)
                {
                    RichTextBox richTextBox = new RichTextBox();
                    richTextBox.Dock = DockStyle.Fill;
                    richTextBox.Font = new Font(FontFamily.GenericSansSerif, 24);
                    richTextBox.BorderStyle = BorderStyle.None;

                    tableLayoutPanel.Controls.Add(richTextBox);

                    // compute row and column index and add callback function
                    int row = 3 * (int)Math.Floor(blockNr / 3.0) + (int)Math.Floor(i / 3.0);
                    int column = 3 * (blockNr % 3) + (i % 3);

                    richTextBox.TextChanged += (sender, e) => UpdateCellValue(richTextBox, row, column);
                }

                tableLayoutPanel_sudoku.Controls.Add(tableLayoutPanel);
            }
        }

        private void UpdateCellValue(RichTextBox richTextBox, int row, int column)
        {
            //
            MessageBox.Show($"{richTextBox.Text} {row} {column}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Solver
{
    public partial class Form1 : Form
    {
        private readonly int[,] sudokuValues = new int[9, 9];

        private readonly RichTextBox[,] richTextBoxes = new RichTextBox[9, 9];

        private readonly List<RichTextBox> invalidRichtextBoxes = new List<RichTextBox>();
        
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

                    richTextBoxes[row, column] = richTextBox;
                }

                tableLayoutPanel_sudoku.Controls.Add(tableLayoutPanel);
            }
        }

        private void UpdateCellValue(RichTextBox richTextBox, int row, int column)
        {
            if (row < 0 || row > 8 || column < 0 || column > 8)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBox.Text))
            {
                richTextBox.BackColor = Color.White;

                sudokuValues[row, column] = 0;

                if (invalidRichtextBoxes.Contains(richTextBox))
                {
                    invalidRichtextBoxes.Remove(richTextBox);
                }
            }
            else
            {
                bool validInput = int.TryParse(richTextBox.Text, out int number);

                if (validInput && number >= 1 && number <= 9)
                {
                    richTextBox.BackColor = Color.White;

                    sudokuValues[row, column] = number;

                    if (invalidRichtextBoxes.Contains(richTextBox))
                    {
                        invalidRichtextBoxes.Remove(richTextBox);
                    }
                }
                else
                {
                    richTextBox.BackColor = Color.OrangeRed;

                    sudokuValues[row, column] = 0;

                    if (!invalidRichtextBoxes.Contains(richTextBox))
                    {
                        invalidRichtextBoxes.Add(richTextBox);
                    }
                }
            }
        }

        private void ClearSudoku(object sender, EventArgs e)
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    sudokuValues[x, y] = 0;

                    richTextBoxes[x, y].Text = string.Empty;
                    richTextBoxes[x, y].BackColor = Color.White;
                }
            }

            invalidRichtextBoxes.Clear();
        }

        private void SolveSudoku(object sender, EventArgs e)
        {
            if (invalidRichtextBoxes.Count > 0)
            {
                MessageBox.Show(
                    $"The sudoku contains {invalidRichtextBoxes.Count} invalid value(s). " +
                    $"Enter valid values or clear invalid values and try again.",
                    "Error"
                    );

                return;
            }
            
            Sudoku sudoku = new Sudoku();

            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    sudoku.SetValue(x, y, sudokuValues[x, y]);
                }
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            bool solved = sudoku.Solve();

            stopwatch.Stop();

            if (solved)
            {
                MessageBox.Show($"Solution found in {stopwatch.ElapsedMilliseconds} milliseconds.");

                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        sudokuValues[x, y] = sudoku.GetValue(x, y);

                        richTextBoxes[x, y].Text = sudoku.GetValue(x, y).ToString();
                        richTextBoxes[x, y].BackColor = Color.White;
                    }
                }
            }
            else
            {
                MessageBox.Show($"No solution found.");
            }
        }

        private void ClearInvalidCells(object sender, EventArgs e)
        {
            List<RichTextBox> invalidCells = invalidRichtextBoxes.ToList();

            invalidCells.ForEach(richTextBox =>
            {
                richTextBox.Text = string.Empty;
            });

            invalidRichtextBoxes.Clear();
        }
    }
}

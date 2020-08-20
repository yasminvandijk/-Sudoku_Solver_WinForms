namespace Sudoku_Solver
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_sudoku = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Solve = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Clear_Invalid_Cells = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel_sudoku, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 645);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel_sudoku
            // 
            this.tableLayoutPanel_sudoku.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_sudoku.ColumnCount = 3;
            this.tableLayoutPanel_sudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_sudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_sudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_sudoku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_sudoku.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_sudoku.Name = "tableLayoutPanel_sudoku";
            this.tableLayoutPanel_sudoku.RowCount = 3;
            this.tableLayoutPanel_sudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_sudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_sudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_sudoku.Size = new System.Drawing.Size(594, 594);
            this.tableLayoutPanel_sudoku.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_Solve);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(603, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(136, 594);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button_Solve
            // 
            this.button_Solve.Location = new System.Drawing.Point(3, 3);
            this.button_Solve.Name = "button_Solve";
            this.button_Solve.Size = new System.Drawing.Size(108, 23);
            this.button_Solve.TabIndex = 1;
            this.button_Solve.Text = "Solve";
            this.button_Solve.UseVisualStyleBackColor = true;
            this.button_Solve.Click += new System.EventHandler(this.SolveSudoku);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_Clear);
            this.flowLayoutPanel2.Controls.Add(this.button_Clear_Invalid_Cells);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 603);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(594, 39);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.Click += new System.EventHandler(this.ClearInvalidCells);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(3, 3);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(108, 23);
            this.button_Clear.TabIndex = 0;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.ClearSudoku);
            // 
            // button_Clear_Invalid_Cells
            // 
            this.button_Clear_Invalid_Cells.AutoSize = true;
            this.button_Clear_Invalid_Cells.Location = new System.Drawing.Point(117, 3);
            this.button_Clear_Invalid_Cells.Name = "button_Clear_Invalid_Cells";
            this.button_Clear_Invalid_Cells.Size = new System.Drawing.Size(108, 25);
            this.button_Clear_Invalid_Cells.TabIndex = 1;
            this.button_Clear_Invalid_Cells.Text = "Clear invalid cells";
            this.button_Clear_Invalid_Cells.UseVisualStyleBackColor = true;
            this.button_Clear_Invalid_Cells.Click += new System.EventHandler(this.ClearInvalidCells);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Sudoku Solver";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_sudoku;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Solve;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Clear_Invalid_Cells;
    }
}


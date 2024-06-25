namespace PPAI_CU_5.Ventana
{
    partial class ResumenActualizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Grid2 = new Guna.UI2.WinForms.Guna2DataGridView();
            Vino = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewTextBoxColumn();
            TituloBodega = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid2).BeginInit();
            SuspendLayout();
            // 
            // Grid2
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            Grid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            Grid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            Grid2.ColumnHeadersHeight = 17;
            Grid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Grid2.Columns.AddRange(new DataGridViewColumn[] { Vino, Accion });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            Grid2.DefaultCellStyle = dataGridViewCellStyle6;
            Grid2.GridColor = Color.FromArgb(231, 229, 255);
            Grid2.Location = new Point(291, 136);
            Grid2.Name = "Grid2";
            Grid2.RowHeadersVisible = false;
            Grid2.Size = new Size(240, 150);
            Grid2.TabIndex = 1;
            Grid2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Grid2.ThemeStyle.AlternatingRowsStyle.Font = null;
            Grid2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Grid2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Grid2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Grid2.ThemeStyle.BackColor = Color.White;
            Grid2.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            Grid2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            Grid2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Grid2.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            Grid2.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            Grid2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Grid2.ThemeStyle.HeaderStyle.Height = 17;
            Grid2.ThemeStyle.ReadOnly = false;
            Grid2.ThemeStyle.RowsStyle.BackColor = Color.White;
            Grid2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Grid2.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            Grid2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Grid2.ThemeStyle.RowsStyle.Height = 25;
            Grid2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Grid2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            Grid2.CellContentClick += guna2DataGridView1_CellContentClick_1;
            // 
            // Vino
            // 
            Vino.HeaderText = "Vino";
            Vino.Name = "Vino";
            // 
            // Accion
            // 
            Accion.HeaderText = "Accion";
            Accion.Name = "Accion";
            // 
            // TituloBodega
            // 
            TituloBodega.AutoSize = true;
            TituloBodega.Font = new Font("Segoe UI Historic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TituloBodega.Location = new Point(291, 72);
            TituloBodega.Name = "TituloBodega";
            TituloBodega.Size = new Size(126, 50);
            TituloBodega.TabIndex = 4;
            TituloBodega.Text = "label1";
            TituloBodega.Click += label1_Click;
            // 
            // ResumenActualizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 495);
            Controls.Add(TituloBodega);
            Controls.Add(Grid2);
            Name = "ResumenActualizacion";
            Text = "ResumenActualizacion";
            ((System.ComponentModel.ISupportInitialize)Grid2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView Grid2;
        private DataGridViewTextBoxColumn Vino;
        private DataGridViewTextBoxColumn Accion;
        private Label TituloBodega;
    }
}
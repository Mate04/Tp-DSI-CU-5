namespace PPAI_CU_5.Ventana
{
    partial class VentanaImportarBodega
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button1 = new Button();
            Grid = new Guna.UI2.WinForms.Guna2DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombree = new DataGridViewTextBoxColumn();
            tomarSeleccion = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.SizeAll;
            button1.Location = new Point(333, 256);
            button1.Name = "button1";
            button1.Size = new Size(146, 37);
            button1.TabIndex = 0;
            button1.Text = "BuscarActualizaciones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Grid
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            Grid.ColumnHeadersHeight = 17;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Grid.Columns.AddRange(new DataGridViewColumn[] { Id, Nombree });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            Grid.DefaultCellStyle = dataGridViewCellStyle6;
            Grid.GridColor = Color.FromArgb(231, 229, 255);
            Grid.Location = new Point(286, 82);
            Grid.Name = "Grid";
            Grid.RowHeadersVisible = false;
            Grid.Size = new Size(240, 150);
            Grid.TabIndex = 2;
            Grid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Grid.ThemeStyle.AlternatingRowsStyle.Font = null;
            Grid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Grid.ThemeStyle.BackColor = Color.White;
            Grid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            Grid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            Grid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Grid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            Grid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            Grid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Grid.ThemeStyle.HeaderStyle.Height = 17;
            Grid.ThemeStyle.ReadOnly = false;
            Grid.ThemeStyle.RowsStyle.BackColor = Color.White;
            Grid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Grid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            Grid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Grid.ThemeStyle.RowsStyle.Height = 25;
            Grid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Grid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            Grid.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombree
            // 
            Nombree.HeaderText = "Nombre";
            Nombree.Name = "Nombree";
            // 
            // tomarSeleccion
            // 
            tomarSeleccion.CustomizableEdges = customizableEdges3;
            tomarSeleccion.DisabledState.BorderColor = Color.DarkGray;
            tomarSeleccion.DisabledState.CustomBorderColor = Color.DarkGray;
            tomarSeleccion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tomarSeleccion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tomarSeleccion.Font = new Font("Segoe UI", 9F);
            tomarSeleccion.ForeColor = Color.White;
            tomarSeleccion.Location = new Point(318, 248);
            tomarSeleccion.Name = "tomarSeleccion";
            tomarSeleccion.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tomarSeleccion.Size = new Size(180, 45);
            tomarSeleccion.TabIndex = 3;
            tomarSeleccion.Text = " actualizar bodega";
            tomarSeleccion.Click += guna2Button1_Click;
            // 
            // VentanaImportarBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tomarSeleccion);
            Controls.Add(Grid);
            Controls.Add(button1);
            Name = "VentanaImportarBodega";
            Text = "VentanaImportarBodega";
            Load += VentanaImportarBodega_Load;
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView Grid;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombree;
        private Guna.UI2.WinForms.Guna2Button tomarSeleccion;
    }
}
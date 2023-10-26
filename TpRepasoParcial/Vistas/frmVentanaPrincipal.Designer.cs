
namespace TpRepasoParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdBuscar = new FontAwesome.Sharp.IconButton();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdExit = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmdReportes = new FontAwesome.Sharp.IconButton();
            this.cmdReporteTxt = new FontAwesome.Sharp.IconButton();
            this.cmdReporteCsv = new FontAwesome.Sharp.IconButton();
            this.Panel = new System.Windows.Forms.Panel();
            this.lblTotalImporte = new MaterialSkin.Controls.MaterialLabel();
            this.lblCantidadLibros = new MaterialSkin.Controls.MaterialLabel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.cmbiIdiomas = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdBuscar.FlatAppearance.BorderSize = 0;
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.cmdBuscar.IconColor = System.Drawing.Color.Black;
            this.cmdBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdBuscar.Location = new System.Drawing.Point(641, 180);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(245, 48);
            this.cmdBuscar.TabIndex = 0;
            this.cmdBuscar.Text = " Buscar Libros";
            this.cmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLibros.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLibros.EnableHeadersVisualStyles = false;
            this.dgvLibros.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvLibros.Location = new System.Drawing.Point(12, 24);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLibros.Size = new System.Drawing.Size(623, 449);
            this.dgvLibros.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Titulo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 220;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Año ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 105;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio unitario";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 105;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 105;
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.DarkBlue;
            this.cmdExit.FlatAppearance.BorderSize = 0;
            this.cmdExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.cmdExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.cmdExit.IconColor = System.Drawing.Color.Black;
            this.cmdExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdExit.IconSize = 24;
            this.cmdExit.Location = new System.Drawing.Point(843, 2);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(43, 26);
            this.cmdExit.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cmdExit, "Presione para cerrar el programa");
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 409);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(135, 25);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Cantidad de libros:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 448);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 25);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Total Importe:";
            // 
            // cmdReportes
            // 
            this.cmdReportes.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdReportes.FlatAppearance.BorderSize = 0;
            this.cmdReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReportes.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReportes.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.cmdReportes.IconColor = System.Drawing.Color.Black;
            this.cmdReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdReportes.Location = new System.Drawing.Point(641, 244);
            this.cmdReportes.Name = "cmdReportes";
            this.cmdReportes.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.cmdReportes.Size = new System.Drawing.Size(245, 48);
            this.cmdReportes.TabIndex = 5;
            this.cmdReportes.Text = "  Reportes";
            this.cmdReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdReportes.UseVisualStyleBackColor = false;
            this.cmdReportes.Click += new System.EventHandler(this.cmdReportes_Click);
            // 
            // cmdReporteTxt
            // 
            this.cmdReporteTxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmdReporteTxt.FlatAppearance.BorderSize = 0;
            this.cmdReporteTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReporteTxt.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReporteTxt.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.cmdReporteTxt.IconColor = System.Drawing.Color.Black;
            this.cmdReporteTxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdReporteTxt.IconSize = 30;
            this.cmdReporteTxt.Location = new System.Drawing.Point(641, 289);
            this.cmdReporteTxt.Name = "cmdReporteTxt";
            this.cmdReporteTxt.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.cmdReporteTxt.Size = new System.Drawing.Size(245, 36);
            this.cmdReporteTxt.TabIndex = 6;
            this.cmdReporteTxt.Text = "  Reporte .txt";
            this.cmdReporteTxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdReporteTxt.UseVisualStyleBackColor = false;
            this.cmdReporteTxt.Visible = false;
            this.cmdReporteTxt.Click += new System.EventHandler(this.cmdReporteTxt_Click);
            // 
            // cmdReporteCsv
            // 
            this.cmdReporteCsv.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmdReporteCsv.FlatAppearance.BorderSize = 0;
            this.cmdReporteCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReporteCsv.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReporteCsv.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.cmdReporteCsv.IconColor = System.Drawing.Color.Black;
            this.cmdReporteCsv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdReporteCsv.IconSize = 30;
            this.cmdReporteCsv.Location = new System.Drawing.Point(641, 321);
            this.cmdReporteCsv.Name = "cmdReporteCsv";
            this.cmdReporteCsv.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.cmdReporteCsv.Size = new System.Drawing.Size(245, 36);
            this.cmdReporteCsv.TabIndex = 7;
            this.cmdReporteCsv.Text = "  Reporte .csv";
            this.cmdReporteCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdReporteCsv.UseVisualStyleBackColor = false;
            this.cmdReporteCsv.Visible = false;
            this.cmdReporteCsv.Click += new System.EventHandler(this.cmdReporteCsv_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.DarkBlue;
            this.Panel.Controls.Add(this.lblTotalImporte);
            this.Panel.Controls.Add(this.lblCantidadLibros);
            this.Panel.Controls.Add(this.iconButton1);
            this.Panel.Controls.Add(this.cmbiIdiomas);
            this.Panel.Controls.Add(this.materialLabel2);
            this.Panel.Controls.Add(this.materialLabel1);
            this.Panel.Location = new System.Drawing.Point(641, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(244, 493);
            this.Panel.TabIndex = 8;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // lblTotalImporte
            // 
            this.lblTotalImporte.Depth = 0;
            this.lblTotalImporte.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalImporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalImporte.Location = new System.Drawing.Point(164, 448);
            this.lblTotalImporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalImporte.Name = "lblTotalImporte";
            this.lblTotalImporte.Size = new System.Drawing.Size(43, 25);
            this.lblTotalImporte.TabIndex = 11;
            // 
            // lblCantidadLibros
            // 
            this.lblCantidadLibros.Depth = 0;
            this.lblCantidadLibros.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCantidadLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCantidadLibros.Location = new System.Drawing.Point(164, 409);
            this.lblCantidadLibros.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantidadLibros.Name = "lblCantidadLibros";
            this.lblCantidadLibros.Size = new System.Drawing.Size(43, 25);
            this.lblCantidadLibros.TabIndex = 10;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(0, 57);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(245, 48);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "Seleccione un idioma";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // cmbiIdiomas
            // 
            this.cmbiIdiomas.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmbiIdiomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbiIdiomas.FormattingEnabled = true;
            this.cmbiIdiomas.Location = new System.Drawing.Point(29, 121);
            this.cmbiIdiomas.Name = "cmbiIdiomas";
            this.cmbiIdiomas.Size = new System.Drawing.Size(196, 21);
            this.cmbiIdiomas.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(884, 492);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.cmdReportes);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdReporteTxt);
            this.Controls.Add(this.cmdReporteCsv);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton cmdBuscar;
        private System.Windows.Forms.DataGridView dgvLibros;
        private FontAwesome.Sharp.IconButton cmdExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private FontAwesome.Sharp.IconButton cmdReportes;
        private FontAwesome.Sharp.IconButton cmdReporteTxt;
        private FontAwesome.Sharp.IconButton cmdReporteCsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.ComboBox cmbiIdiomas;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MaterialSkin.Controls.MaterialLabel lblTotalImporte;
        private MaterialSkin.Controls.MaterialLabel lblCantidadLibros;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


namespace SGA_Client.Forms
{
    partial class AlumnosProfesorView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreAlumno = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24367F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.49391F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.46204F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.716026F));
            this.tableLayoutPanel1.Controls.Add(this.dgvAlumnos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 689);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvAlumnos, 4);
            this.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnos.Location = new System.Drawing.Point(119, 148);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(840, 389);
            this.dgvAlumnos.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Image = global::SGA_Client.Properties.Resources.salirSmallIcon;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(756, 561);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(203, 44);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbNombreAlumno, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(109, 71);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(271, 62);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // tbNombreAlumno
            // 
            this.tbNombreAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNombreAlumno.Location = new System.Drawing.Point(10, 30);
            this.tbNombreAlumno.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tbNombreAlumno.Name = "tbNombreAlumno";
            this.tbNombreAlumno.Size = new System.Drawing.Size(258, 22);
            this.tbNombreAlumno.TabIndex = 1;
            this.tbNombreAlumno.TextChanged += new System.EventHandler(this.tbNombreAlumno_TextChanged);
            this.tbNombreAlumno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNombreAlumno_KeyDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbGrupo, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(746, 71);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(222, 62);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo";
            // 
            // cbGrupo
            // 
            this.cbGrupo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbGrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Items.AddRange(new object[] {
            "1roA",
            "1roB",
            "2doA",
            "2doB",
            "3roA",
            "3roB",
            "4toA",
            "4toB",
            "5toA",
            "5toB",
            "6toA",
            "6toB",
            "Ninguno"});
            this.cbGrupo.Location = new System.Drawing.Point(3, 27);
            this.cbGrupo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(216, 24);
            this.cbGrupo.TabIndex = 22;
            // 
            // AlumnosProfesorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 689);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 726);
            this.Name = "AlumnosProfesorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.AlumnosView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreAlumno;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.DataGridView dgvAlumnos;
    }
}
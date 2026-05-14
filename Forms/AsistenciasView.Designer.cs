namespace SGA_Client.Forms
{
    partial class AsistenciasView
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
            this.Title = new System.Windows.Forms.Label();
            this.NumAlumno = new System.Windows.Forms.Label();
            this.NombreAlumno = new System.Windows.Forms.Label();
            this.btnAsistencias = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.NombreAlumno, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NumAlumno, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Title, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAsistencias, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Title, 3);
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Location = new System.Drawing.Point(170, 122);
            this.Title.Margin = new System.Windows.Forms.Padding(10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(460, 36);
            this.Title.TabIndex = 1;
            this.Title.Text = "Toma de Asistencia";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumAlumno
            // 
            this.NumAlumno.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.NumAlumno, 3);
            this.NumAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumAlumno.Location = new System.Drawing.Point(170, 178);
            this.NumAlumno.Margin = new System.Windows.Forms.Padding(10);
            this.NumAlumno.Name = "NumAlumno";
            this.NumAlumno.Size = new System.Drawing.Size(460, 36);
            this.NumAlumno.TabIndex = 2;
            this.NumAlumno.Text = "Alumno 0 de 20";
            this.NumAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombreAlumno
            // 
            this.NombreAlumno.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.NombreAlumno, 3);
            this.NombreAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreAlumno.Location = new System.Drawing.Point(170, 234);
            this.NombreAlumno.Margin = new System.Windows.Forms.Padding(10);
            this.NombreAlumno.Name = "NombreAlumno";
            this.NombreAlumno.Size = new System.Drawing.Size(460, 92);
            this.NombreAlumno.TabIndex = 3;
            this.NombreAlumno.Text = "Del Angel Alcalde César Adrián";
            this.NombreAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsistencias.BackColor = System.Drawing.Color.White;
            this.btnAsistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencias.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencias.Image = global::SGA_Client.Properties.Resources.presenteIcon;
            this.btnAsistencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencias.Location = new System.Drawing.Point(170, 346);
            this.btnAsistencias.Margin = new System.Windows.Forms.Padding(10);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Size = new System.Drawing.Size(140, 36);
            this.btnAsistencias.TabIndex = 4;
            this.btnAsistencias.Text = "Presente";
            this.btnAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsistencias.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SGA_Client.Properties.Resources.ausenteIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(330, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Justificante";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::SGA_Client.Properties.Resources.salirSmallIcon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(490, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ausente";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AsistenciasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AsistenciasView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsistenciasView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label NumAlumno;
        private System.Windows.Forms.Label NombreAlumno;
        private System.Windows.Forms.Button btnAsistencias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
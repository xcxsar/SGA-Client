namespace SGA_Client.Forms
{
    partial class UsuariosCambiarContrasenaView
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblConfirmarPassword = new System.Windows.Forms.Label();
            this.tbConContrasena = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.97594F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.22337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.80069F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblConfirmarPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbConContrasena, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbContrasena, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.3162F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.01581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 253);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::SGA_Client.Properties.Resources.guardarIcon;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(374, 195);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnGuardar.MinimumSize = new System.Drawing.Size(100, 50);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(195, 50);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Confirmar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(169, 195);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(179, 46);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblConfirmarPassword
            // 
            this.lblConfirmarPassword.AutoSize = true;
            this.lblConfirmarPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmarPassword.Location = new System.Drawing.Point(13, 114);
            this.lblConfirmarPassword.Margin = new System.Windows.Forms.Padding(13, 12, 5, 12);
            this.lblConfirmarPassword.Name = "lblConfirmarPassword";
            this.lblConfirmarPassword.Size = new System.Drawing.Size(138, 57);
            this.lblConfirmarPassword.TabIndex = 18;
            this.lblConfirmarPassword.Text = "Confirmar Contraseña Nueva";
            this.lblConfirmarPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbConContrasena
            // 
            this.tbConContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.tbConContrasena, 2);
            this.tbConContrasena.Location = new System.Drawing.Point(169, 131);
            this.tbConContrasena.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tbConContrasena.MaxLength = 40;
            this.tbConContrasena.Name = "tbConContrasena";
            this.tbConContrasena.Size = new System.Drawing.Size(399, 22);
            this.tbConContrasena.TabIndex = 17;
            this.tbConContrasena.UseSystemPasswordChar = true;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.tbContrasena, 2);
            this.tbContrasena.Location = new System.Drawing.Point(169, 40);
            this.tbContrasena.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tbContrasena.MaxLength = 40;
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.Size = new System.Drawing.Size(399, 22);
            this.tbContrasena.TabIndex = 16;
            this.tbContrasena.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Location = new System.Drawing.Point(13, 12);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(13, 12, 5, 12);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(138, 78);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Contraseña Nueva";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsuariosCambiarContrasenaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "UsuariosCambiarContrasenaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambioContrasena";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.TextBox tbConContrasena;
        private System.Windows.Forms.Label lblConfirmarPassword;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
    }
}
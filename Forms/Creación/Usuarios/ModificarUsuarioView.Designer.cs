namespace SGA_Client.Forms.Creación
{
    partial class ModificarUsuarioView
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
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblConfirmarPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.tbNombreAlumno = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.tbConContrasena = new System.Windows.Forms.TextBox();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTipoUsuario, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblConfirmarPassword, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCorreo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Title, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbNombreAlumno, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbCorreo, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbContrasena, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbConContrasena, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbTipoUsuario, 3, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 690);
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
            this.btnGuardar.Location = new System.Drawing.Point(691, 544);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(235, 52);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
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
            this.btnSalir.Location = new System.Drawing.Point(430, 544);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(235, 52);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipoUsuario.Location = new System.Drawing.Point(117, 468);
            this.lblTipoUsuario.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(183, 52);
            this.lblTipoUsuario.TabIndex = 6;
            this.lblTipoUsuario.Text = "Tipo de Usuario";
            this.lblTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConfirmarPassword
            // 
            this.lblConfirmarPassword.AutoSize = true;
            this.lblConfirmarPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmarPassword.Location = new System.Drawing.Point(117, 392);
            this.lblConfirmarPassword.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblConfirmarPassword.Name = "lblConfirmarPassword";
            this.lblConfirmarPassword.Size = new System.Drawing.Size(183, 52);
            this.lblConfirmarPassword.TabIndex = 5;
            this.lblConfirmarPassword.Text = "Confirmar Contraseña Nueva";
            this.lblConfirmarPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Location = new System.Drawing.Point(117, 316);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(183, 52);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Contraseña Nueva";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCorreo.Location = new System.Drawing.Point(117, 240);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(183, 52);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(117, 164);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(183, 52);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Title, 4);
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Location = new System.Drawing.Point(117, 88);
            this.Title.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(809, 52);
            this.Title.TabIndex = 1;
            this.Title.Text = "Datos del Usuario";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNombreAlumno
            // 
            this.tbNombreAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.tbNombreAlumno, 2);
            this.tbNombreAlumno.Location = new System.Drawing.Point(430, 179);
            this.tbNombreAlumno.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tbNombreAlumno.MaxLength = 40;
            this.tbNombreAlumno.Name = "tbNombreAlumno";
            this.tbNombreAlumno.Size = new System.Drawing.Size(495, 22);
            this.tbNombreAlumno.TabIndex = 13;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.tbCorreo, 2);
            this.tbCorreo.Location = new System.Drawing.Point(430, 255);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tbCorreo.MaxLength = 40;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(495, 22);
            this.tbCorreo.TabIndex = 14;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.tbContrasena, 2);
            this.tbContrasena.Location = new System.Drawing.Point(430, 331);
            this.tbContrasena.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tbContrasena.MaxLength = 40;
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.Size = new System.Drawing.Size(495, 22);
            this.tbContrasena.TabIndex = 15;
            this.tbContrasena.UseSystemPasswordChar = true;
            // 
            // tbConContrasena
            // 
            this.tbConContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.tbConContrasena, 2);
            this.tbConContrasena.Location = new System.Drawing.Point(430, 407);
            this.tbConContrasena.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tbConContrasena.MaxLength = 40;
            this.tbConContrasena.Name = "tbConContrasena";
            this.tbConContrasena.Size = new System.Drawing.Size(495, 22);
            this.tbConContrasena.TabIndex = 16;
            this.tbConContrasena.UseSystemPasswordChar = true;
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.cbTipoUsuario, 2);
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Profesor",
            "Direccion"});
            this.cbTipoUsuario.Location = new System.Drawing.Point(430, 482);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(495, 24);
            this.cbTipoUsuario.TabIndex = 21;
            // 
            // ModificarUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "ModificarUsuarioView";
            this.Text = "RegistrarUsuarioView";
            this.Load += new System.EventHandler(this.ModificarUsuarioView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblConfirmarPassword;
        private System.Windows.Forms.TextBox tbNombreAlumno;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.TextBox tbConContrasena;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}
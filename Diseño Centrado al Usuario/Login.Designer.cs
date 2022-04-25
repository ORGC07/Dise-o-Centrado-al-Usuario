namespace Diseño_Centrado_al_Usuario
{
    partial class Login
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
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Aceptarbtn = new System.Windows.Forms.Button();
            this.Registrobtn = new System.Windows.Forms.Button();
            this.UsuarioTx = new System.Windows.Forms.TextBox();
            this.PasswordTx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(27, 62);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(56, 14);
            this.LabelUsuario.TabIndex = 0;
            this.LabelUsuario.Text = "Usuario:";
            this.LabelUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // Aceptarbtn
            // 
            this.Aceptarbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbtn.Location = new System.Drawing.Point(129, 151);
            this.Aceptarbtn.Name = "Aceptarbtn";
            this.Aceptarbtn.Size = new System.Drawing.Size(87, 23);
            this.Aceptarbtn.TabIndex = 2;
            this.Aceptarbtn.Text = "Aceptar";
            this.Aceptarbtn.UseVisualStyleBackColor = true;
            this.Aceptarbtn.Click += new System.EventHandler(this.Aceptarbtn_Click);
            // 
            // Registrobtn
            // 
            this.Registrobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Registrobtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrobtn.Location = new System.Drawing.Point(23, 151);
            this.Registrobtn.Name = "Registrobtn";
            this.Registrobtn.Size = new System.Drawing.Size(87, 23);
            this.Registrobtn.TabIndex = 3;
            this.Registrobtn.Text = "Registrarse";
            this.Registrobtn.UseVisualStyleBackColor = true;
            this.Registrobtn.Click += new System.EventHandler(this.Registrobtn_Click);
            // 
            // UsuarioTx
            // 
            this.UsuarioTx.Location = new System.Drawing.Point(105, 59);
            this.UsuarioTx.Name = "UsuarioTx";
            this.UsuarioTx.Size = new System.Drawing.Size(111, 20);
            this.UsuarioTx.TabIndex = 4;
            // 
            // PasswordTx
            // 
            this.PasswordTx.Location = new System.Drawing.Point(105, 106);
            this.PasswordTx.Name = "PasswordTx";
            this.PasswordTx.Size = new System.Drawing.Size(111, 20);
            this.PasswordTx.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 31);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(221, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(247, 201);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PasswordTx);
            this.Controls.Add(this.UsuarioTx);
            this.Controls.Add(this.Registrobtn);
            this.Controls.Add(this.Aceptarbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Aceptarbtn;
        private System.Windows.Forms.Button Registrobtn;
        private System.Windows.Forms.TextBox UsuarioTx;
        private System.Windows.Forms.TextBox PasswordTx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}


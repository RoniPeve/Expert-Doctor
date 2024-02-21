namespace Expert_Doctor
{
    partial class IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.panelRight = new System.Windows.Forms.Panel();
            this.txtcontrasenia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.txtcontrasenia);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.panel3);
            this.panelRight.Controls.Add(this.txtusuario);
            this.panelRight.Controls.Add(this.panel2);
            this.panelRight.Controls.Add(this.btnIniciar);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.label8);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(344, 543);
            this.panelRight.TabIndex = 8;
            // 
            // txtcontrasenia
            // 
            this.txtcontrasenia.BackColor = System.Drawing.SystemColors.Control;
            this.txtcontrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.txtcontrasenia.Location = new System.Drawing.Point(20, 332);
            this.txtcontrasenia.Name = "txtcontrasenia";
            this.txtcontrasenia.Size = new System.Drawing.Size(309, 20);
            this.txtcontrasenia.TabIndex = 14;
            this.txtcontrasenia.Text = "CONTRASEÑA";
            this.txtcontrasenia.TextChanged += new System.EventHandler(this.txtcontrasenia_TextChanged);
            this.txtcontrasenia.Enter += new System.EventHandler(this.txtcontraseña_Enter);
            this.txtcontrasenia.Leave += new System.EventHandler(this.txtcontraseña_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(110, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel3.Location = new System.Drawing.Point(20, 354);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 1);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtusuario.Location = new System.Drawing.Point(22, 246);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(311, 20);
            this.txtusuario.TabIndex = 12;
            this.txtusuario.Text = "USUARIO";
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel2.Location = new System.Drawing.Point(20, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 1);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(22, 422);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(297, 34);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(18, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contraseña:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(18, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(363, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "x";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(17, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Iniciar Sesión";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblcerrar
            // 
            this.lblcerrar.AutoSize = true;
            this.lblcerrar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcerrar.ForeColor = System.Drawing.Color.White;
            this.lblcerrar.Location = new System.Drawing.Point(284, 9);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(25, 30);
            this.lblcerrar.TabIndex = 16;
            this.lblcerrar.Text = "x";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panelLeft.Controls.Add(this.lblcerrar);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(344, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(321, 543);
            this.panelLeft.TabIndex = 6;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 543);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciarSesion";
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TextBox txtcontrasenia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeft;
    }
}
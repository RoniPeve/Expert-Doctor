namespace Expert_Doctor
{
    partial class NewSintomas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSintomas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnguarda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsintomas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreEnfermedad = new System.Windows.Forms.Label();
            this.dataEnfermedades = new System.Windows.Forms.DataGridView();
            this.NombreEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEnfermedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(315, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 1);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(315, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 1);
            this.panel3.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.dataEnfermedades);
            this.panel1.Controls.Add(this.btnSeleccionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 431);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.White;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionar.Location = new System.Drawing.Point(32, 371);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(177, 29);
            this.btnSeleccionar.TabIndex = 17;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnguarda
            // 
            this.btnguarda.BackColor = System.Drawing.Color.White;
            this.btnguarda.FlatAppearance.BorderSize = 0;
            this.btnguarda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguarda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguarda.ForeColor = System.Drawing.Color.Black;
            this.btnguarda.Location = new System.Drawing.Point(423, 362);
            this.btnguarda.Name = "btnguarda";
            this.btnguarda.Size = new System.Drawing.Size(138, 38);
            this.btnguarda.TabIndex = 24;
            this.btnguarda.Text = "Guardar";
            this.btnguarda.UseVisualStyleBackColor = false;
            this.btnguarda.Click += new System.EventHandler(this.btnguarda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "AGREGAR SÍNTOMAS";
            // 
            // txtsintomas
            // 
            this.txtsintomas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.txtsintomas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsintomas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsintomas.ForeColor = System.Drawing.Color.White;
            this.txtsintomas.Location = new System.Drawing.Point(315, 270);
            this.txtsintomas.Multiline = true;
            this.txtsintomas.Name = "txtsintomas";
            this.txtsintomas.Size = new System.Drawing.Size(360, 28);
            this.txtsintomas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre de Enfermedad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(311, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Síntoma :";
            // 
            // lblNombreEnfermedad
            // 
            this.lblNombreEnfermedad.AutoSize = true;
            this.lblNombreEnfermedad.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblNombreEnfermedad.ForeColor = System.Drawing.Color.White;
            this.lblNombreEnfermedad.Location = new System.Drawing.Point(318, 169);
            this.lblNombreEnfermedad.Name = "lblNombreEnfermedad";
            this.lblNombreEnfermedad.Size = new System.Drawing.Size(0, 22);
            this.lblNombreEnfermedad.TabIndex = 33;
            // 
            // dataEnfermedades
            // 
            this.dataEnfermedades.AllowUserToAddRows = false;
            this.dataEnfermedades.AllowUserToDeleteRows = false;
            this.dataEnfermedades.AllowUserToResizeColumns = false;
            this.dataEnfermedades.AllowUserToResizeRows = false;
            this.dataEnfermedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEnfermedades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataEnfermedades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataEnfermedades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataEnfermedades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEnfermedades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataEnfermedades.ColumnHeadersHeight = 30;
            this.dataEnfermedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEnfermedad});
            this.dataEnfermedades.EnableHeadersVisualStyles = false;
            this.dataEnfermedades.GridColor = System.Drawing.Color.SteelBlue;
            this.dataEnfermedades.Location = new System.Drawing.Point(32, 34);
            this.dataEnfermedades.Name = "dataEnfermedades";
            this.dataEnfermedades.ReadOnly = true;
            this.dataEnfermedades.RowHeadersVisible = false;
            this.dataEnfermedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataEnfermedades.Size = new System.Drawing.Size(228, 308);
            this.dataEnfermedades.TabIndex = 25;
            // 
            // NombreEnfermedad
            // 
            this.NombreEnfermedad.DataPropertyName = "NombreEnfermedad";
            this.NombreEnfermedad.HeaderText = "ENFERMEDAD";
            this.NombreEnfermedad.Name = "NombreEnfermedad";
            this.NombreEnfermedad.ReadOnly = true;
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(808, 9);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(24, 24);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 32;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Expert_Doctor.Properties.Resources.sintomas;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(688, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // NewSintomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(855, 431);
            this.Controls.Add(this.lblNombreEnfermedad);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnguarda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsintomas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewSintomas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewSintomas";
            this.Load += new System.EventHandler(this.NewSintomas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewSintomas_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEnfermedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnguarda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtsintomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label lblNombreEnfermedad;
        private System.Windows.Forms.DataGridView dataEnfermedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEnfermedad;
    }
}
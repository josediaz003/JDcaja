﻿namespace JDcaja
{
    partial class FrmNegocio
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.btnsubir = new FontAwesome.Sharp.IconButton();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 29);
            this.label9.TabIndex = 77;
            this.label9.Text = "Detalle Negocio";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1232, 758);
            this.label1.TabIndex = 76;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txtruc);
            this.groupBox1.Controls.Add(this.btnsubir);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.Logo);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1140, 598);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Black;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnguardar.IconColor = System.Drawing.Color.Black;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 26;
            this.btnguardar.Location = new System.Drawing.Point(519, 436);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(430, 58);
            this.btnguardar.TabIndex = 85;
            this.btnguardar.Text = "Guardar Cambios";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtruc
            // 
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.Location = new System.Drawing.Point(518, 285);
            this.txtruc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(431, 38);
            this.txtruc.TabIndex = 82;
            // 
            // btnsubir
            // 
            this.btnsubir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubir.ForeColor = System.Drawing.Color.Black;
            this.btnsubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnsubir.IconColor = System.Drawing.Color.Black;
            this.btnsubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsubir.IconSize = 26;
            this.btnsubir.Location = new System.Drawing.Point(87, 436);
            this.btnsubir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsubir.Name = "btnsubir";
            this.btnsubir.Size = new System.Drawing.Size(386, 58);
            this.btnsubir.TabIndex = 79;
            this.btnsubir.Text = "Subir";
            this.btnsubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsubir.UseVisualStyleBackColor = false;
            this.btnsubir.Click += new System.EventHandler(this.btnsubir_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(517, 372);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(431, 38);
            this.txtdireccion.TabIndex = 83;
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Location = new System.Drawing.Point(84, 116);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(41, 16);
            this.Logo.TabIndex = 1;
            this.Logo.Text = "Logo:";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(517, 208);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(431, 38);
            this.txtnombre.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "Direccion:";
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(87, 140);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(386, 287);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "R.U.C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "Nombre Negocio:";
            // 
            // FrmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 758);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "FrmNegocio";
            this.Text = "FrmNegocio";
            this.Load += new System.EventHandler(this.FrmNegocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label Logo;
        private FontAwesome.Sharp.IconButton btnsubir;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
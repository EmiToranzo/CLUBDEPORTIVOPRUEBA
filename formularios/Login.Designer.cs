
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Data;
using System.Windows.Forms;
using System;
using formularios.Datos;

namespace formularios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 

        
          
           
            
            private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.Control;
            textBox1.Location = new System.Drawing.Point(682, 150);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(470, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "USUARIO";
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new System.Drawing.Point(682, 289);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(472, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "CONTRASEÑA";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new System.Drawing.Size(1059, 552);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
            {
                DataTable tablaLogin = new DataTable();
                // es la que recibe los datos desde el formulario

                Datos.Usuarios dato = new Datos.Usuarios(); 
                // variable que contiene todas las caracteristicas de la clase//
                tablaLogin = dato.Log_Usu(textBox1.Name, textBox2.Name);
                if (tablaLogin.Rows.Count > 0)
                {
                    // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE

                    MessageBox.Show("Ingreso exitoso");
                }
                else
                {
                    MessageBox.Show("Usuario y/o password incorrecto");
                }

                // 
                // button1
                // 
                button1.Location = new System.Drawing.Point(805, 427);
            button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(164, 51);
            button1.TabIndex = 2;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1.Image = (System.Drawing.Image) resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(44, 88);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(536, 541);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ScrollBar;
            ClientSize = new System.Drawing.Size(1400, 788);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

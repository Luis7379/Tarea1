﻿namespace Tarea1.Formularios
{
    partial class FrmE6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlem = new System.Windows.Forms.TextBox();
            this.txteu = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese cantidad en Lempiras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Euros";
            // 
            // txtlem
            // 
            this.txtlem.Location = new System.Drawing.Point(185, 34);
            this.txtlem.Name = "txtlem";
            this.txtlem.Size = new System.Drawing.Size(100, 20);
            this.txtlem.TabIndex = 2;
            // 
            // txteu
            // 
            this.txteu.Location = new System.Drawing.Point(158, 85);
            this.txteu.Name = "txteu";
            this.txteu.Size = new System.Drawing.Size(100, 20);
            this.txteu.TabIndex = 3;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(91, 137);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "Convertir";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(196, 136);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 23);
            this.btnL.TabIndex = 5;
            this.btnL.Text = "Limpiar";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // FrmE6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 325);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.txteu);
            this.Controls.Add(this.txtlem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE6";
            this.Text = "Lempiras a Euros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlem;
        private System.Windows.Forms.TextBox txteu;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnL;
    }
}
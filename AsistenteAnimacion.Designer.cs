﻿namespace ProyectoFinalMYSQL
{
    partial class AsistenteAnimacion
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtidD = new System.Windows.Forms.TextBox();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dGVASA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVASA)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "idDirector";
            // 
            // txtidD
            // 
            this.txtidD.Location = new System.Drawing.Point(423, 28);
            this.txtidD.Name = "txtidD";
            this.txtidD.Size = new System.Drawing.Size(100, 20);
            this.txtidD.TabIndex = 66;
            // 
            // txtAM
            // 
            this.txtAM.Location = new System.Drawing.Point(298, 28);
            this.txtAM.Name = "txtAM";
            this.txtAM.Size = new System.Drawing.Size(100, 20);
            this.txtAM.TabIndex = 65;
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(161, 28);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(100, 20);
            this.txtAP.TabIndex = 64;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nombre";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(718, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 40);
            this.button4.TabIndex = 59;
            this.button4.Text = "REGRESAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(610, 77);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(718, 77);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 40);
            this.btnModificar.TabIndex = 57;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(502, 77);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 40);
            this.btnAgregar.TabIndex = 56;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dGVASA
            // 
            this.dGVASA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVASA.Location = new System.Drawing.Point(23, 123);
            this.dGVASA.Name = "dGVASA";
            this.dGVASA.Size = new System.Drawing.Size(797, 248);
            this.dGVASA.TabIndex = 55;
            // 
            // AsistenteAnimacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 420);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtidD);
            this.Controls.Add(this.txtAM);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dGVASA);
            this.Name = "AsistenteAnimacion";
            this.Text = "AsistenteAnimacion";
            this.Load += new System.EventHandler(this.AsistenteAnimacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVASA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidD;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dGVASA;
    }
}
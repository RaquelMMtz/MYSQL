namespace ProyectoFinalMYSQL
{
    partial class IngresoExhibicionInternacional
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumIn = new System.Windows.Forms.TextBox();
            this.txtIDEI = new System.Windows.Forms.TextBox();
            this.txtIDI = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dGVIE = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVIE)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 130;
            this.label3.Text = "Numero de Integrantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "idExhibicionInternacional";
            // 
            // txtNumIn
            // 
            this.txtNumIn.Location = new System.Drawing.Point(336, 45);
            this.txtNumIn.Name = "txtNumIn";
            this.txtNumIn.Size = new System.Drawing.Size(100, 20);
            this.txtNumIn.TabIndex = 128;
            // 
            // txtIDEI
            // 
            this.txtIDEI.Location = new System.Drawing.Point(193, 45);
            this.txtIDEI.Name = "txtIDEI";
            this.txtIDEI.Size = new System.Drawing.Size(100, 20);
            this.txtIDEI.TabIndex = 127;
            // 
            // txtIDI
            // 
            this.txtIDI.Location = new System.Drawing.Point(39, 45);
            this.txtIDI.Name = "txtIDI";
            this.txtIDI.Size = new System.Drawing.Size(100, 20);
            this.txtIDI.TabIndex = 126;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(593, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 40);
            this.button4.TabIndex = 125;
            this.button4.Text = "REGRESAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(596, 45);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminar.TabIndex = 124;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(596, 91);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 40);
            this.btnModificar.TabIndex = 123;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(596, -1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 40);
            this.btnAgregar.TabIndex = 122;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dGVIE
            // 
            this.dGVIE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVIE.Location = new System.Drawing.Point(24, 141);
            this.dGVIE.Name = "dGVIE";
            this.dGVIE.Size = new System.Drawing.Size(671, 248);
            this.dGVIE.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "idIngreso";
            // 
            // IngresoExhibicionInternacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumIn);
            this.Controls.Add(this.txtIDEI);
            this.Controls.Add(this.txtIDI);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dGVIE);
            this.Name = "IngresoExhibicionInternacional";
            this.Text = "IngresoExhibicionInternacional";
            this.Load += new System.EventHandler(this.IngresoExhibicionInternacional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVIE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumIn;
        private System.Windows.Forms.TextBox txtIDEI;
        private System.Windows.Forms.TextBox txtIDI;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dGVIE;
        private System.Windows.Forms.Label label1;
    }
}
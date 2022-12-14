namespace ProyectoFinalMYSQL
{
    partial class Colaboracion
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
            this.txtIDJD = new System.Windows.Forms.TextBox();
            this.txtNumIn = new System.Windows.Forms.TextBox();
            this.txtEstudio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dGVColaboracion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVColaboracion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDJD
            // 
            this.txtIDJD.Location = new System.Drawing.Point(373, 12);
            this.txtIDJD.Name = "txtIDJD";
            this.txtIDJD.Size = new System.Drawing.Size(100, 20);
            this.txtIDJD.TabIndex = 50;
            // 
            // txtNumIn
            // 
            this.txtNumIn.Location = new System.Drawing.Point(187, 9);
            this.txtNumIn.Name = "txtNumIn";
            this.txtNumIn.Size = new System.Drawing.Size(100, 20);
            this.txtNumIn.TabIndex = 49;
            // 
            // txtEstudio
            // 
            this.txtEstudio.Location = new System.Drawing.Point(25, 9);
            this.txtEstudio.Name = "txtEstudio";
            this.txtEstudio.Size = new System.Drawing.Size(100, 20);
            this.txtEstudio.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "idJunta Directiva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Numero de Integrantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Estudio";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(532, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 40);
            this.button4.TabIndex = 44;
            this.button4.Text = "REGRESAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(424, 104);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(532, 104);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 40);
            this.btnModificar.TabIndex = 42;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(316, 104);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 40);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dGVColaboracion
            // 
            this.dGVColaboracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVColaboracion.Location = new System.Drawing.Point(12, 150);
            this.dGVColaboracion.Name = "dGVColaboracion";
            this.dGVColaboracion.Size = new System.Drawing.Size(622, 248);
            this.dGVColaboracion.TabIndex = 40;
            // 
            // Colaboracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.txtIDJD);
            this.Controls.Add(this.txtNumIn);
            this.Controls.Add(this.txtEstudio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dGVColaboracion);
            this.Name = "Colaboracion";
            this.Text = "Colaboracion";
            this.Load += new System.EventHandler(this.Colaboracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVColaboracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDJD;
        private System.Windows.Forms.TextBox txtNumIn;
        private System.Windows.Forms.TextBox txtEstudio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dGVColaboracion;
    }
}
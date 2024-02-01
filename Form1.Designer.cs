namespace personas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labeldpi = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelapellido = new System.Windows.Forms.Label();
            this.labelfechan = new System.Windows.Forms.Label();
            this.textBoxdpi = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxape = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelNombreNormalizado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeldpi
            // 
            this.labeldpi.AutoSize = true;
            this.labeldpi.Location = new System.Drawing.Point(47, 52);
            this.labeldpi.Name = "labeldpi";
            this.labeldpi.Size = new System.Drawing.Size(29, 16);
            this.labeldpi.TabIndex = 0;
            this.labeldpi.Text = "DPI";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(47, 105);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(56, 16);
            this.labelnombre.TabIndex = 1;
            this.labelnombre.Text = "Nombre";
            // 
            // labelapellido
            // 
            this.labelapellido.AutoSize = true;
            this.labelapellido.Location = new System.Drawing.Point(47, 164);
            this.labelapellido.Name = "labelapellido";
            this.labelapellido.Size = new System.Drawing.Size(57, 16);
            this.labelapellido.TabIndex = 2;
            this.labelapellido.Text = "Apellido";
            // 
            // labelfechan
            // 
            this.labelfechan.AutoSize = true;
            this.labelfechan.Location = new System.Drawing.Point(47, 232);
            this.labelfechan.Name = "labelfechan";
            this.labelfechan.Size = new System.Drawing.Size(135, 16);
            this.labelfechan.TabIndex = 3;
            this.labelfechan.Text = "Fecha de Nacimiento";
            // 
            // textBoxdpi
            // 
            this.textBoxdpi.Location = new System.Drawing.Point(188, 52);
            this.textBoxdpi.Name = "textBoxdpi";
            this.textBoxdpi.Size = new System.Drawing.Size(200, 22);
            this.textBoxdpi.TabIndex = 4;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(188, 105);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(200, 22);
            this.textBoxnombre.TabIndex = 5;
            // 
            // textBoxape
            // 
            this.textBoxape.Location = new System.Drawing.Point(188, 164);
            this.textBoxape.Name = "textBoxape";
            this.textBoxape.Size = new System.Drawing.Size(200, 22);
            this.textBoxape.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(158, 377);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(137, 38);
            this.btningresar.TabIndex = 12;
            this.btningresar.Text = "Ingresar persona";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(447, 377);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(144, 38);
            this.btnmostrar.TabIndex = 13;
            this.btnmostrar.Text = "Mostrar Persona";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(547, 276);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(44, 16);
            this.labelEdad.TabIndex = 14;
            this.labelEdad.Text = "label5";
            // 
            // labelNombreNormalizado
            // 
            this.labelNombreNormalizado.AutoSize = true;
            this.labelNombreNormalizado.Location = new System.Drawing.Point(547, 315);
            this.labelNombreNormalizado.Name = "labelNombreNormalizado";
            this.labelNombreNormalizado.Size = new System.Drawing.Size(44, 16);
            this.labelNombreNormalizado.TabIndex = 15;
            this.labelNombreNormalizado.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 549);
            this.Controls.Add(this.labelNombreNormalizado);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxape);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxdpi);
            this.Controls.Add(this.labelfechan);
            this.Controls.Add(this.labelapellido);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labeldpi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldpi;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelapellido;
        private System.Windows.Forms.Label labelfechan;
        private System.Windows.Forms.TextBox textBoxdpi;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxape;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelNombreNormalizado;
    }
}


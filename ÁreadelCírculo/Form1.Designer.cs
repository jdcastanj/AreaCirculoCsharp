namespace ÁreadelCírculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtradio = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo del área de un círculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(72, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el radio del círculo";
            // 
            // txtradio
            // 
            this.txtradio.Location = new System.Drawing.Point(430, 141);
            this.txtradio.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(185, 39);
            this.txtradio.TabIndex = 2;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(675, 144);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(237, 150);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular área";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Área del círculo:";
            this.label3.Visible = false;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(320, 312);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(153, 32);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Visible = false;
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(675, 312);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(237, 150);
            this.btnborrar.TabIndex = 6;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Visible = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 720);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtradio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtradio;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnborrar;
    }
}


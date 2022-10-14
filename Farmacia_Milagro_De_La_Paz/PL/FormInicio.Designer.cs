
namespace Farmacia_Milagro_De_La_Paz.PL
{
    partial class FormInicio
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
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnMedicamentos = new System.Windows.Forms.Button();
            this.btnPapelería = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(111, 49);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(94, 50);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnMedicamentos
            // 
            this.btnMedicamentos.Location = new System.Drawing.Point(111, 121);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.Size = new System.Drawing.Size(94, 50);
            this.btnMedicamentos.TabIndex = 1;
            this.btnMedicamentos.Text = "Medicamentos";
            this.btnMedicamentos.UseVisualStyleBackColor = true;
            // 
            // btnPapelería
            // 
            this.btnPapelería.Location = new System.Drawing.Point(111, 194);
            this.btnPapelería.Name = "btnPapelería";
            this.btnPapelería.Size = new System.Drawing.Size(94, 50);
            this.btnPapelería.TabIndex = 2;
            this.btnPapelería.Text = "Papelería";
            this.btnPapelería.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 342);
            this.Controls.Add(this.btnPapelería);
            this.Controls.Add(this.btnMedicamentos);
            this.Controls.Add(this.btnEmpleados);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnMedicamentos;
        private System.Windows.Forms.Button btnPapelería;
    }
}
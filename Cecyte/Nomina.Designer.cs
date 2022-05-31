
namespace Cecyte
{
    partial class Nomina
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
            this.dgNominaExcel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.lbFfechaNomina = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeNomina = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNomina = new System.Windows.Forms.ComboBox();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgNominaExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNominaExcel
            // 
            this.dgNominaExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNominaExcel.Location = new System.Drawing.Point(12, 137);
            this.dgNominaExcel.Name = "dgNominaExcel";
            this.dgNominaExcel.Size = new System.Drawing.Size(776, 301);
            this.dgNominaExcel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nomina";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(609, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(713, 60);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 6;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lbFfechaNomina
            // 
            this.lbFfechaNomina.AutoSize = true;
            this.lbFfechaNomina.Location = new System.Drawing.Point(12, 105);
            this.lbFfechaNomina.Name = "lbFfechaNomina";
            this.lbFfechaNomina.Size = new System.Drawing.Size(76, 13);
            this.lbFfechaNomina.TabIndex = 7;
            this.lbFfechaNomina.Text = "Fecha Nomina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero Nomina";
            // 
            // dateTimeNomina
            // 
            this.dateTimeNomina.Location = new System.Drawing.Point(93, 101);
            this.dateTimeNomina.Name = "dateTimeNomina";
            this.dateTimeNomina.Size = new System.Drawing.Size(200, 20);
            this.dateTimeNomina.TabIndex = 9;
            // 
            // comboBoxNomina
            // 
            this.comboBoxNomina.FormattingEnabled = true;
            this.comboBoxNomina.Location = new System.Drawing.Point(397, 102);
            this.comboBoxNomina.Name = "comboBoxNomina";
            this.comboBoxNomina.Size = new System.Drawing.Size(77, 21);
            this.comboBoxNomina.TabIndex = 10;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(513, 100);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 11;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.comboBoxNomina);
            this.Controls.Add(this.dateTimeNomina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbFfechaNomina);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgNominaExcel);
            this.Name = "Nomina";
            this.Text = "Nomina";
            ((System.ComponentModel.ISupportInitialize)(this.dgNominaExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNominaExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label lbFfechaNomina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeNomina;
        private System.Windows.Forms.ComboBox comboBoxNomina;
        private System.Windows.Forms.Button btnReporte;
    }
}
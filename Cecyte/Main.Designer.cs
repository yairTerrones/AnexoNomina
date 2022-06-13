
namespace Cecyte
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.GridPuestos = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelSalarialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferencialSueldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoColectivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPeriodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejercicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridPuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anexo 2022";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(127, 92);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(305, 20);
            this.textBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(477, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(568, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.Location = new System.Drawing.Point(660, 88);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 5;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // GridPuestos
            // 
            this.GridPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPuestos.AutoGenerateColumns = false;
            this.GridPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.denominacionDataGridViewTextBoxColumn,
            this.zonaDataGridViewTextBoxColumn,
            this.nivelSalarialDataGridViewTextBoxColumn,
            this.plazasDataGridViewTextBoxColumn,
            this.horasDataGridViewTextBoxColumn,
            this.diferencialSueldoDataGridViewTextBoxColumn,
            this.costoColectivoDataGridViewTextBoxColumn,
            this.costoPeriodoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.ejercicioDataGridViewTextBoxColumn,
            this.Editar,
            this.Borrar});
            this.GridPuestos.DataSource = this.puestosBindingSource;
            this.GridPuestos.Location = new System.Drawing.Point(46, 166);
            this.GridPuestos.Name = "GridPuestos";
            this.GridPuestos.Size = new System.Drawing.Size(699, 272);
            this.GridPuestos.TabIndex = 6;
            this.GridPuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPuestos_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseColumnTextForLinkValue = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // denominacionDataGridViewTextBoxColumn
            // 
            this.denominacionDataGridViewTextBoxColumn.DataPropertyName = "Denominacion";
            this.denominacionDataGridViewTextBoxColumn.HeaderText = "Denominacion";
            this.denominacionDataGridViewTextBoxColumn.Name = "denominacionDataGridViewTextBoxColumn";
            // 
            // zonaDataGridViewTextBoxColumn
            // 
            this.zonaDataGridViewTextBoxColumn.DataPropertyName = "Zona";
            this.zonaDataGridViewTextBoxColumn.HeaderText = "Zona";
            this.zonaDataGridViewTextBoxColumn.Name = "zonaDataGridViewTextBoxColumn";
            // 
            // nivelSalarialDataGridViewTextBoxColumn
            // 
            this.nivelSalarialDataGridViewTextBoxColumn.DataPropertyName = "NivelSalarial";
            this.nivelSalarialDataGridViewTextBoxColumn.HeaderText = "NivelSalarial";
            this.nivelSalarialDataGridViewTextBoxColumn.Name = "nivelSalarialDataGridViewTextBoxColumn";
            // 
            // plazasDataGridViewTextBoxColumn
            // 
            this.plazasDataGridViewTextBoxColumn.DataPropertyName = "Plazas";
            this.plazasDataGridViewTextBoxColumn.HeaderText = "Plazas";
            this.plazasDataGridViewTextBoxColumn.Name = "plazasDataGridViewTextBoxColumn";
            // 
            // horasDataGridViewTextBoxColumn
            // 
            this.horasDataGridViewTextBoxColumn.DataPropertyName = "Horas";
            this.horasDataGridViewTextBoxColumn.HeaderText = "Horas";
            this.horasDataGridViewTextBoxColumn.Name = "horasDataGridViewTextBoxColumn";
            // 
            // diferencialSueldoDataGridViewTextBoxColumn
            // 
            this.diferencialSueldoDataGridViewTextBoxColumn.DataPropertyName = "DiferencialSueldo";
            this.diferencialSueldoDataGridViewTextBoxColumn.HeaderText = "DiferencialSueldo";
            this.diferencialSueldoDataGridViewTextBoxColumn.Name = "diferencialSueldoDataGridViewTextBoxColumn";
            // 
            // costoColectivoDataGridViewTextBoxColumn
            // 
            this.costoColectivoDataGridViewTextBoxColumn.DataPropertyName = "CostoColectivo";
            this.costoColectivoDataGridViewTextBoxColumn.HeaderText = "CostoColectivo";
            this.costoColectivoDataGridViewTextBoxColumn.Name = "costoColectivoDataGridViewTextBoxColumn";
            // 
            // costoPeriodoDataGridViewTextBoxColumn
            // 
            this.costoPeriodoDataGridViewTextBoxColumn.DataPropertyName = "CostoPeriodo";
            this.costoPeriodoDataGridViewTextBoxColumn.HeaderText = "CostoPeriodo";
            this.costoPeriodoDataGridViewTextBoxColumn.Name = "costoPeriodoDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // ejercicioDataGridViewTextBoxColumn
            // 
            this.ejercicioDataGridViewTextBoxColumn.DataPropertyName = "Ejercicio";
            this.ejercicioDataGridViewTextBoxColumn.HeaderText = "Ejercicio";
            this.ejercicioDataGridViewTextBoxColumn.Name = "ejercicioDataGridViewTextBoxColumn";
            // 
            // puestosBindingSource
            // 
            this.puestosBindingSource.DataSource = typeof(Cecyte.Puestos);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridPuestos);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anexo";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridView GridPuestos;
        private System.Windows.Forms.BindingSource puestosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelSalarialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diferencialSueldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoColectivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPeriodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejercicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Borrar;
    }
}


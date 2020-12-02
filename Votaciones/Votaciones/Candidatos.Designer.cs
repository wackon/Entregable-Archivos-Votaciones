namespace Votaciones
{
    partial class Candidatos
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
            this.txMen = new System.Windows.Forms.Label();
            this.txValorVoto = new System.Windows.Forms.TextBox();
            this.btVotar = new System.Windows.Forms.Button();
            this.eLEJIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cANDIDATOSDataSet = new Votaciones.CANDIDATOSDataSet();
            this.eLEJIDOSTableAdapter = new Votaciones.CANDIDATOSDataSetTableAdapters.ELEJIDOSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cANDIDATOSDataSet2 = new Votaciones.CANDIDATOSDataSet2();
            this.eLEJIDOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eLEJIDOSTableAdapter1 = new Votaciones.CANDIDATOSDataSet2TableAdapters.ELEJIDOSTableAdapter();
            this.nUMEROTARJETONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eLEJIDOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATOSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEJIDOSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txMen
            // 
            this.txMen.AutoSize = true;
            this.txMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMen.Location = new System.Drawing.Point(110, 568);
            this.txMen.Name = "txMen";
            this.txMen.Size = new System.Drawing.Size(0, 16);
            this.txMen.TabIndex = 7;
            // 
            // txValorVoto
            // 
            this.txValorVoto.Location = new System.Drawing.Point(434, 484);
            this.txValorVoto.Name = "txValorVoto";
            this.txValorVoto.Size = new System.Drawing.Size(105, 20);
            this.txValorVoto.TabIndex = 6;
            // 
            // btVotar
            // 
            this.btVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVotar.Location = new System.Drawing.Point(329, 522);
            this.btVotar.Name = "btVotar";
            this.btVotar.Size = new System.Drawing.Size(107, 30);
            this.btVotar.TabIndex = 5;
            this.btVotar.Text = "Votar";
            this.btVotar.UseVisualStyleBackColor = true;
            this.btVotar.Click += new System.EventHandler(this.btVotar_Click);
            // 
            // eLEJIDOSBindingSource
            // 
            this.eLEJIDOSBindingSource.DataMember = "ELEJIDOS";
            this.eLEJIDOSBindingSource.DataSource = this.cANDIDATOSDataSet;
            // 
            // cANDIDATOSDataSet
            // 
            this.cANDIDATOSDataSet.DataSetName = "CANDIDATOSDataSet";
            this.cANDIDATOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eLEJIDOSTableAdapter
            // 
            this.eLEJIDOSTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese el número del tarjeton para realizar la votacion:";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(113, 522);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(125, 30);
            this.btLimpiar.TabIndex = 9;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMEROTARJETONDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.pARTIDODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eLEJIDOSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(36, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 373);
            this.dataGridView1.TabIndex = 10;
            // 
            // cANDIDATOSDataSet2
            // 
            this.cANDIDATOSDataSet2.DataSetName = "CANDIDATOSDataSet2";
            this.cANDIDATOSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eLEJIDOSBindingSource1
            // 
            this.eLEJIDOSBindingSource1.DataMember = "ELEJIDOS";
            this.eLEJIDOSBindingSource1.DataSource = this.cANDIDATOSDataSet2;
            // 
            // eLEJIDOSTableAdapter1
            // 
            this.eLEJIDOSTableAdapter1.ClearBeforeFill = true;
            // 
            // nUMEROTARJETONDataGridViewTextBoxColumn
            // 
            this.nUMEROTARJETONDataGridViewTextBoxColumn.DataPropertyName = "NUMEROTARJETON";
            this.nUMEROTARJETONDataGridViewTextBoxColumn.HeaderText = "NUMEROTARJETON";
            this.nUMEROTARJETONDataGridViewTextBoxColumn.Name = "nUMEROTARJETONDataGridViewTextBoxColumn";
            this.nUMEROTARJETONDataGridViewTextBoxColumn.Width = 150;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.Width = 150;
            // 
            // pARTIDODataGridViewTextBoxColumn
            // 
            this.pARTIDODataGridViewTextBoxColumn.DataPropertyName = "PARTIDO";
            this.pARTIDODataGridViewTextBoxColumn.HeaderText = "PARTIDO";
            this.pARTIDODataGridViewTextBoxColumn.Name = "pARTIDODataGridViewTextBoxColumn";
            this.pARTIDODataGridViewTextBoxColumn.Width = 150;
            // 
            // Candidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 595);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txMen);
            this.Controls.Add(this.txValorVoto);
            this.Controls.Add(this.btVotar);
            this.Name = "Candidatos";
            this.Text = "Candidatos";
            this.Load += new System.EventHandler(this.Candidatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eLEJIDOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATOSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEJIDOSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txMen;
        private System.Windows.Forms.TextBox txValorVoto;
        private System.Windows.Forms.Button btVotar;
        private CANDIDATOSDataSet cANDIDATOSDataSet;
        private System.Windows.Forms.BindingSource eLEJIDOSBindingSource;
        private CANDIDATOSDataSetTableAdapters.ELEJIDOSTableAdapter eLEJIDOSTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CANDIDATOSDataSet2 cANDIDATOSDataSet2;
        private System.Windows.Forms.BindingSource eLEJIDOSBindingSource1;
        private CANDIDATOSDataSet2TableAdapters.ELEJIDOSTableAdapter eLEJIDOSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROTARJETONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTIDODataGridViewTextBoxColumn;
    }
}
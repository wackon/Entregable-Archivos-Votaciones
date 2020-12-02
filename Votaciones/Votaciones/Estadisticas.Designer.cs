namespace Votaciones
{
    partial class Estadisticas
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
            this.candidatoVotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cANDIDATOSDataSet1 = new Votaciones.CANDIDATOSDataSet1();
            this.candidato_VotosTableAdapter = new Votaciones.CANDIDATOSDataSet1TableAdapters.Candidato_VotosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txVerde = new System.Windows.Forms.TextBox();
            this.txRojo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txNaranja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txAzul = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txGris = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btGanador = new System.Windows.Forms.Button();
            this.txSalida = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cANDIDATOSDataSet3 = new Votaciones.CANDIDATOSDataSet3();
            this.candidatoVotosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.candidato_VotosTableAdapter1 = new Votaciones.CANDIDATOSDataSet3TableAdapters.Candidato_VotosTableAdapter();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADVOTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoVotosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATOSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoVotosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // candidatoVotosBindingSource
            // 
            this.candidatoVotosBindingSource.DataMember = "Candidato-Votos";
            this.candidatoVotosBindingSource.DataSource = this.cANDIDATOSDataSet1;
            // 
            // cANDIDATOSDataSet1
            // 
            this.cANDIDATOSDataSet1.DataSetName = "CANDIDATOSDataSet1";
            this.cANDIDATOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidato_VotosTableAdapter
            // 
            this.candidato_VotosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Votos por Candidato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verde";
            // 
            // txVerde
            // 
            this.txVerde.Location = new System.Drawing.Point(579, 66);
            this.txVerde.Name = "txVerde";
            this.txVerde.Size = new System.Drawing.Size(100, 20);
            this.txVerde.TabIndex = 3;
            this.txVerde.TextChanged += new System.EventHandler(this.txVerde_TextChanged);
            // 
            // txRojo
            // 
            this.txRojo.Location = new System.Drawing.Point(579, 104);
            this.txRojo.Name = "txRojo";
            this.txRojo.Size = new System.Drawing.Size(100, 20);
            this.txRojo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rojo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txNaranja
            // 
            this.txNaranja.Location = new System.Drawing.Point(579, 146);
            this.txNaranja.Name = "txNaranja";
            this.txNaranja.Size = new System.Drawing.Size(100, 20);
            this.txNaranja.TabIndex = 7;
            this.txNaranja.TextChanged += new System.EventHandler(this.txNaranja_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Naranja";
            // 
            // txAzul
            // 
            this.txAzul.Location = new System.Drawing.Point(579, 193);
            this.txAzul.Name = "txAzul";
            this.txAzul.Size = new System.Drawing.Size(100, 20);
            this.txAzul.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Azul";
            // 
            // txGris
            // 
            this.txGris.Location = new System.Drawing.Point(579, 236);
            this.txGris.Name = "txGris";
            this.txGris.Size = new System.Drawing.Size(100, 20);
            this.txGris.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gris";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(549, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Votos por Partido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad de Votos por partido";
            // 
            // btGanador
            // 
            this.btGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGanador.Location = new System.Drawing.Point(225, 378);
            this.btGanador.Name = "btGanador";
            this.btGanador.Size = new System.Drawing.Size(160, 36);
            this.btGanador.TabIndex = 14;
            this.btGanador.Text = "Ganador";
            this.btGanador.UseVisualStyleBackColor = true;
            this.btGanador.Click += new System.EventHandler(this.button2_Click);
            // 
            // txSalida
            // 
            this.txSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSalida.Location = new System.Drawing.Point(465, 368);
            this.txSalida.Multiline = true;
            this.txSalida.Name = "txSalida";
            this.txSalida.Size = new System.Drawing.Size(271, 58);
            this.txSalida.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBREDataGridViewTextBoxColumn,
            this.cANTIDADVOTOSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.candidatoVotosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(58, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 240);
            this.dataGridView1.TabIndex = 16;
            // 
            // cANDIDATOSDataSet3
            // 
            this.cANDIDATOSDataSet3.DataSetName = "CANDIDATOSDataSet3";
            this.cANDIDATOSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatoVotosBindingSource1
            // 
            this.candidatoVotosBindingSource1.DataMember = "Candidato-Votos";
            this.candidatoVotosBindingSource1.DataSource = this.cANDIDATOSDataSet3;
            // 
            // candidato_VotosTableAdapter1
            // 
            this.candidato_VotosTableAdapter1.ClearBeforeFill = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.Width = 150;
            // 
            // cANTIDADVOTOSDataGridViewTextBoxColumn
            // 
            this.cANTIDADVOTOSDataGridViewTextBoxColumn.DataPropertyName = "CANTIDADVOTOS";
            this.cANTIDADVOTOSDataGridViewTextBoxColumn.HeaderText = "CANTIDADVOTOS";
            this.cANTIDADVOTOSDataGridViewTextBoxColumn.Name = "cANTIDADVOTOSDataGridViewTextBoxColumn";
            this.cANTIDADVOTOSDataGridViewTextBoxColumn.Width = 150;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txSalida);
            this.Controls.Add(this.btGanador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txGris);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txAzul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txNaranja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txRojo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txVerde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidatoVotosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANDIDATOSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoVotosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CANDIDATOSDataSet1 cANDIDATOSDataSet1;
        private System.Windows.Forms.BindingSource candidatoVotosBindingSource;
        private CANDIDATOSDataSet1TableAdapters.Candidato_VotosTableAdapter candidato_VotosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txVerde;
        private System.Windows.Forms.TextBox txRojo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNaranja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txAzul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txGris;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btGanador;
        private System.Windows.Forms.TextBox txSalida;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CANDIDATOSDataSet3 cANDIDATOSDataSet3;
        private System.Windows.Forms.BindingSource candidatoVotosBindingSource1;
        private CANDIDATOSDataSet3TableAdapters.Candidato_VotosTableAdapter candidato_VotosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADVOTOSDataGridViewTextBoxColumn;
    }
}
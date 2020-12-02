namespace Votaciones
{
    partial class Logueo
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
            this.txSalida = new System.Windows.Forms.TextBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btIngresar = new System.Windows.Forms.Button();
            this.Cedula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txCedula = new System.Windows.Forms.TextBox();
            this.txNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txSalida
            // 
            this.txSalida.Location = new System.Drawing.Point(33, 201);
            this.txSalida.Multiline = true;
            this.txSalida.Name = "txSalida";
            this.txSalida.Size = new System.Drawing.Size(329, 128);
            this.txSalida.TabIndex = 19;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(192, 132);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 18;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btIngresar
            // 
            this.btIngresar.Location = new System.Drawing.Point(67, 132);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(75, 23);
            this.btIngresar.TabIndex = 17;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // Cedula
            // 
            this.Cedula.AutoSize = true;
            this.Cedula.Location = new System.Drawing.Point(43, 74);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(101, 13);
            this.Cedula.TabIndex = 16;
            this.Cedula.Text = "Número de Cedula :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre : ";
            // 
            // txCedula
            // 
            this.txCedula.Location = new System.Drawing.Point(158, 68);
            this.txCedula.Name = "txCedula";
            this.txCedula.PasswordChar = '*';
            this.txCedula.Size = new System.Drawing.Size(100, 20);
            this.txCedula.TabIndex = 14;
            // 
            // txNom
            // 
            this.txNom.Location = new System.Drawing.Point(158, 29);
            this.txNom.Name = "txNom";
            this.txNom.Size = new System.Drawing.Size(100, 20);
            this.txNom.TabIndex = 13;
            // 
            // Logueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 352);
            this.Controls.Add(this.txSalida);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCedula);
            this.Controls.Add(this.txNom);
            this.Name = "Logueo";
            this.Text = "Logueo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txSalida;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Label Cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCedula;
        private System.Windows.Forms.TextBox txNom;
    }
}
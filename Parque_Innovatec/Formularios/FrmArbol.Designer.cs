namespace Parque_Innovatec.Formularios
{
    partial class FrmArbol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRaiz = new System.Windows.Forms.TextBox();
            this.tbNodoHijo = new System.Windows.Forms.TextBox();
            this.tbBuscarRama = new System.Windows.Forms.TextBox();
            this.btnAgregarRaiz = new System.Windows.Forms.Button();
            this.btnAgregarRama = new System.Windows.Forms.Button();
            this.btnBuscarRama = new System.Windows.Forms.Button();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblConteoRamas = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRecorrer = new System.Windows.Forms.ComboBox();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lbRecorrido = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvArbol);
            this.groupBox1.Controls.Add(this.btnBuscarRama);
            this.groupBox1.Controls.Add(this.btnAgregarRama);
            this.groupBox1.Controls.Add(this.btnAgregarRaiz);
            this.groupBox1.Controls.Add(this.tbBuscarRama);
            this.groupBox1.Controls.Add(this.tbNodoHijo);
            this.groupBox1.Controls.Add(this.tbRaiz);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jerarquización";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nodo Principal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Buscar Rama:";
            // 
            // tbRaiz
            // 
            this.tbRaiz.Location = new System.Drawing.Point(140, 25);
            this.tbRaiz.Name = "tbRaiz";
            this.tbRaiz.Size = new System.Drawing.Size(114, 22);
            this.tbRaiz.TabIndex = 3;
            // 
            // tbNodoHijo
            // 
            this.tbNodoHijo.Location = new System.Drawing.Point(140, 58);
            this.tbNodoHijo.Name = "tbNodoHijo";
            this.tbNodoHijo.Size = new System.Drawing.Size(114, 22);
            this.tbNodoHijo.TabIndex = 4;
            // 
            // tbBuscarRama
            // 
            this.tbBuscarRama.Location = new System.Drawing.Point(140, 90);
            this.tbBuscarRama.Name = "tbBuscarRama";
            this.tbBuscarRama.Size = new System.Drawing.Size(114, 22);
            this.tbBuscarRama.TabIndex = 5;
            // 
            // btnAgregarRaiz
            // 
            this.btnAgregarRaiz.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRaiz.Location = new System.Drawing.Point(260, 23);
            this.btnAgregarRaiz.Name = "btnAgregarRaiz";
            this.btnAgregarRaiz.Size = new System.Drawing.Size(97, 23);
            this.btnAgregarRaiz.TabIndex = 6;
            this.btnAgregarRaiz.Text = "Agregar Raíz";
            this.btnAgregarRaiz.UseVisualStyleBackColor = true;
            this.btnAgregarRaiz.Click += new System.EventHandler(this.btnAgregarRaiz_Click);
            // 
            // btnAgregarRama
            // 
            this.btnAgregarRama.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRama.Location = new System.Drawing.Point(260, 56);
            this.btnAgregarRama.Name = "btnAgregarRama";
            this.btnAgregarRama.Size = new System.Drawing.Size(97, 23);
            this.btnAgregarRama.TabIndex = 7;
            this.btnAgregarRama.Text = "Agregar Rama";
            this.btnAgregarRama.UseVisualStyleBackColor = true;
            this.btnAgregarRama.Click += new System.EventHandler(this.btnAgregarRama_Click);
            // 
            // btnBuscarRama
            // 
            this.btnBuscarRama.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRama.Location = new System.Drawing.Point(260, 88);
            this.btnBuscarRama.Name = "btnBuscarRama";
            this.btnBuscarRama.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarRama.TabIndex = 8;
            this.btnBuscarRama.Text = "Buscar Rama";
            this.btnBuscarRama.UseVisualStyleBackColor = true;
            // 
            // tvArbol
            // 
            this.tvArbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tvArbol.Location = new System.Drawing.Point(76, 128);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(216, 365);
            this.tvArbol.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblConteoRamas);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(397, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 56);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conteo";
            // 
            // lblConteoRamas
            // 
            this.lblConteoRamas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteoRamas.Location = new System.Drawing.Point(6, 17);
            this.lblConteoRamas.Name = "lblConteoRamas";
            this.lblConteoRamas.Size = new System.Drawing.Size(357, 23);
            this.lblConteoRamas.TabIndex = 0;
            this.lblConteoRamas.Text = "Ramas: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbRecorrido);
            this.groupBox3.Controls.Add(this.btnRecorrer);
            this.groupBox3.Controls.Add(this.cbRecorrer);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(397, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 445);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recorrido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Recorrido:";
            // 
            // cbRecorrer
            // 
            this.cbRecorrer.FormattingEnabled = true;
            this.cbRecorrer.Location = new System.Drawing.Point(102, 18);
            this.cbRecorrer.Name = "cbRecorrer";
            this.cbRecorrer.Size = new System.Drawing.Size(121, 24);
            this.cbRecorrer.TabIndex = 2;
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrer.Location = new System.Drawing.Point(229, 12);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(133, 31);
            this.btnRecorrer.TabIndex = 3;
            this.btnRecorrer.Text = "Recorrer Árbol";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            // 
            // lbRecorrido
            // 
            this.lbRecorrido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbRecorrido.FormattingEnabled = true;
            this.lbRecorrido.ItemHeight = 16;
            this.lbRecorrido.Location = new System.Drawing.Point(10, 62);
            this.lbRecorrido.Name = "lbRecorrido";
            this.lbRecorrido.Size = new System.Drawing.Size(352, 372);
            this.lbRecorrido.TabIndex = 4;
            // 
            // FrmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(782, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNodo;
        private System.Windows.Forms.TreeView tvJerarquia;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNodoHijo;
        private System.Windows.Forms.TextBox tbRaiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarRaiz;
        private System.Windows.Forms.TextBox tbBuscarRama;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.Button btnBuscarRama;
        private System.Windows.Forms.Button btnAgregarRama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblConteoRamas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbRecorrer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbRecorrido;
        private System.Windows.Forms.Button btnRecorrer;
    }
}
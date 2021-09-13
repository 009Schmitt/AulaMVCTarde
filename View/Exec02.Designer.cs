
namespace AULAMVC01Tarde.View
{
    partial class Exec02
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
            this.dgVagas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntradaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPlacas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.txtHrSaida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVagas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHrEntrada = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnEncerra = new System.Windows.Forms.Button();
            this.dgTeste01 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTeste = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeste01)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVagas
            // 
            this.dgVagas.AllowUserToAddRows = false;
            this.dgVagas.AllowUserToDeleteRows = false;
            this.dgVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PlacaCol,
            this.HoraEntradaCol});
            this.dgVagas.Location = new System.Drawing.Point(12, 12);
            this.dgVagas.Name = "dgVagas";
            this.dgVagas.ReadOnly = true;
            this.dgVagas.RowTemplate.Height = 50;
            this.dgVagas.Size = new System.Drawing.Size(760, 250);
            this.dgVagas.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "Vaga";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // PlacaCol
            // 
            this.PlacaCol.HeaderText = "Placa";
            this.PlacaCol.Name = "PlacaCol";
            this.PlacaCol.ReadOnly = true;
            this.PlacaCol.Width = 200;
            // 
            // HoraEntradaCol
            // 
            this.HoraEntradaCol.HeaderText = "HoraEntrada";
            this.HoraEntradaCol.Name = "HoraEntradaCol";
            this.HoraEntradaCol.ReadOnly = true;
            this.HoraEntradaCol.Width = 250;
            // 
            // cbPlacas
            // 
            this.cbPlacas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlacas.FormattingEnabled = true;
            this.cbPlacas.Location = new System.Drawing.Point(12, 307);
            this.cbPlacas.Name = "cbPlacas";
            this.cbPlacas.Size = new System.Drawing.Size(245, 47);
            this.cbPlacas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placas";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(284, 307);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 226);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lavou?";
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(133, 386);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(58, 43);
            this.rbSim.TabIndex = 5;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "S";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(197, 386);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(60, 43);
            this.rbNao.TabIndex = 6;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "N";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // txtHrSaida
            // 
            this.txtHrSaida.Location = new System.Drawing.Point(12, 496);
            this.txtHrSaida.Name = "txtHrSaida";
            this.txtHrSaida.Size = new System.Drawing.Size(245, 47);
            this.txtHrSaida.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora De Saida";
            // 
            // cbVagas
            // 
            this.cbVagas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVagas.FormattingEnabled = true;
            this.cbVagas.Location = new System.Drawing.Point(364, 307);
            this.cbVagas.Name = "cbVagas";
            this.cbVagas.Size = new System.Drawing.Size(235, 47);
            this.cbVagas.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vagas Livres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(364, 404);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(235, 47);
            this.txtPlaca.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hora Entrada";
            // 
            // txtHrEntrada
            // 
            this.txtHrEntrada.Location = new System.Drawing.Point(364, 496);
            this.txtHrEntrada.Name = "txtHrEntrada";
            this.txtHrEntrada.Size = new System.Drawing.Size(235, 47);
            this.txtHrEntrada.TabIndex = 14;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(614, 307);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(56, 236);
            this.btnEntrar.TabIndex = 15;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnEncerra
            // 
            this.btnEncerra.BackColor = System.Drawing.Color.Crimson;
            this.btnEncerra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerra.Location = new System.Drawing.Point(711, 271);
            this.btnEncerra.Name = "btnEncerra";
            this.btnEncerra.Size = new System.Drawing.Size(61, 278);
            this.btnEncerra.TabIndex = 16;
            this.btnEncerra.Text = "ENCERRA";
            this.btnEncerra.UseVisualStyleBackColor = false;
            this.btnEncerra.Click += new System.EventHandler(this.btnEncerra_Click);
            // 
            // dgTeste01
            // 
            this.dgTeste01.AllowUserToAddRows = false;
            this.dgTeste01.AllowUserToDeleteRows = false;
            this.dgTeste01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeste01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgTeste01.Location = new System.Drawing.Point(778, 12);
            this.dgTeste01.Name = "dgTeste01";
            this.dgTeste01.ReadOnly = true;
            this.dgTeste01.RowTemplate.Height = 50;
            this.dgTeste01.Size = new System.Drawing.Size(454, 415);
            this.dgTeste01.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Vaga";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "HoraEntrada";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(966, 440);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(36, 39);
            this.lblTeste.TabIndex = 18;
            this.lblTeste.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(872, 494);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 49);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(987, 494);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 49);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Rem";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 561);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTeste);
            this.Controls.Add(this.dgTeste01);
            this.Controls.Add(this.btnEncerra);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtHrEntrada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbVagas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHrSaida);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPlacas);
            this.Controls.Add(this.dgVagas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Exec02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec02";
            this.Load += new System.EventHandler(this.Exec02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeste01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVagas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntradaCol;
        private System.Windows.Forms.ComboBox cbPlacas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.TextBox txtHrSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVagas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHrEntrada;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnEncerra;
        private System.Windows.Forms.DataGridView dgTeste01;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}

namespace AULAMVC01Tarde.View
{
    partial class AulaTabela
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkVip = new System.Windows.Forms.CheckBox();
            this.rbPessoa = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbFuncionario = new System.Windows.Forms.RadioButton();
            this.btnExecuta = new System.Windows.Forms.Button();
            this.btnConfere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(149, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(266, 47);
            this.txtNome.TabIndex = 0;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(149, 76);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(266, 47);
            this.txtCpf.TabIndex = 1;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(149, 143);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(266, 47);
            this.txtRg.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(149, 206);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(266, 47);
            this.txtSalario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario";
            // 
            // checkVip
            // 
            this.checkVip.AutoSize = true;
            this.checkVip.Location = new System.Drawing.Point(149, 271);
            this.checkVip.Name = "checkVip";
            this.checkVip.Size = new System.Drawing.Size(91, 43);
            this.checkVip.TabIndex = 8;
            this.checkVip.Text = "VIP";
            this.checkVip.UseVisualStyleBackColor = true;
            // 
            // rbPessoa
            // 
            this.rbPessoa.AutoSize = true;
            this.rbPessoa.Location = new System.Drawing.Point(462, 48);
            this.rbPessoa.Name = "rbPessoa";
            this.rbPessoa.Size = new System.Drawing.Size(151, 43);
            this.rbPessoa.TabIndex = 9;
            this.rbPessoa.TabStop = true;
            this.rbPessoa.Text = "Pessoa";
            this.rbPessoa.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(462, 115);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(143, 43);
            this.rbCliente.TabIndex = 10;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbFuncionario
            // 
            this.rbFuncionario.AutoSize = true;
            this.rbFuncionario.Location = new System.Drawing.Point(462, 181);
            this.rbFuncionario.Name = "rbFuncionario";
            this.rbFuncionario.Size = new System.Drawing.Size(216, 43);
            this.rbFuncionario.TabIndex = 11;
            this.rbFuncionario.TabStop = true;
            this.rbFuncionario.Text = "Funcionario";
            this.rbFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnExecuta
            // 
            this.btnExecuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecuta.Location = new System.Drawing.Point(12, 320);
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Size = new System.Drawing.Size(372, 229);
            this.btnExecuta.TabIndex = 12;
            this.btnExecuta.Text = "Executa";
            this.btnExecuta.UseVisualStyleBackColor = true;
            this.btnExecuta.Click += new System.EventHandler(this.btnExecuta_Click);
            // 
            // btnConfere
            // 
            this.btnConfere.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfere.Location = new System.Drawing.Point(404, 320);
            this.btnConfere.Name = "btnConfere";
            this.btnConfere.Size = new System.Drawing.Size(368, 229);
            this.btnConfere.TabIndex = 13;
            this.btnConfere.Text = "Confere";
            this.btnConfere.UseVisualStyleBackColor = true;
            this.btnConfere.Click += new System.EventHandler(this.btnConfere_Click);
            // 
            // AulaTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnConfere);
            this.Controls.Add(this.btnExecuta);
            this.Controls.Add(this.rbFuncionario);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.rbPessoa);
            this.Controls.Add(this.checkVip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "AulaTabela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AulaTabela";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AulaTabela_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkVip;
        private System.Windows.Forms.RadioButton rbPessoa;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbFuncionario;
        private System.Windows.Forms.Button btnExecuta;
        private System.Windows.Forms.Button btnConfere;
    }
}
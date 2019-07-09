namespace Apresentacao
{
    partial class FormConsultaEdit
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
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.dateTimeConsulta = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPagamento = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdClienteConsulta = new System.Windows.Forms.TextBox();
            this.txtIdVeterinario = new System.Windows.Forms.TextBox();
            this.txtIdAnimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.bntExcluirCarrinho = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Location = new System.Drawing.Point(41, 262);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.Size = new System.Drawing.Size(366, 115);
            this.dgvMedicamentos.TabIndex = 68;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(605, 395);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(108, 20);
            this.txtValorTotal.TabIndex = 67;
            // 
            // dateTimeConsulta
            // 
            this.dateTimeConsulta.CustomFormat = "dd-MM-yyyy";
            this.dateTimeConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeConsulta.Location = new System.Drawing.Point(117, 103);
            this.dateTimeConsulta.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimeConsulta.Name = "dateTimeConsulta";
            this.dateTimeConsulta.Size = new System.Drawing.Size(101, 20);
            this.dateTimeConsulta.TabIndex = 66;
            this.dateTimeConsulta.Value = new System.DateTime(2019, 6, 30, 16, 59, 4, 0);
            // 
            // comboBoxPagamento
            // 
            this.comboBoxPagamento.FormattingEnabled = true;
            this.comboBoxPagamento.Location = new System.Drawing.Point(351, 104);
            this.comboBoxPagamento.Name = "comboBoxPagamento";
            this.comboBoxPagamento.Size = new System.Drawing.Size(131, 21);
            this.comboBoxPagamento.TabIndex = 65;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(577, 63);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(115, 21);
            this.comboBoxStatus.TabIndex = 64;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(36, 154);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 62;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(39, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(697, 2);
            this.label4.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "StatusPagamento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(538, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Valor Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Data Consulta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Status Consulta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "ID Veterinario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "ID Animal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Alef", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 37);
            this.label6.TabIndex = 57;
            this.label6.Text = "Editar Consulta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "ID Cliente:";
            // 
            // txtIdClienteConsulta
            // 
            this.txtIdClienteConsulta.Location = new System.Drawing.Point(98, 67);
            this.txtIdClienteConsulta.Name = "txtIdClienteConsulta";
            this.txtIdClienteConsulta.Size = new System.Drawing.Size(66, 20);
            this.txtIdClienteConsulta.TabIndex = 46;
            // 
            // txtIdVeterinario
            // 
            this.txtIdVeterinario.Location = new System.Drawing.Point(254, 66);
            this.txtIdVeterinario.Name = "txtIdVeterinario";
            this.txtIdVeterinario.Size = new System.Drawing.Size(64, 20);
            this.txtIdVeterinario.TabIndex = 69;
            // 
            // txtIdAnimal
            // 
            this.txtIdAnimal.Location = new System.Drawing.Point(392, 66);
            this.txtIdAnimal.Name = "txtIdAnimal";
            this.txtIdAnimal.Size = new System.Drawing.Size(81, 20);
            this.txtIdAnimal.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alef", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "Medicamentos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "Selecione:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 72;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Location = new System.Drawing.Point(447, 262);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.Size = new System.Drawing.Size(499, 115);
            this.dgvCarrinho.TabIndex = 73;
            // 
            // bntExcluirCarrinho
            // 
            this.bntExcluirCarrinho.Location = new System.Drawing.Point(447, 394);
            this.bntExcluirCarrinho.Name = "bntExcluirCarrinho";
            this.bntExcluirCarrinho.Size = new System.Drawing.Size(75, 23);
            this.bntExcluirCarrinho.TabIndex = 74;
            this.bntExcluirCarrinho.Text = "Excluir";
            this.bntExcluirCarrinho.UseVisualStyleBackColor = true;
            this.bntExcluirCarrinho.Click += new System.EventHandler(this.bntExcluirCarrinho_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(135, 399);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(203, 396);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(63, 20);
            this.txtQuantidade.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Alef", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(440, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 37);
            this.label14.TabIndex = 57;
            this.label14.Text = "Carrinho:";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(447, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(366, 2);
            this.label15.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(41, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 2);
            this.label2.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 77;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(43, 440);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(809, 2);
            this.label16.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(503, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 80;
            this.label17.Text = "Observacao:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(577, 103);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(251, 63);
            this.txtObservacao.TabIndex = 79;
            // 
            // FormConsultaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 509);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bntExcluirCarrinho);
            this.Controls.Add(this.dgvCarrinho);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIdAnimal);
            this.Controls.Add(this.txtIdVeterinario);
            this.Controls.Add(this.dgvMedicamentos);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.dateTimeConsulta);
            this.Controls.Add(this.comboBoxPagamento);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdClienteConsulta);
            this.Name = "FormConsultaEdit";
            this.Text = "FormConsultaEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.DateTimePicker dateTimeConsulta;
        private System.Windows.Forms.ComboBox comboBoxPagamento;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdClienteConsulta;
        private System.Windows.Forms.TextBox txtIdVeterinario;
        private System.Windows.Forms.TextBox txtIdAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Button bntExcluirCarrinho;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtObservacao;
    }
}
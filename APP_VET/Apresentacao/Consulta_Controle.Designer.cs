namespace Apresentacao
{
    partial class Consulta_Controle
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Controle));
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.btnBuscarData = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataFiltroConsulta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(75)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(13, 415);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 35);
            this.btnEditar.TabIndex = 78;
            this.btnEditar.Text = "EDITAR OU VISUALIZAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(13, 46);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(636, 363);
            this.dgvConsultas.TabIndex = 75;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LightGray;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(593, 12);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(56, 26);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtualizar.TabIndex = 73;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscarData
            // 
            this.btnBuscarData.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscarData.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarData.Image")));
            this.btnBuscarData.Location = new System.Drawing.Point(533, 12);
            this.btnBuscarData.Name = "btnBuscarData";
            this.btnBuscarData.Size = new System.Drawing.Size(55, 26);
            this.btnBuscarData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarData.TabIndex = 74;
            this.btnBuscarData.TabStop = false;
            this.btnBuscarData.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(163, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(114, 26);
            this.txtId.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 36);
            this.label2.TabIndex = 71;
            this.label2.Text = "ID consulta:";
            // 
            // dataFiltroConsulta
            // 
            this.dataFiltroConsulta.CustomFormat = "dd/MM/yyyy";
            this.dataFiltroConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataFiltroConsulta.Location = new System.Drawing.Point(428, 15);
            this.dataFiltroConsulta.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dataFiltroConsulta.Name = "dataFiltroConsulta";
            this.dataFiltroConsulta.Size = new System.Drawing.Size(99, 20);
            this.dataFiltroConsulta.TabIndex = 80;
            this.dataFiltroConsulta.Value = new System.DateTime(2019, 7, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 36);
            this.label3.TabIndex = 71;
            this.label3.Text = "Data:";
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscarPorId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarPorId.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorId.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPorId.Image")));
            this.btnBuscarPorId.Location = new System.Drawing.Point(286, 12);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(55, 26);
            this.btnBuscarPorId.TabIndex = 81;
            this.btnBuscarPorId.UseVisualStyleBackColor = false;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscarPorId_Click);
            // 
            // Consulta_Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscarPorId);
            this.Controls.Add(this.dataFiltroConsulta);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnBuscarData);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Consulta_Controle";
            this.Size = new System.Drawing.Size(656, 455);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.PictureBox btnBuscarData;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataFiltroConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPorId;
    }
}

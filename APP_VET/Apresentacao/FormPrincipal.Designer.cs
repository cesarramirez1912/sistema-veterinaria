namespace Apresentacao
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnVeterinario = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnMedicamentos = new System.Windows.Forms.Button();
            this.veterinario_Controle1 = new Apresentacao.Veterinario_Controle();
            this.medicamento_Controle1 = new Apresentacao.Medicamento_Controle();
            this.consulta_Controle1 = new Apresentacao.Consulta_Controle();
            this.animal_Controle1 = new Apresentacao.Animal_Controle();
            this.clienteControle1 = new Apresentacao.ClienteControle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 42);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(76, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(76, 55);
            this.label2.Name = "labelTextUsuario";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ramirez-1912@hotmail.com";
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCliente.BackgroundImage")));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Alef", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(40, 90);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(212, 87);
            this.btnCliente.TabIndex = 6;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 90);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 87);
            this.SidePanel.TabIndex = 7;
            // 
            // btnAnimal
            // 
            this.btnAnimal.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnimal.BackgroundImage")));
            this.btnAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnimal.FlatAppearance.BorderSize = 0;
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.Font = new System.Drawing.Font("Alef", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimal.ForeColor = System.Drawing.Color.White;
            this.btnAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btnAnimal.Image")));
            this.btnAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnimal.Location = new System.Drawing.Point(40, 177);
            this.btnAnimal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(212, 87);
            this.btnAnimal.TabIndex = 6;
            this.btnAnimal.Text = "Animal";
            this.btnAnimal.UseVisualStyleBackColor = false;
            this.btnAnimal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsulta.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsulta.BackgroundImage")));
            this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsulta.CausesValidation = false;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Alef", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(40, 264);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(212, 87);
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVeterinario
            // 
            this.btnVeterinario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVeterinario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVeterinario.BackgroundImage")));
            this.btnVeterinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVeterinario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVeterinario.FlatAppearance.BorderSize = 0;
            this.btnVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeterinario.Font = new System.Drawing.Font("Alef", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeterinario.ForeColor = System.Drawing.Color.White;
            this.btnVeterinario.Image = ((System.Drawing.Image)(resources.GetObject("btnVeterinario.Image")));
            this.btnVeterinario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeterinario.Location = new System.Drawing.Point(40, 350);
            this.btnVeterinario.Margin = new System.Windows.Forms.Padding(0);
            this.btnVeterinario.Name = "btnVeterinario";
            this.btnVeterinario.Size = new System.Drawing.Size(212, 87);
            this.btnVeterinario.TabIndex = 6;
            this.btnVeterinario.Text = "  Veterinario";
            this.btnVeterinario.UseVisualStyleBackColor = false;
            this.btnVeterinario.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(920, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(891, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnMedicamentos
            // 
            this.btnMedicamentos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMedicamentos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMedicamentos.BackgroundImage")));
            this.btnMedicamentos.FlatAppearance.BorderSize = 0;
            this.btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicamentos.Font = new System.Drawing.Font("Alef", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicamentos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMedicamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicamentos.Image")));
            this.btnMedicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicamentos.Location = new System.Drawing.Point(40, 437);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.Size = new System.Drawing.Size(212, 87);
            this.btnMedicamentos.TabIndex = 9;
            this.btnMedicamentos.Text = "    Medicamento";
            this.btnMedicamentos.UseVisualStyleBackColor = false;
            this.btnMedicamentos.Click += new System.EventHandler(this.btnMedicamentos_Click);
            // 
            // veterinario_Controle1
            // 
            this.veterinario_Controle1.Location = new System.Drawing.Point(277, 52);
            this.veterinario_Controle1.Name = "veterinario_Controle1";
            this.veterinario_Controle1.Size = new System.Drawing.Size(656, 455);
            this.veterinario_Controle1.TabIndex = 14;
            // 
            // medicamento_Controle1
            // 
            this.medicamento_Controle1.Location = new System.Drawing.Point(277, 52);
            this.medicamento_Controle1.Name = "medicamento_Controle1";
            this.medicamento_Controle1.Size = new System.Drawing.Size(656, 455);
            this.medicamento_Controle1.TabIndex = 13;
            // 
            // consulta_Controle1
            // 
            this.consulta_Controle1.Location = new System.Drawing.Point(277, 52);
            this.consulta_Controle1.Name = "consulta_Controle1";
            this.consulta_Controle1.Size = new System.Drawing.Size(656, 455);
            this.consulta_Controle1.TabIndex = 12;
            // 
            // animal_Controle1
            // 
            this.animal_Controle1.Location = new System.Drawing.Point(277, 52);
            this.animal_Controle1.Name = "animal_Controle1";
            this.animal_Controle1.Size = new System.Drawing.Size(656, 455);
            this.animal_Controle1.TabIndex = 11;
            // 
            // clienteControle1
            // 
            this.clienteControle1.Location = new System.Drawing.Point(277, 52);
            this.clienteControle1.Name = "clienteControle1";
            this.clienteControle1.Size = new System.Drawing.Size(656, 455);
            this.clienteControle1.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 617);
            this.Controls.Add(this.veterinario_Controle1);
            this.Controls.Add(this.medicamento_Controle1);
            this.Controls.Add(this.consulta_Controle1);
            this.Controls.Add(this.animal_Controle1);
            this.Controls.Add(this.clienteControle1);
            this.Controls.Add(this.btnMedicamentos);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.btnVeterinario);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnVeterinario;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnMedicamentos;
        private ClienteControle clienteControle1;
        private Animal_Controle animal_Controle1;
        private Consulta_Controle consulta_Controle1;
        private Medicamento_Controle medicamento_Controle1;
        private Veterinario_Controle veterinario_Controle1;
    }
}
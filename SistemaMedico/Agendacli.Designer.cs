namespace SistemaMedico
{
    partial class Agendacli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendacli));
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtHorario = new System.Windows.Forms.MaskedTextBox();
            this.txtAgenda = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.txtEspecialidade = new System.Windows.Forms.TextBox();
            this.lblIdAg = new System.Windows.Forms.Label();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(158, 160);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 0;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(325, 160);
            this.txtHorario.Mask = "00:00";
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(113, 20);
            this.txtHorario.TabIndex = 1;
            this.txtHorario.ValidatingType = typeof(System.DateTime);
            // 
            // txtAgenda
            // 
            this.txtAgenda.Location = new System.Drawing.Point(158, 56);
            this.txtAgenda.Name = "txtAgenda";
            this.txtAgenda.Size = new System.Drawing.Size(100, 20);
            this.txtAgenda.TabIndex = 2;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(338, 56);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(158, 90);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(280, 20);
            this.txtMedico.TabIndex = 4;
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.Location = new System.Drawing.Point(158, 126);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new System.Drawing.Size(280, 20);
            this.txtEspecialidade.TabIndex = 5;
            // 
            // lblIdAg
            // 
            this.lblIdAg.AutoSize = true;
            this.lblIdAg.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAg.Location = new System.Drawing.Point(68, 56);
            this.lblIdAg.Name = "lblIdAg";
            this.lblIdAg.Size = new System.Drawing.Size(79, 15);
            this.lblIdAg.TabIndex = 6;
            this.lblIdAg.Text = "ID Agenda : ";
            // 
            // lblIdCli
            // 
            this.lblIdCli.AutoSize = true;
            this.lblIdCli.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCli.Location = new System.Drawing.Point(261, 56);
            this.lblIdCli.Name = "lblIdCli";
            this.lblIdCli.Size = new System.Drawing.Size(71, 15);
            this.lblIdCli.TabIndex = 7;
            this.lblIdCli.Text = "ID Cliente :";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(84, 95);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(61, 15);
            this.lblMedico.TabIndex = 8;
            this.lblMedico.Text = "Médico : ";
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidade.Location = new System.Drawing.Point(56, 128);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(96, 15);
            this.lblEspecialidade.TabIndex = 9;
            this.lblEspecialidade.Text = "Especialidade :";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(99, 163);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 15);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data :";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(261, 163);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(62, 15);
            this.lblHorario.TabIndex = 11;
            this.lblHorario.Text = "Horário : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 213);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::SistemaMedico.Properties.Resources.transfer_man_employee_user_avatar_arrow_refresh_icon_141997;
            this.btnAlterar.Location = new System.Drawing.Point(213, 239);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(98, 46);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Image = global::SistemaMedico.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.btnInserir.Location = new System.Drawing.Point(109, 239);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(98, 46);
            this.btnInserir.TabIndex = 27;
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::SistemaMedico.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348;
            this.btnExcluir.Location = new System.Drawing.Point(317, 239);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 46);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // Agendacli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 527);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblIdCli);
            this.Controls.Add(this.lblIdAg);
            this.Controls.Add(this.txtEspecialidade);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtAgenda);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agendacli";
            this.Text = "Agenda de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtHorario;
        private System.Windows.Forms.TextBox txtAgenda;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.Label lblIdAg;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExcluir;
    }
}
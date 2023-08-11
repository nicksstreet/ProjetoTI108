
namespace PadariaCarmel
{
    partial class frmPesquisarFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarFuncionarios));
            this.grbPesquisar = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lstPesquisar = new System.Windows.Forms.ListBox();
            this.grbPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPesquisar
            // 
            this.grbPesquisar.Controls.Add(this.txtDescricao);
            this.grbPesquisar.Controls.Add(this.lblDescricao);
            this.grbPesquisar.Controls.Add(this.rdbNome);
            this.grbPesquisar.Controls.Add(this.rdbCodigo);
            this.grbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grbPesquisar.Location = new System.Drawing.Point(107, 60);
            this.grbPesquisar.Name = "grbPesquisar";
            this.grbPesquisar.Size = new System.Drawing.Size(411, 143);
            this.grbPesquisar.TabIndex = 0;
            this.grbPesquisar.TabStop = false;
            this.grbPesquisar.Text = "Pesquisar por";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(92, 91);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(237, 26);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 91);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descricao";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(0, 55);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(69, 24);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(0, 25);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(77, 24);
            this.rdbCodigo.TabIndex = 1;
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(524, 209);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(214, 41);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(524, 351);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(214, 44);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lstPesquisar
            // 
            this.lstPesquisar.FormattingEnabled = true;
            this.lstPesquisar.Location = new System.Drawing.Point(107, 209);
            this.lstPesquisar.Name = "lstPesquisar";
            this.lstPesquisar.Size = new System.Drawing.Size(411, 186);
            this.lstPesquisar.TabIndex = 7;
            this.lstPesquisar.SelectedIndexChanged += new System.EventHandler(this.lstPesquisar_SelectedIndexChanged);
            // 
            // frmPesquisarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.grbPesquisar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MaximizeBox = false;
            this.Name = "frmPesquisarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - Pesquisar Funcionarios";
            this.Load += new System.EventHandler(this.frmPesquisarFuncionarios_Load);
            this.grbPesquisar.ResumeLayout(false);
            this.grbPesquisar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox lstPesquisar;
    }
}
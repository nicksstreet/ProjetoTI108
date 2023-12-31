﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PadariaCarmel
{
    public partial class frmFuncionarios : Form
    {

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios()
        {
            InitializeComponent();
        }
        public frmFuncionarios(string nome)
        {
            InitializeComponent();
            txtNome.Text = nome;

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEnd.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;

            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            mskTel.Enabled = false;

            cbbEstado.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

        }
        public void habilitarCampos()
        {
            txtCodigo.Enabled = true;
            txtNome.Enabled = true;
            txtEnd.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;

            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            mskTel.Enabled = true;

            cbbEstado.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();

        }
        //Limpar Campos
        public void limparCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Clear();
            txtEnd.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();

            mskCEP.Clear();
            mskCPF.Clear();
            mskTel.Clear();

            cbbEstado.Text = "";


            txtNome.Focus();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com sucesso!!",
               "Mensagem do sistema.",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);

            desabilitarCampos();
            limparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();

        }
        public void buscaCEP(string numCEP)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
            try
            {
                WSCorreios.enderecoERP endereco = ws.consultaCEP(numCEP);

                txtEnd.Text = endereco.end;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.cidade;
                cbbEstado.Text = endereco.uf;
            }
            catch (Exception)
            {
                MessageBox.Show("Inserir CEP!",
                    "Messagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                    mskCEP.Focus();
                    mskCEP.Text = "";
            }
        }

        private void btnCarregaCEP_Click(object sender, EventArgs e)
        {
            buscaCEP(mskCEP.Text);

        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mskCEP.Text);
                txtNumero.Focus();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
            abrir.Show();
            this.Hide();
        }
    }
}

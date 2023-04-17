﻿using BibliotecaGames.BLL.Autenticacao;
using BibliotecaGames.BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaGames.Site.Autenticacao
{
    public partial class Login : System.Web.UI.Page
    {
        private LoginBo _loginBo;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            _loginBo = new LoginBo();

            var nomeUsuario = TxtUsuario.Text;
            var senha = TxtSenha.Text;

            try
            {
                var usuario = _loginBo.ObterUsuarioParaLogar(nomeUsuario, senha);
                FormsAuthentication.RedirectFromLoginPage(nomeUsuario, false);
                Session["Perfil"] = usuario.Perfil;
            }
            catch (UsuarioNaoCadastradoException)
            {
                LblStatus.Text = "Usuário não cadastrado";
            }
            catch (Exception)
            {
                LblStatus.Text = "Ocorreu um erro inesperado, favor consultar o administrador do sistema";
            }
        }
    }
}
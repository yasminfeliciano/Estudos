
namespace Aula61
{
    partial class F_MaskedTextBox
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
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.cb_somenteTexto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(12, 25);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(164, 20);
            this.mtb_senha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha:";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(12, 71);
            this.mtb_cpf.Mask = "000,000,000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(86, 20);
            this.mtb_cpf.TabIndex = 2;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(204, 69);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(82, 23);
            this.btn_mostrar.TabIndex = 3;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // cb_somenteTexto
            // 
            this.cb_somenteTexto.AutoSize = true;
            this.cb_somenteTexto.Location = new System.Drawing.Point(104, 73);
            this.cb_somenteTexto.Name = "cb_somenteTexto";
            this.cb_somenteTexto.Size = new System.Drawing.Size(94, 17);
            this.cb_somenteTexto.TabIndex = 4;
            this.cb_somenteTexto.Text = "Somente texto";
            this.cb_somenteTexto.UseVisualStyleBackColor = true;
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.cb_somenteTexto);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_senha);
            this.Name = "F_MaskedTextBox";
            this.Text = "F_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.CheckBox cb_somenteTexto;
    }
}
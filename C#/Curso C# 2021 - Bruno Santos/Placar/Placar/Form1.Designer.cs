
namespace Placar
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_comecarjogo = new System.Windows.Forms.Button();
            this.lbl_cronometro = new System.Windows.Forms.Label();
            this.lbl_nomeClube1 = new System.Windows.Forms.Label();
            this.lbl_nomeClube2 = new System.Windows.Forms.Label();
            this.lbl_resultadoClube1 = new System.Windows.Forms.Label();
            this.lbl_resultadoClube2 = new System.Windows.Forms.Label();
            this.bt_maisClube1 = new System.Windows.Forms.Button();
            this.bt_menosClube1 = new System.Windows.Forms.Button();
            this.bt_maisClube2 = new System.Windows.Forms.Button();
            this.bt_menosClube2 = new System.Windows.Forms.Button();
            this.pb_clube2 = new System.Windows.Forms.PictureBox();
            this.pb_clube1 = new System.Windows.Forms.PictureBox();
            this.cronometro = new System.Windows.Forms.Timer(this.components);
            this.lbl_parte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_comecarjogo
            // 
            this.bt_comecarjogo.Location = new System.Drawing.Point(298, 264);
            this.bt_comecarjogo.Name = "bt_comecarjogo";
            this.bt_comecarjogo.Size = new System.Drawing.Size(133, 36);
            this.bt_comecarjogo.TabIndex = 12;
            this.bt_comecarjogo.Text = "Começar Jogo";
            this.bt_comecarjogo.UseVisualStyleBackColor = true;
            this.bt_comecarjogo.Click += new System.EventHandler(this.bt_comecarJogo_Click);
            // 
            // lbl_cronometro
            // 
            this.lbl_cronometro.AutoSize = true;
            this.lbl_cronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cronometro.Location = new System.Drawing.Point(278, 112);
            this.lbl_cronometro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cronometro.Name = "lbl_cronometro";
            this.lbl_cronometro.Size = new System.Drawing.Size(162, 63);
            this.lbl_cronometro.TabIndex = 2;
            this.lbl_cronometro.Text = "00:00";
            // 
            // lbl_nomeClube1
            // 
            this.lbl_nomeClube1.AutoSize = true;
            this.lbl_nomeClube1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeClube1.Location = new System.Drawing.Point(83, 297);
            this.lbl_nomeClube1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomeClube1.Name = "lbl_nomeClube1";
            this.lbl_nomeClube1.Size = new System.Drawing.Size(48, 20);
            this.lbl_nomeClube1.TabIndex = 3;
            this.lbl_nomeClube1.Text = "Brasil";
            // 
            // lbl_nomeClube2
            // 
            this.lbl_nomeClube2.AutoSize = true;
            this.lbl_nomeClube2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeClube2.Location = new System.Drawing.Point(554, 297);
            this.lbl_nomeClube2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomeClube2.Name = "lbl_nomeClube2";
            this.lbl_nomeClube2.Size = new System.Drawing.Size(53, 20);
            this.lbl_nomeClube2.TabIndex = 4;
            this.lbl_nomeClube2.Text = "Japão";
            // 
            // lbl_resultadoClube1
            // 
            this.lbl_resultadoClube1.AutoSize = true;
            this.lbl_resultadoClube1.BackColor = System.Drawing.Color.White;
            this.lbl_resultadoClube1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultadoClube1.Location = new System.Drawing.Point(114, 352);
            this.lbl_resultadoClube1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_resultadoClube1.Name = "lbl_resultadoClube1";
            this.lbl_resultadoClube1.Size = new System.Drawing.Size(18, 20);
            this.lbl_resultadoClube1.TabIndex = 5;
            this.lbl_resultadoClube1.Text = "1";
            // 
            // lbl_resultadoClube2
            // 
            this.lbl_resultadoClube2.AutoSize = true;
            this.lbl_resultadoClube2.BackColor = System.Drawing.Color.White;
            this.lbl_resultadoClube2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultadoClube2.Location = new System.Drawing.Point(594, 352);
            this.lbl_resultadoClube2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_resultadoClube2.Name = "lbl_resultadoClube2";
            this.lbl_resultadoClube2.Size = new System.Drawing.Size(18, 20);
            this.lbl_resultadoClube2.TabIndex = 6;
            this.lbl_resultadoClube2.Text = "0";
            // 
            // bt_maisClube1
            // 
            this.bt_maisClube1.Location = new System.Drawing.Point(87, 410);
            this.bt_maisClube1.Name = "bt_maisClube1";
            this.bt_maisClube1.Size = new System.Drawing.Size(30, 30);
            this.bt_maisClube1.TabIndex = 7;
            this.bt_maisClube1.Text = "+";
            this.bt_maisClube1.UseVisualStyleBackColor = true;
            this.bt_maisClube1.Click += new System.EventHandler(this.bt_maisClube1_Click);
            // 
            // bt_menosClube1
            // 
            this.bt_menosClube1.Location = new System.Drawing.Point(135, 410);
            this.bt_menosClube1.Name = "bt_menosClube1";
            this.bt_menosClube1.Size = new System.Drawing.Size(30, 30);
            this.bt_menosClube1.TabIndex = 8;
            this.bt_menosClube1.Text = "-";
            this.bt_menosClube1.UseVisualStyleBackColor = true;
            this.bt_menosClube1.Click += new System.EventHandler(this.bt_menosClube1_Click);
            // 
            // bt_maisClube2
            // 
            this.bt_maisClube2.Location = new System.Drawing.Point(567, 410);
            this.bt_maisClube2.Name = "bt_maisClube2";
            this.bt_maisClube2.Size = new System.Drawing.Size(30, 30);
            this.bt_maisClube2.TabIndex = 9;
            this.bt_maisClube2.Text = "+";
            this.bt_maisClube2.UseVisualStyleBackColor = true;
            this.bt_maisClube2.Click += new System.EventHandler(this.bt_maisClube2_Click);
            // 
            // bt_menosClube2
            // 
            this.bt_menosClube2.Location = new System.Drawing.Point(611, 410);
            this.bt_menosClube2.Name = "bt_menosClube2";
            this.bt_menosClube2.Size = new System.Drawing.Size(30, 30);
            this.bt_menosClube2.TabIndex = 10;
            this.bt_menosClube2.Text = "-";
            this.bt_menosClube2.UseVisualStyleBackColor = true;
            this.bt_menosClube2.Click += new System.EventHandler(this.bt_menosClube2_Click);
            // 
            // pb_clube2
            // 
            this.pb_clube2.Location = new System.Drawing.Point(475, 18);
            this.pb_clube2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_clube2.Name = "pb_clube2";
            this.pb_clube2.Size = new System.Drawing.Size(225, 231);
            this.pb_clube2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_clube2.TabIndex = 1;
            this.pb_clube2.TabStop = false;
            // 
            // pb_clube1
            // 
            this.pb_clube1.Location = new System.Drawing.Point(18, 18);
            this.pb_clube1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_clube1.Name = "pb_clube1";
            this.pb_clube1.Size = new System.Drawing.Size(225, 231);
            this.pb_clube1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_clube1.TabIndex = 0;
            this.pb_clube1.TabStop = false;
            // 
            // cronometro
            // 
            this.cronometro.Interval = 1000;
            this.cronometro.Tick += new System.EventHandler(this.cronometro_Tick);
            // 
            // lbl_parte
            // 
            this.lbl_parte.AutoSize = true;
            this.lbl_parte.Location = new System.Drawing.Point(328, 229);
            this.lbl_parte.Name = "lbl_parte";
            this.lbl_parte.Size = new System.Drawing.Size(66, 20);
            this.lbl_parte.TabIndex = 11;
            this.lbl_parte.Text = "1ª Parte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 692);
            this.Controls.Add(this.bt_comecarjogo);
            this.Controls.Add(this.lbl_parte);
            this.Controls.Add(this.bt_menosClube2);
            this.Controls.Add(this.bt_maisClube2);
            this.Controls.Add(this.bt_menosClube1);
            this.Controls.Add(this.bt_maisClube1);
            this.Controls.Add(this.lbl_resultadoClube2);
            this.Controls.Add(this.lbl_resultadoClube1);
            this.Controls.Add(this.lbl_nomeClube2);
            this.Controls.Add(this.lbl_nomeClube1);
            this.Controls.Add(this.lbl_cronometro);
            this.Controls.Add(this.pb_clube2);
            this.Controls.Add(this.pb_clube1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_clube1;
        private System.Windows.Forms.PictureBox pb_clube2;
        private System.Windows.Forms.Label lbl_cronometro;
        private System.Windows.Forms.Label lbl_nomeClube1;
        private System.Windows.Forms.Label lbl_nomeClube2;
        private System.Windows.Forms.Label lbl_resultadoClube1;
        private System.Windows.Forms.Label lbl_resultadoClube2;
        private System.Windows.Forms.Button bt_maisClube1;
        private System.Windows.Forms.Button bt_menosClube1;
        private System.Windows.Forms.Button bt_maisClube2;
        private System.Windows.Forms.Button bt_menosClube2;
        private System.Windows.Forms.Button bt_comecarjogo;
        private System.Windows.Forms.Timer cronometro;
        private System.Windows.Forms.Label lbl_parte;
    }
}


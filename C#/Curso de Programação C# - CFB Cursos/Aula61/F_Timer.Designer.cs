
namespace Aula61
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciar_t1 = new System.Windows.Forms.Button();
            this.btn_parar_t1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reiniciar_t1 = new System.Windows.Forms.Button();
            this.img_carro = new System.Windows.Forms.PictureBox();
            this.timer_carro = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciarCarro = new System.Windows.Forms.Button();
            this.btn_pararCarro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciar_t1
            // 
            this.btn_iniciar_t1.Location = new System.Drawing.Point(12, 12);
            this.btn_iniciar_t1.Name = "btn_iniciar_t1";
            this.btn_iniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar_t1.TabIndex = 0;
            this.btn_iniciar_t1.Text = "Iniciar";
            this.btn_iniciar_t1.UseVisualStyleBackColor = true;
            this.btn_iniciar_t1.Click += new System.EventHandler(this.btn_iniciar_t1_Click);
            // 
            // btn_parar_t1
            // 
            this.btn_parar_t1.Location = new System.Drawing.Point(93, 12);
            this.btn_parar_t1.Name = "btn_parar_t1";
            this.btn_parar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_parar_t1.TabIndex = 1;
            this.btn_parar_t1.Text = "Parar";
            this.btn_parar_t1.UseVisualStyleBackColor = true;
            this.btn_parar_t1.Click += new System.EventHandler(this.btn_parar_t1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btn_reiniciar_t1
            // 
            this.btn_reiniciar_t1.Location = new System.Drawing.Point(174, 12);
            this.btn_reiniciar_t1.Name = "btn_reiniciar_t1";
            this.btn_reiniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_reiniciar_t1.TabIndex = 3;
            this.btn_reiniciar_t1.Text = "Reiniciar";
            this.btn_reiniciar_t1.UseVisualStyleBackColor = true;
            this.btn_reiniciar_t1.Click += new System.EventHandler(this.btn_reiniciar_t1_Click);
            // 
            // img_carro
            // 
            this.img_carro.Image = global::Aula61.Properties.Resources.carro;
            this.img_carro.Location = new System.Drawing.Point(12, 122);
            this.img_carro.Name = "img_carro";
            this.img_carro.Size = new System.Drawing.Size(100, 50);
            this.img_carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_carro.TabIndex = 4;
            this.img_carro.TabStop = false;
            // 
            // timer_carro
            // 
            this.timer_carro.Interval = 1;
            this.timer_carro.Tick += new System.EventHandler(this.timer_carro_Tick);
            // 
            // btn_iniciarCarro
            // 
            this.btn_iniciarCarro.Location = new System.Drawing.Point(12, 93);
            this.btn_iniciarCarro.Name = "btn_iniciarCarro";
            this.btn_iniciarCarro.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciarCarro.TabIndex = 5;
            this.btn_iniciarCarro.Text = "Iniciar Carro";
            this.btn_iniciarCarro.UseVisualStyleBackColor = true;
            this.btn_iniciarCarro.Click += new System.EventHandler(this.btn_iniciarCarro_Click);
            // 
            // btn_pararCarro
            // 
            this.btn_pararCarro.Location = new System.Drawing.Point(93, 93);
            this.btn_pararCarro.Name = "btn_pararCarro";
            this.btn_pararCarro.Size = new System.Drawing.Size(75, 23);
            this.btn_pararCarro.TabIndex = 6;
            this.btn_pararCarro.Text = "Parar Carro";
            this.btn_pararCarro.UseVisualStyleBackColor = true;
            this.btn_pararCarro.Click += new System.EventHandler(this.btn_pararCarro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ini: 12 - fim: 620";
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 443);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pararCarro);
            this.Controls.Add(this.btn_iniciarCarro);
            this.Controls.Add(this.img_carro);
            this.Controls.Add(this.btn_reiniciar_t1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parar_t1);
            this.Controls.Add(this.btn_iniciar_t1);
            this.Name = "F_Timer";
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciar_t1;
        private System.Windows.Forms.Button btn_parar_t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reiniciar_t1;
        private System.Windows.Forms.PictureBox img_carro;
        private System.Windows.Forms.Timer timer_carro;
        private System.Windows.Forms.Button btn_iniciarCarro;
        private System.Windows.Forms.Button btn_pararCarro;
        private System.Windows.Forms.Label label2;
    }
}
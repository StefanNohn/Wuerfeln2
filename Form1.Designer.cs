using System.Security.Cryptography.X509Certificates;

namespace Würfeln
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {            
            this.ButtonWeiterWürfeln = new System.Windows.Forms.Button();
            this.LabelNachrichten = new System.Windows.Forms.Label();
            this.Dice1 = new Würfeln.Dice();
            this.Dice2 = new Würfeln.Dice();
            this.Dice3 = new Würfeln.Dice();
            this.Dice4 = new Würfeln.Dice();
            this.Dice5 = new Würfeln.Dice();
            this.Dice6 = new Würfeln.Dice();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // 
            // ButtonWeiterWürfeln
            // 
            this.ButtonWeiterWürfeln.Location = new System.Drawing.Point(527, 206);
            this.ButtonWeiterWürfeln.Name = "ButtonWeiterWürfeln";
            this.ButtonWeiterWürfeln.Size = new System.Drawing.Size(168, 28);
            this.ButtonWeiterWürfeln.TabIndex = 49;
            this.ButtonWeiterWürfeln.Text = "Würfeln";
            this.ButtonWeiterWürfeln.UseVisualStyleBackColor = true;
            this.ButtonWeiterWürfeln.Click += new System.EventHandler(this.ButtonWeiterWürfeln_Click);
            // 
            // LabelNachrichten
            // 
            this.LabelNachrichten.AutoSize = true;
            this.LabelNachrichten.Location = new System.Drawing.Point(301, 316);
            this.LabelNachrichten.Name = "LabelNachrichten";
            this.LabelNachrichten.Size = new System.Drawing.Size(85, 13);
            this.LabelNachrichten.TabIndex = 50;
            this.LabelNachrichten.Text = "Nachrichtentafel";
            // 
            // Dice1
            // 
            this.Dice1.BackColor = System.Drawing.Color.LightGray;
            this.Dice1.Location = new System.Drawing.Point(289, 205);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(30, 30);
            this.Dice1.TabIndex = 43;
            this.Dice1.Text = "X";
            this.Dice1.Used = false;
            this.Dice1.UseVisualStyleBackColor = true;
            this.Dice1.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // Dice2
            // 
            this.Dice2.BackColor = System.Drawing.Color.LightGray;
            this.Dice2.Location = new System.Drawing.Point(325, 205);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(30, 30);
            this.Dice2.TabIndex = 44;
            this.Dice2.Text = "X";
            this.Dice2.Used = false;
            this.Dice2.UseVisualStyleBackColor = true;
            this.Dice2.Click += new System.EventHandler(this.Dice2_Click);
            // 
            // Dice3
            // 
            this.Dice3.BackColor = System.Drawing.Color.LightGray;
            this.Dice3.Location = new System.Drawing.Point(361, 205);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(30, 30);
            this.Dice3.TabIndex = 45;
            this.Dice3.Text = "X";
            this.Dice3.Used = false;
            this.Dice3.UseVisualStyleBackColor = true;
            this.Dice3.Click += new System.EventHandler(this.Dice3_Click);
            // 
            // Dice4
            // 
            this.Dice4.BackColor = System.Drawing.Color.LightGray;
            this.Dice4.Location = new System.Drawing.Point(398, 205);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(30, 30);
            this.Dice4.TabIndex = 46;
            this.Dice4.Text = "X";
            this.Dice4.Used = false;
            this.Dice4.UseVisualStyleBackColor = true;
            this.Dice4.Click += new System.EventHandler(this.Dice4_Click);
            // 
            // Dice5
            // 
            this.Dice5.BackColor = System.Drawing.Color.LightGray;
            this.Dice5.Location = new System.Drawing.Point(434, 205);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(30, 30);
            this.Dice5.TabIndex = 47;
            this.Dice5.Text = "X";
            this.Dice5.Used = false;
            this.Dice5.UseVisualStyleBackColor = true;
            this.Dice5.Click += new System.EventHandler(this.Dice5_Click);
            // 
            // Dice6
            // 
            this.Dice6.BackColor = System.Drawing.Color.LightGray;
            this.Dice6.Location = new System.Drawing.Point(470, 205);
            this.Dice6.Name = "Dice6";
            this.Dice6.Size = new System.Drawing.Size(30, 30);
            this.Dice6.TabIndex = 48;
            this.Dice6.Text = "X";
            this.Dice6.Used = false;
            this.Dice6.UseVisualStyleBackColor = true;
            this.Dice6.Click += new System.EventHandler(this.Dice6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 35);
            this.button1.TabIndex = 51;
            this.button1.Text = "Spieler erstellen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelNachrichten);
            this.Controls.Add(this.ButtonWeiterWürfeln);
            this.Controls.Add(this.Dice6);
            this.Controls.Add(this.Dice5);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);           
            this.Name = "Form1";
            this.Text = "zehntausend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
               
        public Dice Dice1;
        public Dice Dice2;
        public Dice Dice3;
        public Dice Dice4;
        public Dice Dice5;
        public Dice Dice6;
        private System.Windows.Forms.Button ButtonWeiterWürfeln;
        private System.Windows.Forms.Label LabelNachrichten;
        private System.Windows.Forms.Button button1;
    }
}


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
            this.LabelSpieler1 = new System.Windows.Forms.Label();
            this.LabelSpieler2 = new System.Windows.Forms.Label();
            this.LabelSpieler3 = new System.Windows.Forms.Label();
            this.LabelSpieler4 = new System.Windows.Forms.Label();
            this.TextBoxSpieler1 = new System.Windows.Forms.TextBox();
            this.TextBoxSpieler2 = new System.Windows.Forms.TextBox();
            this.TextBoxSpieler3 = new System.Windows.Forms.TextBox();
            this.TextBoxSpieler4 = new System.Windows.Forms.TextBox();
            this.ComboBoxSpieler1 = new System.Windows.Forms.ComboBox();
            this.ComboBoxSpieler2 = new System.Windows.Forms.ComboBox();
            this.ComboBoxSpieler3 = new System.Windows.Forms.ComboBox();
            this.ComboBoxSpieler4 = new System.Windows.Forms.ComboBox();
            this.LabelSpieler1Runde = new System.Windows.Forms.Label();
            this.LabelPunkteAnz1 = new System.Windows.Forms.Label();
            this.LabelSpieler1Punkte = new System.Windows.Forms.Label();
            this.LabelRundeAnz1 = new System.Windows.Forms.Label();
            this.LabelRundeAnz2 = new System.Windows.Forms.Label();
            this.LabelSpieler2Punkte = new System.Windows.Forms.Label();
            this.LabelPunkteAnz2 = new System.Windows.Forms.Label();
            this.LabelSpieler2Runde = new System.Windows.Forms.Label();
            this.LabelRundeAnz3 = new System.Windows.Forms.Label();
            this.LabelSpieler3Punkte = new System.Windows.Forms.Label();
            this.LabelPunkteAnz3 = new System.Windows.Forms.Label();
            this.LabelSpieler3Runde = new System.Windows.Forms.Label();
            this.LabelRundeAnz4 = new System.Windows.Forms.Label();
            this.LabelSpieler4Punkte = new System.Windows.Forms.Label();
            this.LabelPunkteAnz4 = new System.Windows.Forms.Label();
            this.LabelSpieler4Runde = new System.Windows.Forms.Label();
            this.ButtonWeiterWürfeln = new System.Windows.Forms.Button();
            this.LabelNachrichten = new System.Windows.Forms.Label();
            this.Dice1 = new Dice('X');
            this.Dice2 = new Dice('X');
            this.Dice3 = new Dice('X');
            this.Dice4 = new Dice('X');
            this.Dice5 = new Dice('X');
            this.Dice6 = new Dice('X');
            this.SuspendLayout();
            // 
            // LabelSpieler1
            // 
            this.LabelSpieler1.AutoSize = true;
            this.LabelSpieler1.Location = new System.Drawing.Point(12, 9);
            this.LabelSpieler1.Name = "LabelSpieler1";
            this.LabelSpieler1.Size = new System.Drawing.Size(98, 13);
            this.LabelSpieler1.TabIndex = 0;
            this.LabelSpieler1.Text = "Click to enter name";
            this.LabelSpieler1.Leave += new System.EventHandler(this.LabelSpieler1_Leave);
            this.LabelSpieler1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelSpieler1_MouseClick);
            // 
            // LabelSpieler2
            // 
            this.LabelSpieler2.AutoSize = true;
            this.LabelSpieler2.Location = new System.Drawing.Point(12, 31);
            this.LabelSpieler2.Name = "LabelSpieler2";
            this.LabelSpieler2.Size = new System.Drawing.Size(61, 13);
            this.LabelSpieler2.TabIndex = 2;
            this.LabelSpieler2.Text = "Computer 1";
            this.LabelSpieler2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelSpieler2_MouseClick);
            // 
            // LabelSpieler3
            // 
            this.LabelSpieler3.AutoSize = true;
            this.LabelSpieler3.Location = new System.Drawing.Point(12, 53);
            this.LabelSpieler3.Name = "LabelSpieler3";
            this.LabelSpieler3.Size = new System.Drawing.Size(61, 13);
            this.LabelSpieler3.TabIndex = 3;
            this.LabelSpieler3.Text = "Computer 2";
            this.LabelSpieler3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelSpieler3_MouseClick);
            // 
            // LabelSpieler4
            // 
            this.LabelSpieler4.AutoSize = true;
            this.LabelSpieler4.Location = new System.Drawing.Point(12, 75);
            this.LabelSpieler4.Name = "LabelSpieler4";
            this.LabelSpieler4.Size = new System.Drawing.Size(61, 13);
            this.LabelSpieler4.TabIndex = 4;
            this.LabelSpieler4.Text = "Computer 3";
            this.LabelSpieler4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelSpieler4_MouseClick);
            // 
            // TextBoxSpieler1
            // 
            this.TextBoxSpieler1.Location = new System.Drawing.Point(27, 376);
            this.TextBoxSpieler1.MaxLength = 20;
            this.TextBoxSpieler1.Name = "TextBoxSpieler1";
            this.TextBoxSpieler1.Size = new System.Drawing.Size(127, 20);
            this.TextBoxSpieler1.TabIndex = 5;
            this.TextBoxSpieler1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSpieler1_KeyDown);
            // 
            // TextBoxSpieler2
            // 
            this.TextBoxSpieler2.Location = new System.Drawing.Point(27, 402);
            this.TextBoxSpieler2.MaxLength = 25;
            this.TextBoxSpieler2.Name = "TextBoxSpieler2";
            this.TextBoxSpieler2.Size = new System.Drawing.Size(127, 20);
            this.TextBoxSpieler2.TabIndex = 6;
            this.TextBoxSpieler2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSpieler2_KeyDown);
            // 
            // TextBoxSpieler3
            // 
            this.TextBoxSpieler3.Location = new System.Drawing.Point(27, 428);
            this.TextBoxSpieler3.MaxLength = 25;
            this.TextBoxSpieler3.Name = "TextBoxSpieler3";
            this.TextBoxSpieler3.Size = new System.Drawing.Size(127, 20);
            this.TextBoxSpieler3.TabIndex = 7;
            this.TextBoxSpieler3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSpieler3_KeyDown);
            // 
            // TextBoxSpieler4
            // 
            this.TextBoxSpieler4.Location = new System.Drawing.Point(27, 454);
            this.TextBoxSpieler4.MaxLength = 25;
            this.TextBoxSpieler4.Name = "TextBoxSpieler4";
            this.TextBoxSpieler4.Size = new System.Drawing.Size(127, 20);
            this.TextBoxSpieler4.TabIndex = 8;
            this.TextBoxSpieler4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSpieler4_KeyDown);
            // 
            // ComboBoxSpieler1
            // 
            this.ComboBoxSpieler1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxSpieler1.FormattingEnabled = true;
            this.ComboBoxSpieler1.Items.AddRange(new object[] {
            "Mensch",
            "KI - ängstlich",
            "KI - normal",
            "KI - risiko"});
            this.ComboBoxSpieler1.Location = new System.Drawing.Point(145, 6);
            this.ComboBoxSpieler1.Name = "ComboBoxSpieler1";
            this.ComboBoxSpieler1.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxSpieler1.TabIndex = 9;
            this.ComboBoxSpieler1.SelectedValueChanged += new System.EventHandler(this.ComboBoxSpieler1_SelectedValueChanged);
            // 
            // ComboBoxSpieler2
            // 
            this.ComboBoxSpieler2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxSpieler2.FormattingEnabled = true;
            this.ComboBoxSpieler2.Items.AddRange(new object[] {
            "Mensch",
            "KI - ängstlich",
            "KI - normal",
            "KI - risiko"});
            this.ComboBoxSpieler2.Location = new System.Drawing.Point(145, 28);
            this.ComboBoxSpieler2.Name = "ComboBoxSpieler2";
            this.ComboBoxSpieler2.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxSpieler2.TabIndex = 10;
            this.ComboBoxSpieler2.SelectedValueChanged += new System.EventHandler(this.ComboBoxSpieler2_SelectedValueChanged);
            // 
            // ComboBoxSpieler3
            // 
            this.ComboBoxSpieler3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxSpieler3.FormattingEnabled = true;
            this.ComboBoxSpieler3.Items.AddRange(new object[] {
            "Mensch",
            "KI - ängstlich",
            "KI - normal",
            "KI - risiko"});
            this.ComboBoxSpieler3.Location = new System.Drawing.Point(145, 50);
            this.ComboBoxSpieler3.Name = "ComboBoxSpieler3";
            this.ComboBoxSpieler3.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxSpieler3.TabIndex = 11;
            this.ComboBoxSpieler3.SelectedValueChanged += new System.EventHandler(this.ComboBoxSpieler3_SelectedValueChanged);
            // 
            // ComboBoxSpieler4
            // 
            this.ComboBoxSpieler4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxSpieler4.FormattingEnabled = true;
            this.ComboBoxSpieler4.Items.AddRange(new object[] {
            "Mensch",
            "KI - ängstlich",
            "KI - normal",
            "KI - risiko"});
            this.ComboBoxSpieler4.Location = new System.Drawing.Point(145, 72);
            this.ComboBoxSpieler4.Name = "ComboBoxSpieler4";
            this.ComboBoxSpieler4.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxSpieler4.TabIndex = 12;
            this.ComboBoxSpieler4.SelectedValueChanged += new System.EventHandler(this.ComboBoxSpieler4_SelectedValueChanged);
            // 
            // LabelSpieler1Runde
            // 
            this.LabelSpieler1Runde.AutoSize = true;
            this.LabelSpieler1Runde.Location = new System.Drawing.Point(243, 9);
            this.LabelSpieler1Runde.Name = "LabelSpieler1Runde";
            this.LabelSpieler1Runde.Size = new System.Drawing.Size(54, 13);
            this.LabelSpieler1Runde.TabIndex = 18;
            this.LabelSpieler1Runde.Text = "Runde:    ";
            // 
            // LabelPunkteAnz1
            // 
            this.LabelPunkteAnz1.AutoSize = true;
            this.LabelPunkteAnz1.Location = new System.Drawing.Point(394, 9);
            this.LabelPunkteAnz1.Name = "LabelPunkteAnz1";
            this.LabelPunkteAnz1.Size = new System.Drawing.Size(28, 13);
            this.LabelPunkteAnz1.TabIndex = 22;
            this.LabelPunkteAnz1.Text = "     0";
            this.LabelPunkteAnz1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelSpieler1Punkte
            // 
            this.LabelSpieler1Punkte.AutoSize = true;
            this.LabelSpieler1Punkte.Location = new System.Drawing.Point(328, 9);
            this.LabelSpieler1Punkte.Name = "LabelSpieler1Punkte";
            this.LabelSpieler1Punkte.Size = new System.Drawing.Size(47, 13);
            this.LabelSpieler1Punkte.TabIndex = 26;
            this.LabelSpieler1Punkte.Text = "Punkte: ";
            // 
            // LabelRundeAnz1
            // 
            this.LabelRundeAnz1.AutoSize = true;
            this.LabelRundeAnz1.Location = new System.Drawing.Point(294, 9);
            this.LabelRundeAnz1.Name = "LabelRundeAnz1";
            this.LabelRundeAnz1.Size = new System.Drawing.Size(28, 13);
            this.LabelRundeAnz1.TabIndex = 30;
            this.LabelRundeAnz1.Text = "     0";
            this.LabelRundeAnz1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelRundeAnz2
            // 
            this.LabelRundeAnz2.AutoSize = true;
            this.LabelRundeAnz2.Location = new System.Drawing.Point(294, 31);
            this.LabelRundeAnz2.Name = "LabelRundeAnz2";
            this.LabelRundeAnz2.Size = new System.Drawing.Size(28, 13);
            this.LabelRundeAnz2.TabIndex = 34;
            this.LabelRundeAnz2.Text = "     0";
            this.LabelRundeAnz2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelSpieler2Punkte
            // 
            this.LabelSpieler2Punkte.AutoSize = true;
            this.LabelSpieler2Punkte.Location = new System.Drawing.Point(328, 31);
            this.LabelSpieler2Punkte.Name = "LabelSpieler2Punkte";
            this.LabelSpieler2Punkte.Size = new System.Drawing.Size(47, 13);
            this.LabelSpieler2Punkte.TabIndex = 33;
            this.LabelSpieler2Punkte.Text = "Punkte: ";
            // 
            // LabelPunkteAnz2
            // 
            this.LabelPunkteAnz2.AutoSize = true;
            this.LabelPunkteAnz2.Location = new System.Drawing.Point(394, 31);
            this.LabelPunkteAnz2.Name = "LabelPunkteAnz2";
            this.LabelPunkteAnz2.Size = new System.Drawing.Size(28, 13);
            this.LabelPunkteAnz2.TabIndex = 32;
            this.LabelPunkteAnz2.Text = "     0";
            this.LabelPunkteAnz2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelSpieler2Runde
            // 
            this.LabelSpieler2Runde.AutoSize = true;
            this.LabelSpieler2Runde.Location = new System.Drawing.Point(243, 31);
            this.LabelSpieler2Runde.Name = "LabelSpieler2Runde";
            this.LabelSpieler2Runde.Size = new System.Drawing.Size(54, 13);
            this.LabelSpieler2Runde.TabIndex = 31;
            this.LabelSpieler2Runde.Text = "Runde:    ";
            // 
            // LabelRundeAnz3
            // 
            this.LabelRundeAnz3.AutoSize = true;
            this.LabelRundeAnz3.Location = new System.Drawing.Point(294, 53);
            this.LabelRundeAnz3.Name = "LabelRundeAnz3";
            this.LabelRundeAnz3.Size = new System.Drawing.Size(28, 13);
            this.LabelRundeAnz3.TabIndex = 38;
            this.LabelRundeAnz3.Text = "     0";
            this.LabelRundeAnz3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelSpieler3Punkte
            // 
            this.LabelSpieler3Punkte.AutoSize = true;
            this.LabelSpieler3Punkte.Location = new System.Drawing.Point(328, 53);
            this.LabelSpieler3Punkte.Name = "LabelSpieler3Punkte";
            this.LabelSpieler3Punkte.Size = new System.Drawing.Size(47, 13);
            this.LabelSpieler3Punkte.TabIndex = 37;
            this.LabelSpieler3Punkte.Text = "Punkte: ";
            // 
            // LabelPunkteAnz3
            // 
            this.LabelPunkteAnz3.AutoSize = true;
            this.LabelPunkteAnz3.Location = new System.Drawing.Point(394, 53);
            this.LabelPunkteAnz3.Name = "LabelPunkteAnz3";
            this.LabelPunkteAnz3.Size = new System.Drawing.Size(28, 13);
            this.LabelPunkteAnz3.TabIndex = 36;
            this.LabelPunkteAnz3.Text = "     0";
            this.LabelPunkteAnz3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelSpieler3Runde
            // 
            this.LabelSpieler3Runde.AutoSize = true;
            this.LabelSpieler3Runde.Location = new System.Drawing.Point(243, 53);
            this.LabelSpieler3Runde.Name = "LabelSpieler3Runde";
            this.LabelSpieler3Runde.Size = new System.Drawing.Size(54, 13);
            this.LabelSpieler3Runde.TabIndex = 35;
            this.LabelSpieler3Runde.Text = "Runde:    ";
            // 
            // LabelRundeAnz4
            // 
            this.LabelRundeAnz4.AutoSize = true;
            this.LabelRundeAnz4.Location = new System.Drawing.Point(294, 75);
            this.LabelRundeAnz4.Name = "LabelRundeAnz4";
            this.LabelRundeAnz4.Size = new System.Drawing.Size(28, 13);
            this.LabelRundeAnz4.TabIndex = 42;
            this.LabelRundeAnz4.Text = "     0";
            this.LabelRundeAnz4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelSpieler4Punkte
            // 
            this.LabelSpieler4Punkte.AutoSize = true;
            this.LabelSpieler4Punkte.Location = new System.Drawing.Point(328, 75);
            this.LabelSpieler4Punkte.Name = "LabelSpieler4Punkte";
            this.LabelSpieler4Punkte.Size = new System.Drawing.Size(47, 13);
            this.LabelSpieler4Punkte.TabIndex = 41;
            this.LabelSpieler4Punkte.Text = "Punkte: ";
            // 
            // LabelPunkteAnz4
            // 
            this.LabelPunkteAnz4.AutoSize = true;
            this.LabelPunkteAnz4.Location = new System.Drawing.Point(394, 75);
            this.LabelPunkteAnz4.Name = "LabelPunkteAnz4";
            this.LabelPunkteAnz4.Size = new System.Drawing.Size(28, 13);
            this.LabelPunkteAnz4.TabIndex = 40;
            this.LabelPunkteAnz4.Text = "     0";
            this.LabelPunkteAnz4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelSpieler4Runde
            // 
            this.LabelSpieler4Runde.AutoSize = true;
            this.LabelSpieler4Runde.Location = new System.Drawing.Point(243, 75);
            this.LabelSpieler4Runde.Name = "LabelSpieler4Runde";
            this.LabelSpieler4Runde.Size = new System.Drawing.Size(54, 13);
            this.LabelSpieler4Runde.TabIndex = 39;
            this.LabelSpieler4Runde.Text = "Runde:    ";
            // 
            // Dice6
            // 
            this.Dice6.BackColor = System.Drawing.Color.LightGray;
            this.Dice6.Location = new System.Drawing.Point(196, 111);
            this.Dice6.Name = "Dice6";
            this.Dice6.Size = new System.Drawing.Size(30, 30);
            this.Dice6.TabIndex = 48;
            this.Dice6.Text = "X";
            this.Dice6.Used = false;
            this.Dice6.UseVisualStyleBackColor = true;
            this.Dice6.Click += new System.EventHandler(this.Dice6_Click);
            // 
            // Dice5
            // 
            this.Dice5.BackColor = System.Drawing.Color.LightGray;
            this.Dice5.Location = new System.Drawing.Point(160, 111);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(30, 30);
            this.Dice5.TabIndex = 47;
            this.Dice5.Text = "X";
            this.Dice5.Used = false;
            this.Dice5.UseVisualStyleBackColor = true;
            this.Dice5.Click += new System.EventHandler(this.Dice5_Click);
            // 
            // Dice4
            // 
            this.Dice4.BackColor = System.Drawing.Color.LightGray;
            this.Dice4.Location = new System.Drawing.Point(124, 111);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(30, 30);
            this.Dice4.TabIndex = 46;
            this.Dice4.Text = "X";
            this.Dice4.Used = false;
            this.Dice4.UseVisualStyleBackColor = true;
            this.Dice4.Click += new System.EventHandler(this.Dice4_Click);
            // 
            // Dice3
            // 
            this.Dice3.BackColor = System.Drawing.Color.LightGray;
            this.Dice3.Location = new System.Drawing.Point(87, 111);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(30, 30);
            this.Dice3.TabIndex = 45;
            this.Dice3.Text = "X";
            this.Dice3.Used = false;
            this.Dice3.UseVisualStyleBackColor = true;
            this.Dice3.Click += new System.EventHandler(this.Dice3_Click);
            // 
            // Dice2
            // 
            this.Dice2.BackColor = System.Drawing.Color.LightGray;
            this.Dice2.Location = new System.Drawing.Point(51, 111);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(30, 30);
            this.Dice2.TabIndex = 44;
            this.Dice2.Text = "X";
            this.Dice2.Used = false;
            this.Dice2.UseVisualStyleBackColor = true;
            this.Dice2.Click += new System.EventHandler(this.Dice2_Click);
            // 
            // Dice1
            // 
            this.Dice1.BackColor = System.Drawing.Color.LightGray;
            this.Dice1.Location = new System.Drawing.Point(15, 111);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(30, 30);
            this.Dice1.TabIndex = 43;
            this.Dice1.Text = "X";
            this.Dice1.Used = false;
            this.Dice1.UseVisualStyleBackColor = true;
            this.Dice1.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // ButtonWeiterWürfeln
            // 
            this.ButtonWeiterWürfeln.Location = new System.Drawing.Point(253, 112);
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
            this.LabelNachrichten.Location = new System.Drawing.Point(27, 222);
            this.LabelNachrichten.Name = "LabelNachrichten";
            this.LabelNachrichten.Size = new System.Drawing.Size(85, 13);
            this.LabelNachrichten.TabIndex = 50;
            this.LabelNachrichten.Text = "Nachrichtentafel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 579);
            this.Controls.Add(this.LabelNachrichten);
            this.Controls.Add(this.ButtonWeiterWürfeln);
            this.Controls.Add(this.Dice6);
            this.Controls.Add(this.Dice5);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.LabelRundeAnz4);
            this.Controls.Add(this.LabelSpieler4Punkte);
            this.Controls.Add(this.LabelPunkteAnz4);
            this.Controls.Add(this.LabelSpieler4Runde);
            this.Controls.Add(this.LabelRundeAnz3);
            this.Controls.Add(this.LabelSpieler3Punkte);
            this.Controls.Add(this.LabelPunkteAnz3);
            this.Controls.Add(this.LabelSpieler3Runde);
            this.Controls.Add(this.LabelRundeAnz2);
            this.Controls.Add(this.LabelSpieler2Punkte);
            this.Controls.Add(this.LabelPunkteAnz2);
            this.Controls.Add(this.LabelSpieler2Runde);
            this.Controls.Add(this.LabelRundeAnz1);
            this.Controls.Add(this.LabelSpieler1Punkte);
            this.Controls.Add(this.LabelPunkteAnz1);
            this.Controls.Add(this.LabelSpieler1Runde);
            this.Controls.Add(this.ComboBoxSpieler4);
            this.Controls.Add(this.ComboBoxSpieler3);
            this.Controls.Add(this.ComboBoxSpieler2);
            this.Controls.Add(this.ComboBoxSpieler1);
            this.Controls.Add(this.TextBoxSpieler4);
            this.Controls.Add(this.TextBoxSpieler3);
            this.Controls.Add(this.TextBoxSpieler2);
            this.Controls.Add(this.TextBoxSpieler1);
            this.Controls.Add(this.LabelSpieler4);
            this.Controls.Add(this.LabelSpieler3);
            this.Controls.Add(this.LabelSpieler2);
            this.Controls.Add(this.LabelSpieler1);
            this.Name = "Form1";
            this.Text = "zehntausend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSpieler1;
        private System.Windows.Forms.Label LabelSpieler2;
        private System.Windows.Forms.Label LabelSpieler3;
        private System.Windows.Forms.Label LabelSpieler4;
        private System.Windows.Forms.TextBox TextBoxSpieler1;
        private System.Windows.Forms.TextBox TextBoxSpieler2;
        private System.Windows.Forms.TextBox TextBoxSpieler3;
        private System.Windows.Forms.TextBox TextBoxSpieler4;
        private System.Windows.Forms.ComboBox ComboBoxSpieler1;
        private System.Windows.Forms.ComboBox ComboBoxSpieler2;
        private System.Windows.Forms.ComboBox ComboBoxSpieler3;
        private System.Windows.Forms.ComboBox ComboBoxSpieler4;
        private System.Windows.Forms.Label LabelSpieler1Runde;
        private System.Windows.Forms.Label LabelPunkteAnz1;
        private System.Windows.Forms.Label LabelSpieler1Punkte;
        private System.Windows.Forms.Label LabelRundeAnz1;
        private System.Windows.Forms.Label LabelRundeAnz2;
        private System.Windows.Forms.Label LabelSpieler2Punkte;
        private System.Windows.Forms.Label LabelPunkteAnz2;
        private System.Windows.Forms.Label LabelSpieler2Runde;
        private System.Windows.Forms.Label LabelRundeAnz3;
        private System.Windows.Forms.Label LabelSpieler3Punkte;
        private System.Windows.Forms.Label LabelPunkteAnz3;
        private System.Windows.Forms.Label LabelSpieler3Runde;
        private System.Windows.Forms.Label LabelRundeAnz4;
        private System.Windows.Forms.Label LabelSpieler4Punkte;
        private System.Windows.Forms.Label LabelPunkteAnz4;
        private System.Windows.Forms.Label LabelSpieler4Runde;
        public Dice Dice1;
        public Dice Dice2;
        public Dice Dice3;
        public Dice Dice4;
        public Dice Dice5;
        public Dice Dice6;
        private System.Windows.Forms.Button ButtonWeiterWürfeln;
        private System.Windows.Forms.Label LabelNachrichten;
    }
}


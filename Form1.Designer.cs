namespace Bitcoin_calculator
{
    partial class Form1
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
            this.currencyselector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bitcoinamountinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tulemuslable = new System.Windows.Forms.Label();
            this.resultlable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyselector
            // 
            this.currencyselector.BackColor = System.Drawing.Color.White;
            this.currencyselector.FormattingEnabled = true;
            this.currencyselector.Items.AddRange(new object[] {
            "Euro",
            "USD",
            "EEK"});
            this.currencyselector.Location = new System.Drawing.Point(89, 81);
            this.currencyselector.Name = "currencyselector";
            this.currencyselector.Size = new System.Drawing.Size(121, 28);
            this.currencyselector.TabIndex = 1;
            this.currencyselector.Text = "Vali valuuta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Arvuta kurss";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bitcoinamountinput
            // 
            this.bitcoinamountinput.Location = new System.Drawing.Point(220, 115);
            this.bitcoinamountinput.Name = "bitcoinamountinput";
            this.bitcoinamountinput.Size = new System.Drawing.Size(100, 26);
            this.bitcoinamountinput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sisesta BitCoini arv";
            // 
            // tulemuslable
            // 
            this.tulemuslable.AutoSize = true;
            this.tulemuslable.BackColor = System.Drawing.Color.Transparent;
            this.tulemuslable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tulemuslable.Location = new System.Drawing.Point(389, 89);
            this.tulemuslable.Name = "tulemuslable";
            this.tulemuslable.Size = new System.Drawing.Size(69, 20);
            this.tulemuslable.TabIndex = 6;
            this.tulemuslable.Text = "Tulemus";
            this.tulemuslable.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultlable
            // 
            this.resultlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.resultlable.ForeColor = System.Drawing.Color.HotPink;
            this.resultlable.Location = new System.Drawing.Point(393, 115);
            this.resultlable.Name = "resultlable";
            this.resultlable.Size = new System.Drawing.Size(135, 57);
            this.resultlable.TabIndex = 7;
            this.resultlable.Text = "Pole";
            this.resultlable.TextChanged += new System.EventHandler(this.resultlable_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bitcoin_calculator.Properties.Resources.hello_kitty_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultlable);
            this.Controls.Add(this.tulemuslable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitcoinamountinput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencyselector);
            this.Name = "Form1";
            this.Text = "BitCoinCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox currencyselector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bitcoinamountinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tulemuslable;
        private System.Windows.Forms.TextBox resultlable;
    }
}


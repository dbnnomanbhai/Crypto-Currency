
namespace crypto
{
    partial class Coin
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
            this.button1 = new System.Windows.Forms.Button();
            this.aToCombo2 = new System.Windows.Forms.ComboBox();
            this.aFromCombo1 = new System.Windows.Forms.ComboBox();
            this.aAmount = new System.Windows.Forms.TextBox();
            this.aDisplay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(405, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Exchange Coin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aToCombo2
            // 
            this.aToCombo2.FormattingEnabled = true;
            this.aToCombo2.Items.AddRange(new object[] {
            "Bitcoin",
            "Ether",
            "Litecoin"});
            this.aToCombo2.Location = new System.Drawing.Point(402, 208);
            this.aToCombo2.Name = "aToCombo2";
            this.aToCombo2.Size = new System.Drawing.Size(181, 21);
            this.aToCombo2.TabIndex = 15;
            // 
            // aFromCombo1
            // 
            this.aFromCombo1.FormattingEnabled = true;
            this.aFromCombo1.Items.AddRange(new object[] {
            "Bitcoin",
            "Ether",
            "Litecoin"});
            this.aFromCombo1.Location = new System.Drawing.Point(402, 151);
            this.aFromCombo1.Name = "aFromCombo1";
            this.aFromCombo1.Size = new System.Drawing.Size(181, 21);
            this.aFromCombo1.TabIndex = 14;
            // 
            // aAmount
            // 
            this.aAmount.Location = new System.Drawing.Point(402, 94);
            this.aAmount.Multiline = true;
            this.aAmount.Name = "aAmount";
            this.aAmount.Size = new System.Drawing.Size(181, 36);
            this.aAmount.TabIndex = 13;
            // 
            // aDisplay
            // 
            this.aDisplay.AutoSize = true;
            this.aDisplay.BackColor = System.Drawing.Color.White;
            this.aDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDisplay.ForeColor = System.Drawing.Color.Magenta;
            this.aDisplay.Location = new System.Drawing.Point(218, 339);
            this.aDisplay.Name = "aDisplay";
            this.aDisplay.Size = new System.Drawing.Size(202, 24);
            this.aDisplay.TabIndex = 12;
            this.aDisplay.Text = "Converted Amount : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Magenta;
            this.label4.Location = new System.Drawing.Point(247, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Convert To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(234, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Convert From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(83, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "EXCHANGE YOUR MONEY";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(70)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(124, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "HOME";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(330, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "COIN EXCHANGE";
            // 
            // Coin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(70)))));
            this.BackgroundImage = global::crypto.Properties.Resources.wp32874161;
            this.ClientSize = new System.Drawing.Size(734, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aToCombo2);
            this.Controls.Add(this.aFromCombo1);
            this.Controls.Add(this.aAmount);
            this.Controls.Add(this.aDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Coin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin";
            this.Load += new System.EventHandler(this.Coin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox aToCombo2;
        private System.Windows.Forms.ComboBox aFromCombo1;
        private System.Windows.Forms.TextBox aAmount;
        private System.Windows.Forms.Label aDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}
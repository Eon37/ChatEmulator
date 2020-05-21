namespace MultiThreading
{
    partial class ChatWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.aplBtn = new System.Windows.Forms.Button();
            this.amntLbl = new System.Windows.Forms.Label();
            this.speedLbl = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.MaskedTextBox();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            ChatWindow.marginalies = new System.Windows.Forms.RichTextBox();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.aplBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.amntLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.speedLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.amountBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.speedBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.46535F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.53465F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 535);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Controls.Add(ChatWindow.marginalies, 0, 3);
            // 
            // aplBtn
            // 
            this.aplBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.aplBtn, 2);
            this.aplBtn.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aplBtn.Location = new System.Drawing.Point(145, 147);
            this.aplBtn.Name = "aplBtn";
            this.aplBtn.Size = new System.Drawing.Size(86, 33);
            this.aplBtn.TabIndex = 5;
            this.aplBtn.Text = "Apply";
            this.aplBtn.UseVisualStyleBackColor = true;
            this.aplBtn.Click += new System.EventHandler(this.aplBtn_Click);
            // 
            // amntLbl
            // 
            this.amntLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amntLbl.AutoSize = true;
            this.amntLbl.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amntLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.amntLbl.Location = new System.Drawing.Point(32, 27);
            this.amntLbl.Name = "amntLbl";
            this.amntLbl.Size = new System.Drawing.Size(180, 23);
            this.amntLbl.TabIndex = 6;
            this.amntLbl.Text = "Number of users (0-9)";
            this.amntLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedLbl
            // 
            this.speedLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedLbl.AutoSize = true;
            this.speedLbl.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.speedLbl.Location = new System.Drawing.Point(3, 87);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(237, 46);
            this.speedLbl.TabIndex = 7;
            this.speedLbl.Text = "Speed for every user in seconds\r\n(1 per line or 1 for all)\r\n";
            this.speedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountBox
            // 
            this.amountBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.amountBox.Location = new System.Drawing.Point(247, 28);
            this.amountBox.Mask = "0";
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 8;
            this.amountBox.Text = "1";
            this.amountBox.ValidatingType = typeof(int);
            // 
            // speedBox
            // 
            this.speedBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.speedBox.Location = new System.Drawing.Point(247, 100);
            this.speedBox.Multiline = true;
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(100, 20);
            this.speedBox.TabIndex = 9;
            this.speedBox.Text = "5";
            // 
            // marginalies
            // 
            ChatWindow.marginalies.BackColor = System.Drawing.SystemColors.MenuText;
            ChatWindow.marginalies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(ChatWindow.marginalies, 2);
            ChatWindow.marginalies.Dock = System.Windows.Forms.DockStyle.Fill;
            ChatWindow.marginalies.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ChatWindow.marginalies.ForeColor = System.Drawing.SystemColors.Info;
            ChatWindow.marginalies.Location = new System.Drawing.Point(3, 144);
            ChatWindow.marginalies.Name = "marginalies";
            ChatWindow.marginalies.Size = new System.Drawing.Size(370, 345);
            ChatWindow.marginalies.TabIndex = 10;
            ChatWindow.marginalies.Text = "";
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(386, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 700);
            this.MinimumSize = new System.Drawing.Size(391, 580);
            this.Name = "ChatWindow";
            this.Text = "Chat Emulator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button aplBtn;
        private System.Windows.Forms.Label amntLbl;
        private System.Windows.Forms.Label speedLbl;
        private System.Windows.Forms.MaskedTextBox amountBox;
        private System.Windows.Forms.TextBox speedBox;
        static private System.Windows.Forms.RichTextBox marginalies;
    }
}


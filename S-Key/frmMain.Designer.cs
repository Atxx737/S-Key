
namespace S_Key
{
    partial class frmMain
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.tabPassword = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fpanelPassword = new System.Windows.Forms.FlowLayoutPanel();
            this.tabGeneratePassword = new System.Windows.Forms.TabPage();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.chkNumber = new System.Windows.Forms.CheckBox();
            this.chkSymbol = new System.Windows.Forms.CheckBox();
            this.txtGeneratePass = new System.Windows.Forms.TextBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.tabCheckPassword = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richtxtResult = new System.Windows.Forms.RichTextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPassword.SuspendLayout();
            this.tabGeneratePassword.SuspendLayout();
            this.tabCheckPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabAbout);
            this.tabControlMain.Controls.Add(this.tabPassword);
            this.tabControlMain.Controls.Add(this.tabGeneratePassword);
            this.tabControlMain.Controls.Add(this.tabCheckPassword);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(962, 504);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabAbout
            // 
            this.tabAbout.BackgroundImage = global::S_Key.Properties.Resources.main1;
            this.tabAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAbout.Location = new System.Drawing.Point(4, 29);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(954, 471);
            this.tabAbout.TabIndex = 4;
            this.tabAbout.Text = "About S-Key";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // tabPassword
            // 
            this.tabPassword.BackgroundImage = global::S_Key.Properties.Resources.password;
            this.tabPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPassword.Controls.Add(this.btnAdd);
            this.tabPassword.Controls.Add(this.fpanelPassword);
            this.tabPassword.Location = new System.Drawing.Point(4, 29);
            this.tabPassword.Name = "tabPassword";
            this.tabPassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPassword.Size = new System.Drawing.Size(954, 471);
            this.tabPassword.TabIndex = 1;
            this.tabPassword.Text = "Password";
            this.tabPassword.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(816, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 22);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fpanelPassword
            // 
            this.fpanelPassword.AutoScroll = true;
            this.fpanelPassword.Location = new System.Drawing.Point(80, 72);
            this.fpanelPassword.Name = "fpanelPassword";
            this.fpanelPassword.Size = new System.Drawing.Size(721, 338);
            this.fpanelPassword.TabIndex = 0;
            // 
            // tabGeneratePassword
            // 
            this.tabGeneratePassword.BackgroundImage = global::S_Key.Properties.Resources.generate;
            this.tabGeneratePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabGeneratePassword.Controls.Add(this.chkUpper);
            this.tabGeneratePassword.Controls.Add(this.btnGenerate);
            this.tabGeneratePassword.Controls.Add(this.txtLength);
            this.tabGeneratePassword.Controls.Add(this.chkNumber);
            this.tabGeneratePassword.Controls.Add(this.chkSymbol);
            this.tabGeneratePassword.Controls.Add(this.txtGeneratePass);
            this.tabGeneratePassword.Controls.Add(this.chkLower);
            this.tabGeneratePassword.Location = new System.Drawing.Point(4, 29);
            this.tabGeneratePassword.Name = "tabGeneratePassword";
            this.tabGeneratePassword.Size = new System.Drawing.Size(954, 471);
            this.tabGeneratePassword.TabIndex = 2;
            this.tabGeneratePassword.Text = "Generate Password";
            this.tabGeneratePassword.UseVisualStyleBackColor = true;
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(522, 260);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(18, 17);
            this.chkUpper.TabIndex = 13;
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoEllipsis = true;
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Location = new System.Drawing.Point(383, 292);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(182, 33);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLength.ForeColor = System.Drawing.Color.White;
            this.txtLength.Location = new System.Drawing.Point(522, 106);
            this.txtLength.Multiline = true;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(144, 27);
            this.txtLength.TabIndex = 9;
            // 
            // chkNumber
            // 
            this.chkNumber.AutoSize = true;
            this.chkNumber.Location = new System.Drawing.Point(522, 190);
            this.chkNumber.Name = "chkNumber";
            this.chkNumber.Size = new System.Drawing.Size(18, 17);
            this.chkNumber.TabIndex = 7;
            this.chkNumber.UseVisualStyleBackColor = true;
            // 
            // chkSymbol
            // 
            this.chkSymbol.AutoSize = true;
            this.chkSymbol.Location = new System.Drawing.Point(522, 155);
            this.chkSymbol.Name = "chkSymbol";
            this.chkSymbol.Size = new System.Drawing.Size(18, 17);
            this.chkSymbol.TabIndex = 2;
            this.chkSymbol.UseVisualStyleBackColor = true;
            // 
            // txtGeneratePass
            // 
            this.txtGeneratePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGeneratePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGeneratePass.Location = new System.Drawing.Point(255, 354);
            this.txtGeneratePass.Name = "txtGeneratePass";
            this.txtGeneratePass.Size = new System.Drawing.Size(445, 17);
            this.txtGeneratePass.TabIndex = 1;
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Location = new System.Drawing.Point(522, 224);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(18, 17);
            this.chkLower.TabIndex = 0;
            this.chkLower.UseVisualStyleBackColor = true;
            // 
            // tabCheckPassword
            // 
            this.tabCheckPassword.BackgroundImage = global::S_Key.Properties.Resources.check1;
            this.tabCheckPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCheckPassword.Controls.Add(this.textBox2);
            this.tabCheckPassword.Controls.Add(this.richtxtResult);
            this.tabCheckPassword.Controls.Add(this.btnCheck);
            this.tabCheckPassword.Controls.Add(this.txtPassword);
            this.tabCheckPassword.Location = new System.Drawing.Point(4, 29);
            this.tabCheckPassword.Name = "tabCheckPassword";
            this.tabCheckPassword.Size = new System.Drawing.Size(954, 471);
            this.tabCheckPassword.TabIndex = 3;
            this.tabCheckPassword.Text = "Check Password";
            this.tabCheckPassword.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(334, 224);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(289, 47);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            // 
            // richtxtResult
            // 
            this.richtxtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.richtxtResult.Location = new System.Drawing.Point(193, 254);
            this.richtxtResult.Name = "richtxtResult";
            this.richtxtResult.ReadOnly = true;
            this.richtxtResult.Size = new System.Drawing.Size(572, 146);
            this.richtxtResult.TabIndex = 14;
            this.richtxtResult.Text = "";
            this.richtxtResult.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheck.Location = new System.Drawing.Point(403, 184);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(146, 28);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(247, 138);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(459, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 504);
            this.Controls.Add(this.tabControlMain);
            this.Name = "frmMain";
            this.Text = "S-Key";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPassword.ResumeLayout(false);
            this.tabGeneratePassword.ResumeLayout(false);
            this.tabGeneratePassword.PerformLayout();
            this.tabCheckPassword.ResumeLayout(false);
            this.tabCheckPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPassword;
        private System.Windows.Forms.TabPage tabCheckPassword;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.FlowLayoutPanel fpanelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TabPage tabGeneratePassword;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.CheckBox chkNumber;
        private System.Windows.Forms.CheckBox chkSymbol;
        private System.Windows.Forms.TextBox txtGeneratePass;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.RichTextBox richtxtResult;
        private System.Windows.Forms.TextBox textBox2;
    }
}
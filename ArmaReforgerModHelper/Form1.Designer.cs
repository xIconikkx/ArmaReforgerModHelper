namespace ArmaReforgerModHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.changePathbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.assetidTxt = new System.Windows.Forms.Label();
            this.assetVertxt = new System.Windows.Forms.Label();
            this.assetNametxt = new System.Windows.Forms.Label();
            this.assetidtxtbox = new System.Windows.Forms.TextBox();
            this.assetnametextbox = new System.Windows.Forms.TextBox();
            this.assetvertextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // changePathbtn
            // 
            this.changePathbtn.Location = new System.Drawing.Point(696, 29);
            this.changePathbtn.Name = "changePathbtn";
            this.changePathbtn.Size = new System.Drawing.Size(92, 23);
            this.changePathbtn.TabIndex = 0;
            this.changePathbtn.Text = "Change Path";
            this.changePathbtn.UseVisualStyleBackColor = true;
            this.changePathbtn.Click += new System.EventHandler(this.changePathbtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(800, 23);
            this.textBox1.TabIndex = 1;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(656, 338);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(132, 23);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "NEXT";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(386, 338);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(132, 23);
            this.prevBtn.TabIndex = 5;
            this.prevBtn.Text = "PREVIOUS";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // assetidTxt
            // 
            this.assetidTxt.AutoSize = true;
            this.assetidTxt.Location = new System.Drawing.Point(386, 55);
            this.assetidTxt.Name = "assetidTxt";
            this.assetidTxt.Size = new System.Drawing.Size(52, 15);
            this.assetidTxt.TabIndex = 6;
            this.assetidTxt.Text = "Asset ID:";
            // 
            // assetVertxt
            // 
            this.assetVertxt.AutoSize = true;
            this.assetVertxt.Location = new System.Drawing.Point(386, 185);
            this.assetVertxt.Name = "assetVertxt";
            this.assetVertxt.Size = new System.Drawing.Size(48, 15);
            this.assetVertxt.TabIndex = 7;
            this.assetVertxt.Text = "Version:";
            // 
            // assetNametxt
            // 
            this.assetNametxt.AutoSize = true;
            this.assetNametxt.Location = new System.Drawing.Point(386, 119);
            this.assetNametxt.Name = "assetNametxt";
            this.assetNametxt.Size = new System.Drawing.Size(73, 15);
            this.assetNametxt.TabIndex = 8;
            this.assetNametxt.Text = "Asset Name:";
            // 
            // assetidtxtbox
            // 
            this.assetidtxtbox.Location = new System.Drawing.Point(386, 73);
            this.assetidtxtbox.Name = "assetidtxtbox";
            this.assetidtxtbox.ReadOnly = true;
            this.assetidtxtbox.Size = new System.Drawing.Size(402, 23);
            this.assetidtxtbox.TabIndex = 9;
            // 
            // assetnametextbox
            // 
            this.assetnametextbox.Location = new System.Drawing.Point(386, 137);
            this.assetnametextbox.Name = "assetnametextbox";
            this.assetnametextbox.ReadOnly = true;
            this.assetnametextbox.Size = new System.Drawing.Size(402, 23);
            this.assetnametextbox.TabIndex = 10;
            // 
            // assetvertextbox
            // 
            this.assetvertextbox.Location = new System.Drawing.Point(386, 203);
            this.assetvertextbox.Name = "assetvertextbox";
            this.assetvertextbox.Size = new System.Drawing.Size(402, 23);
            this.assetvertextbox.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::ArmaReforgerModHelper.Properties.Resources.noimage;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Made by Chad Fisher";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.assetvertextbox);
            this.Controls.Add(this.assetnametextbox);
            this.Controls.Add(this.assetidtxtbox);
            this.Controls.Add(this.assetNametxt);
            this.Controls.Add(this.assetVertxt);
            this.Controls.Add(this.assetidTxt);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.changePathbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arma Reforger Server Mod Helper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button changePathbtn;
        private TextBox textBox1;
        private Button nextBtn;
        private Button prevBtn;
        private Label assetidTxt;
        private Label assetVertxt;
        private Label assetNametxt;
        private TextBox assetidtxtbox;
        private TextBox assetnametextbox;
        private TextBox assetvertextbox;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
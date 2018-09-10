namespace Electronic_Seal
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.showPictureBox = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.inputBitmapSizeX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.textSizeText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textSizeTrack = new System.Windows.Forms.TrackBar();
            this.frameSizeText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.frameSizeTrack = new System.Windows.Forms.TrackBar();
            this.inputMframeSizeY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputBitmapSizeY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputMframeSizeX = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSizeTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameSizeTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // showPictureBox
            // 
            this.showPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.showPictureBox.Location = new System.Drawing.Point(16, 15);
            this.showPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showPictureBox.Name = "showPictureBox";
            this.showPictureBox.Size = new System.Drawing.Size(748, 532);
            this.showPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPictureBox.TabIndex = 0;
            this.showPictureBox.TabStop = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(35, 496);
            this.btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 29);
            this.btn.TabIndex = 1;
            this.btn.Text = "生  成";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // inputBitmapSizeX
            // 
            this.inputBitmapSizeX.Location = new System.Drawing.Point(96, 25);
            this.inputBitmapSizeX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBitmapSizeX.Name = "inputBitmapSizeX";
            this.inputBitmapSizeX.Size = new System.Drawing.Size(49, 25);
            this.inputBitmapSizeX.TabIndex = 2;
            this.inputBitmapSizeX.Text = "400";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "画布大小：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.inputText);
            this.groupBox1.Controls.Add(this.textSizeText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textSizeTrack);
            this.groupBox1.Controls.Add(this.frameSizeText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.frameSizeTrack);
            this.groupBox1.Controls.Add(this.inputMframeSizeY);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inputBitmapSizeY);
            this.groupBox1.Controls.Add(this.inputBitmapSizeX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputMframeSizeX);
            this.groupBox1.Controls.Add(this.btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(772, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(279, 532);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 379);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "显示文字：";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(96, 375);
            this.inputText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(173, 25);
            this.inputText.TabIndex = 18;
            this.inputText.Text = "请输入文本";
            // 
            // textSizeText
            // 
            this.textSizeText.AutoSize = true;
            this.textSizeText.Location = new System.Drawing.Point(167, 154);
            this.textSizeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textSizeText.Name = "textSizeText";
            this.textSizeText.Size = new System.Drawing.Size(23, 15);
            this.textSizeText.TabIndex = 14;
            this.textSizeText.Text = "45";
            this.textSizeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "文字大小：";
            // 
            // textSizeTrack
            // 
            this.textSizeTrack.Location = new System.Drawing.Point(96, 131);
            this.textSizeTrack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSizeTrack.Maximum = 80;
            this.textSizeTrack.Minimum = 9;
            this.textSizeTrack.Name = "textSizeTrack";
            this.textSizeTrack.Size = new System.Drawing.Size(175, 56);
            this.textSizeTrack.TabIndex = 12;
            this.textSizeTrack.Value = 45;
            this.textSizeTrack.Scroll += new System.EventHandler(this.textSizeTrack_Scroll);
            this.textSizeTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textSizeTrack_MouseDown);
            this.textSizeTrack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textSizeTrack_MouseUp);
            // 
            // frameSizeText
            // 
            this.frameSizeText.AutoSize = true;
            this.frameSizeText.Location = new System.Drawing.Point(167, 116);
            this.frameSizeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frameSizeText.Name = "frameSizeText";
            this.frameSizeText.Size = new System.Drawing.Size(15, 15);
            this.frameSizeText.TabIndex = 17;
            this.frameSizeText.Text = "6";
            this.frameSizeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "边框粗细：";
            // 
            // frameSizeTrack
            // 
            this.frameSizeTrack.Location = new System.Drawing.Point(96, 94);
            this.frameSizeTrack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frameSizeTrack.Maximum = 20;
            this.frameSizeTrack.Minimum = 2;
            this.frameSizeTrack.Name = "frameSizeTrack";
            this.frameSizeTrack.Size = new System.Drawing.Size(175, 56);
            this.frameSizeTrack.TabIndex = 15;
            this.frameSizeTrack.Value = 6;
            this.frameSizeTrack.Scroll += new System.EventHandler(this.frameSizeTrack_Scroll);
            this.frameSizeTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frameSizeTrack_MouseDown);
            this.frameSizeTrack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frameSizeTrack_MouseUp);
            // 
            // inputMframeSizeY
            // 
            this.inputMframeSizeY.Location = new System.Drawing.Point(176, 59);
            this.inputMframeSizeY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputMframeSizeY.Name = "inputMframeSizeY";
            this.inputMframeSizeY.Size = new System.Drawing.Size(49, 25);
            this.inputMframeSizeY.TabIndex = 9;
            this.inputMframeSizeY.Text = "150";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "像素";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "外框大小：";
            // 
            // inputBitmapSizeY
            // 
            this.inputBitmapSizeY.Location = new System.Drawing.Point(176, 25);
            this.inputBitmapSizeY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBitmapSizeY.Name = "inputBitmapSizeY";
            this.inputBitmapSizeY.Size = new System.Drawing.Size(49, 25);
            this.inputBitmapSizeY.TabIndex = 4;
            this.inputBitmapSizeY.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "像素";
            // 
            // inputMframeSizeX
            // 
            this.inputMframeSizeX.Location = new System.Drawing.Point(96, 59);
            this.inputMframeSizeX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputMframeSizeX.Name = "inputMframeSizeX";
            this.inputMframeSizeX.Size = new System.Drawing.Size(49, 25);
            this.inputMframeSizeX.TabIndex = 5;
            this.inputMframeSizeX.Text = "350";
            // 
            // saveBtn
            // 
            this.saveBtn.CausesValidation = false;
            this.saveBtn.Location = new System.Drawing.Point(142, 496);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 29);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "保  存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSizeTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameSizeTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox showPictureBox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox inputBitmapSizeX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputMframeSizeY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputBitmapSizeY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputMframeSizeX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar textSizeTrack;
        private System.Windows.Forms.Label textSizeText;
        private System.Windows.Forms.Label frameSizeText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar frameSizeTrack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
    }
}


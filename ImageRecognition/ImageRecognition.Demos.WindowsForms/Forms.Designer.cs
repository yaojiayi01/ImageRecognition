namespace ImageRecognition.Demos.WindowsForms
{
    partial class Forms
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
            this.faceDetection = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pedestriandetectionbtn = new System.Windows.Forms.Button();
            this.facedetection_btn = new System.Windows.Forms.Button();
            this.orgimg = new System.Windows.Forms.PictureBox();
            this.orgimgpath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.faceDetection.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgimg)).BeginInit();
            this.SuspendLayout();
            // 
            // faceDetection
            // 
            this.faceDetection.Controls.Add(this.tabPage1);
            this.faceDetection.Controls.Add(this.tabPage2);
            this.faceDetection.Location = new System.Drawing.Point(13, 13);
            this.faceDetection.Name = "faceDetection";
            this.faceDetection.SelectedIndex = 0;
            this.faceDetection.Size = new System.Drawing.Size(1165, 602);
            this.faceDetection.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.pedestriandetectionbtn);
            this.tabPage1.Controls.Add(this.facedetection_btn);
            this.tabPage1.Controls.Add(this.orgimg);
            this.tabPage1.Controls.Add(this.orgimgpath);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1157, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "特征检测";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(573, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "边缘检测";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "灰度处理";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "选择匹配图";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pedestriandetectionbtn
            // 
            this.pedestriandetectionbtn.Location = new System.Drawing.Point(155, 537);
            this.pedestriandetectionbtn.Name = "pedestriandetectionbtn";
            this.pedestriandetectionbtn.Size = new System.Drawing.Size(75, 23);
            this.pedestriandetectionbtn.TabIndex = 5;
            this.pedestriandetectionbtn.Text = "行人检测";
            this.pedestriandetectionbtn.UseVisualStyleBackColor = true;
            this.pedestriandetectionbtn.Click += new System.EventHandler(this.pedestriandetectionbtn_Click);
            // 
            // facedetection_btn
            // 
            this.facedetection_btn.Location = new System.Drawing.Point(36, 537);
            this.facedetection_btn.Name = "facedetection_btn";
            this.facedetection_btn.Size = new System.Drawing.Size(75, 23);
            this.facedetection_btn.TabIndex = 4;
            this.facedetection_btn.Text = "检测脸+眼";
            this.facedetection_btn.UseVisualStyleBackColor = true;
            this.facedetection_btn.Click += new System.EventHandler(this.facedetection_btn_Click);
            // 
            // orgimg
            // 
            this.orgimg.Location = new System.Drawing.Point(36, 51);
            this.orgimg.Name = "orgimg";
            this.orgimg.Size = new System.Drawing.Size(1069, 466);
            this.orgimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orgimg.TabIndex = 2;
            this.orgimg.TabStop = false;
            // 
            // orgimgpath
            // 
            this.orgimgpath.Location = new System.Drawing.Point(135, 24);
            this.orgimgpath.Name = "orgimgpath";
            this.orgimgpath.Size = new System.Drawing.Size(270, 21);
            this.orgimgpath.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1157, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(696, 536);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "形状检测";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 627);
            this.Controls.Add(this.faceDetection);
            this.Name = "Forms";
            this.Text = "Main";
            this.faceDetection.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl faceDetection;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox orgimgpath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox orgimg;
        private System.Windows.Forms.Button facedetection_btn;
        private System.Windows.Forms.Button pedestriandetectionbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}


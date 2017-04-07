namespace _21GDI
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
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnDrawRect = new System.Windows.Forms.Button();
            this.btnDrawLetter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(51, 36);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(75, 23);
            this.btnDrawLine.TabIndex = 0;
            this.btnDrawLine.Text = "绘制直线";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // btnDrawRect
            // 
            this.btnDrawRect.Location = new System.Drawing.Point(188, 35);
            this.btnDrawRect.Name = "btnDrawRect";
            this.btnDrawRect.Size = new System.Drawing.Size(75, 23);
            this.btnDrawRect.TabIndex = 1;
            this.btnDrawRect.Text = "绘制长方形";
            this.btnDrawRect.UseVisualStyleBackColor = true;
            this.btnDrawRect.Click += new System.EventHandler(this.btnDrawRect_Click);
            // 
            // btnDrawLetter
            // 
            this.btnDrawLetter.Location = new System.Drawing.Point(51, 100);
            this.btnDrawLetter.Name = "btnDrawLetter";
            this.btnDrawLetter.Size = new System.Drawing.Size(75, 23);
            this.btnDrawLetter.TabIndex = 2;
            this.btnDrawLetter.Text = "绘制文字";
            this.btnDrawLetter.UseVisualStyleBackColor = true;
            this.btnDrawLetter.Click += new System.EventHandler(this.btnDrawLetter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(163, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDrawLetter);
            this.Controls.Add(this.btnDrawRect);
            this.Controls.Add(this.btnDrawLine);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnDrawRect;
        private System.Windows.Forms.Button btnDrawLetter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace SpeedTraining
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.play = new System.Windows.Forms.PictureBox();
            this.train1 = new System.Windows.Forms.PictureBox();
            this.train2 = new System.Windows.Forms.PictureBox();
            this.train3 = new System.Windows.Forms.PictureBox();
            this.Level2 = new System.Windows.Forms.PictureBox();
            this.Level3 = new System.Windows.Forms.PictureBox();
            this.Level1 = new System.Windows.Forms.PictureBox();
            this.returnbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.train1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.train2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.train3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnbox)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play.BackgroundImage")));
            this.play.Location = new System.Drawing.Point(505, 299);
            this.play.Margin = new System.Windows.Forms.Padding(2);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(140, 40);
            this.play.TabIndex = 0;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // train1
            // 
            this.train1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("train1.BackgroundImage")));
            this.train1.Location = new System.Drawing.Point(505, 163);
            this.train1.Name = "train1";
            this.train1.Size = new System.Drawing.Size(140, 40);
            this.train1.TabIndex = 1;
            this.train1.TabStop = false;
            this.train1.Visible = false;
            this.train1.Click += new System.EventHandler(this.train1_Click);
            // 
            // train2
            // 
            this.train2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("train2.BackgroundImage")));
            this.train2.Location = new System.Drawing.Point(505, 233);
            this.train2.Name = "train2";
            this.train2.Size = new System.Drawing.Size(140, 40);
            this.train2.TabIndex = 2;
            this.train2.TabStop = false;
            this.train2.Visible = false;
            this.train2.Click += new System.EventHandler(this.train2_Click);
            // 
            // train3
            // 
            this.train3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("train3.BackgroundImage")));
            this.train3.Location = new System.Drawing.Point(505, 299);
            this.train3.Name = "train3";
            this.train3.Size = new System.Drawing.Size(140, 40);
            this.train3.TabIndex = 3;
            this.train3.TabStop = false;
            this.train3.Visible = false;
            this.train3.Click += new System.EventHandler(this.train3_Click);
            // 
            // Level2
            // 
            this.Level2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Level2.BackgroundImage")));
            this.Level2.Location = new System.Drawing.Point(505, 233);
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(140, 40);
            this.Level2.TabIndex = 4;
            this.Level2.TabStop = false;
            this.Level2.Visible = false;
            this.Level2.Click += new System.EventHandler(this.Level2_Click);
            // 
            // Level3
            // 
            this.Level3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Level3.BackgroundImage")));
            this.Level3.Location = new System.Drawing.Point(505, 299);
            this.Level3.Name = "Level3";
            this.Level3.Size = new System.Drawing.Size(140, 40);
            this.Level3.TabIndex = 5;
            this.Level3.TabStop = false;
            this.Level3.Visible = false;
            this.Level3.Click += new System.EventHandler(this.Level3_Click);
            // 
            // Level1
            // 
            this.Level1.BackColor = System.Drawing.SystemColors.Control;
            this.Level1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Level1.BackgroundImage")));
            this.Level1.Location = new System.Drawing.Point(505, 163);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(140, 40);
            this.Level1.TabIndex = 6;
            this.Level1.TabStop = false;
            this.Level1.Visible = false;
            this.Level1.Click += new System.EventHandler(this.Level1_Click);
            // 
            // returnbox
            // 
            this.returnbox.BackColor = System.Drawing.SystemColors.Control;
            this.returnbox.BackgroundImage = global::SpeedTraining.Properties.Resources.返回按钮;
            this.returnbox.Location = new System.Drawing.Point(0, 0);
            this.returnbox.Name = "returnbox";
            this.returnbox.Size = new System.Drawing.Size(50, 50);
            this.returnbox.TabIndex = 7;
            this.returnbox.TabStop = false;
            this.returnbox.Visible = false;
            this.returnbox.Click += new System.EventHandler(this.returnbox_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 389);
            this.Controls.Add(this.returnbox);
            this.Controls.Add(this.Level1);
            this.Controls.Add(this.Level3);
            this.Controls.Add(this.Level2);
            this.Controls.Add(this.train3);
            this.Controls.Add(this.train2);
            this.Controls.Add(this.train1);
            this.Controls.Add(this.play);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Start";
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.train1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.train2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.train3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox train1;
        private System.Windows.Forms.PictureBox train2;
        private System.Windows.Forms.PictureBox train3;
        private System.Windows.Forms.PictureBox Level2;
        private System.Windows.Forms.PictureBox Level3;
        private System.Windows.Forms.PictureBox Level1;
        private System.Windows.Forms.PictureBox returnbox;
    }
}


namespace AntiCensorGUI
{
    partial class MainForm
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
            this.gameRootLable = new System.Windows.Forms.Label();
            this.gameRootValue = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameRootLable
            // 
            this.gameRootLable.AutoSize = true;
            this.gameRootLable.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gameRootLable.Location = new System.Drawing.Point(50, 80);
            this.gameRootLable.MaximumSize = new System.Drawing.Size(180, 45);
            this.gameRootLable.MinimumSize = new System.Drawing.Size(60, 15);
            this.gameRootLable.Name = "gameRootLable";
            this.gameRootLable.Size = new System.Drawing.Size(104, 19);
            this.gameRootLable.TabIndex = 0;
            this.gameRootLable.Text = "游戏根路径";
            // 
            // gameRootValue
            // 
            this.gameRootValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gameRootValue.Location = new System.Drawing.Point(183, 78);
            this.gameRootValue.MaximumSize = new System.Drawing.Size(600, 21);
            this.gameRootValue.MinimumSize = new System.Drawing.Size(300, 21);
            this.gameRootValue.Name = "gameRootValue";
            this.gameRootValue.Size = new System.Drawing.Size(500, 21);
            this.gameRootValue.TabIndex = 1;
            this.gameRootValue.TextChanged += new System.EventHandler(this.gameRootValue_TextChanged);
            // 
            // folderBrowserButton
            // 
            this.folderBrowserButton.Location = new System.Drawing.Point(702, 75);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(31, 23);
            this.folderBrowserButton.TabIndex = 2;
            this.folderBrowserButton.Text = "...";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startButton.Location = new System.Drawing.Point(308, 158);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(184, 44);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "启动游戏";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 241);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.folderBrowserButton);
            this.Controls.Add(this.gameRootValue);
            this.Controls.Add(this.gameRootLable);
            this.MaximumSize = new System.Drawing.Size(800, 560);
            this.MinimumSize = new System.Drawing.Size(400, 280);
            this.Name = "MainForm";
            this.Text = "原神反和谐";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameRootLable;
        private System.Windows.Forms.TextBox gameRootValue;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.Button startButton;
    }
}


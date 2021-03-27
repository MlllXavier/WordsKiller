namespace WordsKiller
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlOption = new System.Windows.Forms.Panel();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOption
            // 
            this.pnlOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlOption.Controls.Add(this.lblD);
            this.pnlOption.Controls.Add(this.lblC);
            this.pnlOption.Controls.Add(this.lblB);
            this.pnlOption.Controls.Add(this.lblA);
            this.pnlOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOption.Location = new System.Drawing.Point(0, 980);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(1920, 100);
            this.pnlOption.TabIndex = 12;
            this.pnlOption.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOption_Paint);
            // 
            // lblD
            // 
            this.lblD.BackColor = System.Drawing.Color.Transparent;
            this.lblD.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblD.ForeColor = System.Drawing.Color.White;
            this.lblD.Location = new System.Drawing.Point(1440, 0);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(480, 100);
            this.lblD.TabIndex = 3;
            this.lblD.Tag = "4";
            this.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblD.Visible = false;
            this.lblD.Click += new System.EventHandler(this.lblA_Click);
            this.lblD.MouseEnter += new System.EventHandler(this.lblA_MouseEnter);
            this.lblD.MouseLeave += new System.EventHandler(this.lblA_MouseLeave);
            // 
            // lblC
            // 
            this.lblC.BackColor = System.Drawing.Color.Transparent;
            this.lblC.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(960, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(480, 100);
            this.lblC.TabIndex = 2;
            this.lblC.Tag = "3";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblC.Visible = false;
            this.lblC.Click += new System.EventHandler(this.lblA_Click);
            this.lblC.MouseEnter += new System.EventHandler(this.lblA_MouseEnter);
            this.lblC.MouseLeave += new System.EventHandler(this.lblA_MouseLeave);
            // 
            // lblB
            // 
            this.lblB.BackColor = System.Drawing.Color.Transparent;
            this.lblB.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblB.ForeColor = System.Drawing.Color.White;
            this.lblB.Location = new System.Drawing.Point(480, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(480, 100);
            this.lblB.TabIndex = 1;
            this.lblB.Tag = "2";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblB.Visible = false;
            this.lblB.Click += new System.EventHandler(this.lblA_Click);
            this.lblB.MouseEnter += new System.EventHandler(this.lblA_MouseEnter);
            this.lblB.MouseLeave += new System.EventHandler(this.lblA_MouseLeave);
            // 
            // lblA
            // 
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblA.ForeColor = System.Drawing.Color.White;
            this.lblA.Location = new System.Drawing.Point(0, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(480, 100);
            this.lblA.TabIndex = 0;
            this.lblA.Tag = "1";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblA.Visible = false;
            this.lblA.Click += new System.EventHandler(this.lblA_Click);
            this.lblA.MouseEnter += new System.EventHandler(this.lblA_MouseEnter);
            this.lblA.MouseLeave += new System.EventHandler(this.lblA_MouseLeave);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(145, 117);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer.TabIndex = 13;
            this.axWindowsMediaPlayer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.pnlOption);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Timer timer;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
    }
}


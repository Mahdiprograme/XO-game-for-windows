namespace xo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.retryGameBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGame_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.index1_btn = new System.Windows.Forms.Label();
            this.index0_btn = new System.Windows.Forms.Label();
            this.index2_btn = new System.Windows.Forms.Label();
            this.index5_btn = new System.Windows.Forms.Label();
            this.index4_btn = new System.Windows.Forms.Label();
            this.index3_btn = new System.Windows.Forms.Label();
            this.index6_btn = new System.Windows.Forms.Label();
            this.index7_btn = new System.Windows.Forms.Label();
            this.index8_btn = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(398, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameMenu
            // 
            this.gameMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gameMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retryGameBtn,
            this.closeGame_btn,
            this.settingsToolStripMenuItem});
            this.gameMenu.ForeColor = System.Drawing.Color.Black;
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Size = new System.Drawing.Size(50, 20);
            this.gameMenu.Text = "Game";
            // 
            // retryGameBtn
            // 
            this.retryGameBtn.BackColor = System.Drawing.Color.Red;
            this.retryGameBtn.ForeColor = System.Drawing.Color.White;
            this.retryGameBtn.Name = "retryGameBtn";
            this.retryGameBtn.Size = new System.Drawing.Size(152, 22);
            this.retryGameBtn.Text = "Retry";
            this.retryGameBtn.Click += new System.EventHandler(this.retryGameBtn_Click);
            // 
            // closeGame_btn
            // 
            this.closeGame_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.closeGame_btn.ForeColor = System.Drawing.Color.White;
            this.closeGame_btn.Name = "closeGame_btn";
            this.closeGame_btn.Size = new System.Drawing.Size(152, 22);
            this.closeGame_btn.Text = "Close";
            this.closeGame_btn.Click += new System.EventHandler(this.closeGame_btn_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 10);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 10);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(121, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 288);
            this.label3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(243, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 288);
            this.label5.TabIndex = 1;
            // 
            // index1_btn
            // 
            this.index1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.index1_btn.ForeColor = System.Drawing.Color.Coral;
            this.index1_btn.Location = new System.Drawing.Point(137, 38);
            this.index1_btn.Name = "index1_btn";
            this.index1_btn.Size = new System.Drawing.Size(100, 85);
            this.index1_btn.TabIndex = 3;
            this.index1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.index1_btn.Click += new System.EventHandler(this.index1_btn_Click);
            // 
            // index0_btn
            // 
            this.index0_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.index0_btn.ForeColor = System.Drawing.Color.Coral;
            this.index0_btn.Location = new System.Drawing.Point(17, 38);
            this.index0_btn.Name = "index0_btn";
            this.index0_btn.Size = new System.Drawing.Size(100, 85);
            this.index0_btn.TabIndex = 3;
            this.index0_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.index0_btn.Click += new System.EventHandler(this.index0_btn_Click);
            // 
            // index2_btn
            // 
            this.index2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.index2_btn.ForeColor = System.Drawing.Color.Coral;
            this.index2_btn.Location = new System.Drawing.Point(258, 38);
            this.index2_btn.Name = "index2_btn";
            this.index2_btn.Size = new System.Drawing.Size(100, 85);
            this.index2_btn.TabIndex = 3;
            this.index2_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.index2_btn.Click += new System.EventHandler(this.index2_btn_Click);
            // 
            // index5_btn
            // 
            this.index5_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.index5_btn.ForeColor = System.Drawing.Color.Coral;
            this.index5_btn.Location = new System.Drawing.Point(258, 133);
            this.index5_btn.Name = "index5_btn";
            this.index5_btn.Size = new System.Drawing.Size(100, 85);
            this.index5_btn.TabIndex = 3;
            this.index5_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.index5_btn.Click += new System.EventHandler(this.index5_btn_Click);
            // 
            // index4_btn
            // 
            this.index4_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.index4_btn.ForeColor = System.Drawing.Color.Red;
            this.index4_btn.Location = new System.Drawing.Point(137, 133);
            this.index4_btn.Name = "index4_btn";
            this.index4_btn.Size = new System.Drawing.Size(100, 85);
            this.index4_btn.TabIndex = 3;
            this.index4_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.index4_btn.Click += new System.EventHandler(this.index4_btn_Click);
            // 
            // index3_btn
            // 
            this.index3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.index3_btn.ForeColor = System.Drawing.Color.Coral;
            this.index3_btn.Location = new System.Drawing.Point(17, 133);
            this.index3_btn.Name = "index3_btn";
            this.index3_btn.Size = new System.Drawing.Size(100, 85);
            this.index3_btn.TabIndex = 3;
            this.index3_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.index3_btn.Click += new System.EventHandler(this.index3_btn_Click);
            // 
            // index6_btn
            // 
            this.index6_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.index6_btn.ForeColor = System.Drawing.Color.Coral;
            this.index6_btn.Location = new System.Drawing.Point(17, 230);
            this.index6_btn.Name = "index6_btn";
            this.index6_btn.Size = new System.Drawing.Size(100, 85);
            this.index6_btn.TabIndex = 3;
            this.index6_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.index6_btn.Click += new System.EventHandler(this.index6_btn_Click);
            // 
            // index7_btn
            // 
            this.index7_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.index7_btn.ForeColor = System.Drawing.Color.Coral;
            this.index7_btn.Location = new System.Drawing.Point(137, 230);
            this.index7_btn.Name = "index7_btn";
            this.index7_btn.Size = new System.Drawing.Size(100, 85);
            this.index7_btn.TabIndex = 3;
            this.index7_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.index7_btn.Click += new System.EventHandler(this.index7_btn_Click);
            // 
            // index8_btn
            // 
            this.index8_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.index8_btn.ForeColor = System.Drawing.Color.Coral;
            this.index8_btn.Location = new System.Drawing.Point(258, 230);
            this.index8_btn.Name = "index8_btn";
            this.index8_btn.Size = new System.Drawing.Size(100, 85);
            this.index8_btn.TabIndex = 3;
            this.index8_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.index8_btn.Click += new System.EventHandler(this.index8_btn_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // splashTimer
            // 
            this.splashTimer.Interval = 5000;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 347);
            this.Controls.Add(this.index4_btn);
            this.Controls.Add(this.index3_btn);
            this.Controls.Add(this.index8_btn);
            this.Controls.Add(this.index7_btn);
            this.Controls.Add(this.index6_btn);
            this.Controls.Add(this.index5_btn);
            this.Controls.Add(this.index2_btn);
            this.Controls.Add(this.index0_btn);
            this.Controls.Add(this.index1_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameMenu;
        private System.Windows.Forms.ToolStripMenuItem retryGameBtn;
        private System.Windows.Forms.ToolStripMenuItem closeGame_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label index1_btn;
        private System.Windows.Forms.Label index0_btn;
        private System.Windows.Forms.Label index2_btn;
        private System.Windows.Forms.Label index5_btn;
        private System.Windows.Forms.Label index4_btn;
        private System.Windows.Forms.Label index3_btn;
        private System.Windows.Forms.Label index6_btn;
        private System.Windows.Forms.Label index7_btn;
        private System.Windows.Forms.Label index8_btn;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer splashTimer;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}


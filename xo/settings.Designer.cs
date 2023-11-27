namespace xo
{
    partial class settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseLineColor_btn = new System.Windows.Forms.Button();
            this.chooseXcolor_btn = new System.Windows.Forms.Button();
            this.chooseOcolor_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.LineColorLabel = new System.Windows.Forms.Label();
            this.xColorLabel = new System.Windows.Forms.Label();
            this.oColorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(88, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Line Color : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(88, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "X Color : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(88, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "O Color : ";
            // 
            // chooseLineColor_btn
            // 
            this.chooseLineColor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chooseLineColor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chooseLineColor_btn.ForeColor = System.Drawing.Color.White;
            this.chooseLineColor_btn.Location = new System.Drawing.Point(211, 65);
            this.chooseLineColor_btn.Name = "chooseLineColor_btn";
            this.chooseLineColor_btn.Size = new System.Drawing.Size(103, 39);
            this.chooseLineColor_btn.TabIndex = 1;
            this.chooseLineColor_btn.Text = "choose...";
            this.chooseLineColor_btn.UseVisualStyleBackColor = false;
            this.chooseLineColor_btn.Click += new System.EventHandler(this.chooseLineColor_btn_Click);
            // 
            // chooseXcolor_btn
            // 
            this.chooseXcolor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chooseXcolor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chooseXcolor_btn.ForeColor = System.Drawing.Color.White;
            this.chooseXcolor_btn.Location = new System.Drawing.Point(211, 120);
            this.chooseXcolor_btn.Name = "chooseXcolor_btn";
            this.chooseXcolor_btn.Size = new System.Drawing.Size(103, 39);
            this.chooseXcolor_btn.TabIndex = 1;
            this.chooseXcolor_btn.Text = "choose...";
            this.chooseXcolor_btn.UseVisualStyleBackColor = false;
            this.chooseXcolor_btn.Click += new System.EventHandler(this.chooseXcolor_btn_Click);
            // 
            // chooseOcolor_btn
            // 
            this.chooseOcolor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chooseOcolor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chooseOcolor_btn.ForeColor = System.Drawing.Color.White;
            this.chooseOcolor_btn.Location = new System.Drawing.Point(211, 179);
            this.chooseOcolor_btn.Name = "chooseOcolor_btn";
            this.chooseOcolor_btn.Size = new System.Drawing.Size(103, 39);
            this.chooseOcolor_btn.TabIndex = 1;
            this.chooseOcolor_btn.Text = "choose...";
            this.chooseOcolor_btn.UseVisualStyleBackColor = false;
            this.chooseOcolor_btn.Click += new System.EventHandler(this.chooseOcolor_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(238, 249);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 2;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(109, 249);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // LineColorLabel
            // 
            this.LineColorLabel.Location = new System.Drawing.Point(320, 65);
            this.LineColorLabel.Name = "LineColorLabel";
            this.LineColorLabel.Size = new System.Drawing.Size(45, 39);
            this.LineColorLabel.TabIndex = 3;
            // 
            // xColorLabel
            // 
            this.xColorLabel.Location = new System.Drawing.Point(320, 120);
            this.xColorLabel.Name = "xColorLabel";
            this.xColorLabel.Size = new System.Drawing.Size(45, 39);
            this.xColorLabel.TabIndex = 3;
            // 
            // oColorLabel
            // 
            this.oColorLabel.Location = new System.Drawing.Point(320, 179);
            this.oColorLabel.Name = "oColorLabel";
            this.oColorLabel.Size = new System.Drawing.Size(45, 39);
            this.oColorLabel.TabIndex = 3;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 293);
            this.Controls.Add(this.oColorLabel);
            this.Controls.Add(this.xColorLabel);
            this.Controls.Add(this.LineColorLabel);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.chooseOcolor_btn);
            this.Controls.Add(this.chooseXcolor_btn);
            this.Controls.Add(this.chooseLineColor_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button chooseLineColor_btn;
        private System.Windows.Forms.Button chooseXcolor_btn;
        private System.Windows.Forms.Button chooseOcolor_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label LineColorLabel;
        private System.Windows.Forms.Label xColorLabel;
        private System.Windows.Forms.Label oColorLabel;
    }
}
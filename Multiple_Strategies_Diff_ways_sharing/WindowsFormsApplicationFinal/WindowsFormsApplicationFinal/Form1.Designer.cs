namespace WindowsFormsApplicationFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSmall = new System.Windows.Forms.Label();
            this.labelMed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSmall = new System.Windows.Forms.TextBox();
            this.textBoxMed = new System.Windows.Forms.TextBox();
            this.textBoxLarge = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSmallSize = new System.Windows.Forms.TextBox();
            this.textBoxMediumSize = new System.Windows.Forms.TextBox();
            this.textBoxLargeSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number of Small, Medium and Large sized clusters";
            // 
            // labelSmall
            // 
            this.labelSmall.AutoSize = true;
            this.labelSmall.Location = new System.Drawing.Point(17, 65);
            this.labelSmall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSmall.Name = "labelSmall";
            this.labelSmall.Size = new System.Drawing.Size(42, 17);
            this.labelSmall.TabIndex = 1;
            this.labelSmall.Text = "Small";
            // 
            // labelMed
            // 
            this.labelMed.AutoSize = true;
            this.labelMed.Location = new System.Drawing.Point(17, 97);
            this.labelMed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMed.Name = "labelMed";
            this.labelMed.Size = new System.Drawing.Size(57, 17);
            this.labelMed.TabIndex = 2;
            this.labelMed.Text = "Medium";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Large";
            // 
            // textBoxSmall
            // 
            this.textBoxSmall.Location = new System.Drawing.Point(105, 65);
            this.textBoxSmall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSmall.Name = "textBoxSmall";
            this.textBoxSmall.Size = new System.Drawing.Size(132, 22);
            this.textBoxSmall.TabIndex = 4;
            // 
            // textBoxMed
            // 
            this.textBoxMed.Location = new System.Drawing.Point(105, 97);
            this.textBoxMed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMed.Name = "textBoxMed";
            this.textBoxMed.Size = new System.Drawing.Size(132, 22);
            this.textBoxMed.TabIndex = 5;
            // 
            // textBoxLarge
            // 
            this.textBoxLarge.Location = new System.Drawing.Point(105, 130);
            this.textBoxLarge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLarge.Name = "textBoxLarge";
            this.textBoxLarge.Size = new System.Drawing.Size(132, 22);
            this.textBoxLarge.TabIndex = 6;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(171, 383);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(160, 28);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "Graph!";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "of Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "of Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "of Size";
            // 
            // textBoxSmallSize
            // 
            this.textBoxSmallSize.Location = new System.Drawing.Point(308, 62);
            this.textBoxSmallSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSmallSize.Name = "textBoxSmallSize";
            this.textBoxSmallSize.Size = new System.Drawing.Size(132, 22);
            this.textBoxSmallSize.TabIndex = 17;
            // 
            // textBoxMediumSize
            // 
            this.textBoxMediumSize.Location = new System.Drawing.Point(308, 97);
            this.textBoxMediumSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMediumSize.Name = "textBoxMediumSize";
            this.textBoxMediumSize.Size = new System.Drawing.Size(132, 22);
            this.textBoxMediumSize.TabIndex = 18;
            // 
            // textBoxLargeSize
            // 
            this.textBoxLargeSize.Location = new System.Drawing.Point(308, 130);
            this.textBoxLargeSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLargeSize.Name = "textBoxLargeSize";
            this.textBoxLargeSize.Size = new System.Drawing.Size(132, 22);
            this.textBoxLargeSize.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 448);
            this.Controls.Add(this.textBoxLargeSize);
            this.Controls.Add(this.textBoxMediumSize);
            this.Controls.Add(this.textBoxSmallSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxLarge);
            this.Controls.Add(this.textBoxMed);
            this.Controls.Add(this.textBoxSmall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMed);
            this.Controls.Add(this.labelSmall);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Social Network Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSmall;
        private System.Windows.Forms.Label labelMed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSmall;
        private System.Windows.Forms.TextBox textBoxMed;
        private System.Windows.Forms.TextBox textBoxLarge;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSmallSize;
        private System.Windows.Forms.TextBox textBoxMediumSize;
        private System.Windows.Forms.TextBox textBoxLargeSize;
    }
}


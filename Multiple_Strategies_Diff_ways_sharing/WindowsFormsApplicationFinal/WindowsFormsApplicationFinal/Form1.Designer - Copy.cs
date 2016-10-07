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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInterestTopics = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProbablity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textIndexofsendNode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Input for Small, Medium and Large sized clusters";
            // 
            // labelSmall
            // 
            this.labelSmall.AutoSize = true;
            this.labelSmall.Location = new System.Drawing.Point(13, 53);
            this.labelSmall.Name = "labelSmall";
            this.labelSmall.Size = new System.Drawing.Size(32, 13);
            this.labelSmall.TabIndex = 1;
            this.labelSmall.Text = "Small";
            // 
            // labelMed
            // 
            this.labelMed.AutoSize = true;
            this.labelMed.Location = new System.Drawing.Point(13, 79);
            this.labelMed.Name = "labelMed";
            this.labelMed.Size = new System.Drawing.Size(44, 13);
            this.labelMed.TabIndex = 2;
            this.labelMed.Text = "Medium";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Large";
            // 
            // textBoxSmall
            // 
            this.textBoxSmall.Location = new System.Drawing.Point(79, 53);
            this.textBoxSmall.Name = "textBoxSmall";
            this.textBoxSmall.Size = new System.Drawing.Size(100, 20);
            this.textBoxSmall.TabIndex = 4;
            // 
            // textBoxMed
            // 
            this.textBoxMed.Location = new System.Drawing.Point(79, 79);
            this.textBoxMed.Name = "textBoxMed";
            this.textBoxMed.Size = new System.Drawing.Size(100, 20);
            this.textBoxMed.TabIndex = 5;
            // 
            // textBoxLarge
            // 
            this.textBoxLarge.Location = new System.Drawing.Point(79, 106);
            this.textBoxLarge.Name = "textBoxLarge";
            this.textBoxLarge.Size = new System.Drawing.Size(100, 20);
            this.textBoxLarge.TabIndex = 6;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(201, 332);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(120, 23);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "Graph!";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Interest Topics";
            // 
            // textBoxInterestTopics
            // 
            this.textBoxInterestTopics.Location = new System.Drawing.Point(148, 151);
            this.textBoxInterestTopics.Name = "textBoxInterestTopics";
            this.textBoxInterestTopics.Size = new System.Drawing.Size(100, 20);
            this.textBoxInterestTopics.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Probablity for each Interest Topic line by line";
            // 
            // textBoxProbablity
            // 
            this.textBoxProbablity.Location = new System.Drawing.Point(16, 203);
            this.textBoxProbablity.Multiline = true;
            this.textBoxProbablity.Name = "textBoxProbablity";
            this.textBoxProbablity.Size = new System.Drawing.Size(305, 69);
            this.textBoxProbablity.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter Index of Node to Send Message to: ";
            // 
            // textIndexofsendNode
            // 
            this.textIndexofsendNode.Location = new System.Drawing.Point(225, 290);
            this.textIndexofsendNode.Name = "textIndexofsendNode";
            this.textIndexofsendNode.Size = new System.Drawing.Size(100, 20);
            this.textIndexofsendNode.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 367);
            this.Controls.Add(this.textIndexofsendNode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxProbablity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxInterestTopics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxLarge);
            this.Controls.Add(this.textBoxMed);
            this.Controls.Add(this.textBoxSmall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMed);
            this.Controls.Add(this.labelSmall);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInterestTopics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProbablity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textIndexofsendNode;
    }
}


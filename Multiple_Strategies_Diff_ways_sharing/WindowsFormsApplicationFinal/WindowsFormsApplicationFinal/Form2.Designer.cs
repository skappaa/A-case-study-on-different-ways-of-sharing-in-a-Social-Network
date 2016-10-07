namespace WindowsFormsApplicationFinal
{
    partial class Form2
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
        public void InitializeComponent()
        {
            this.textBoxMessageType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textIndexofsendNode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.strategy1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.strategy6 = new System.Windows.Forms.RadioButton();
            this.strategy5 = new System.Windows.Forms.RadioButton();
            this.strategy4 = new System.Windows.Forms.RadioButton();
            this.strategy3 = new System.Windows.Forms.RadioButton();
            this.strategy2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RelevanceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noOfSecs = new System.Windows.Forms.TextBox();
            this.noOfNodes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMessageType
            // 
            this.textBoxMessageType.Location = new System.Drawing.Point(510, 72);
            this.textBoxMessageType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMessageType.Name = "textBoxMessageType";
            this.textBoxMessageType.Size = new System.Drawing.Size(148, 26);
            this.textBoxMessageType.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Enter category of Message:";
            // 
            // textIndexofsendNode
            // 
            this.textIndexofsendNode.Location = new System.Drawing.Point(510, 206);
            this.textIndexofsendNode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textIndexofsendNode.Name = "textIndexofsendNode";
            this.textIndexofsendNode.Size = new System.Drawing.Size(148, 26);
            this.textIndexofsendNode.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Enter Index of Node to Send Message to: ";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(273, 737);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(112, 35);
            this.buttonSend.TabIndex = 30;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Choose the strategey:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // strategy1
            // 
            this.strategy1.AutoSize = true;
            this.strategy1.Location = new System.Drawing.Point(9, 27);
            this.strategy1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.strategy1.Name = "strategy1";
            this.strategy1.Size = new System.Drawing.Size(104, 24);
            this.strategy1.TabIndex = 33;
            this.strategy1.TabStop = true;
            this.strategy1.Text = "strategy 1";
            this.strategy1.UseVisualStyleBackColor = true;
            this.strategy1.Visible = false;
            this.strategy1.CheckedChanged += new System.EventHandler(this.strategy1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown6);
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.strategy6);
            this.groupBox1.Controls.Add(this.strategy5);
            this.groupBox1.Controls.Add(this.strategy4);
            this.groupBox1.Controls.Add(this.strategy3);
            this.groupBox1.Controls.Add(this.strategy2);
            this.groupBox1.Controls.Add(this.strategy1);
            this.groupBox1.Location = new System.Drawing.Point(338, 398);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 235);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "strategies";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(155, 187);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown6.TabIndex = 44;
            this.numericUpDown6.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown6.Click += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(155, 155);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown5.TabIndex = 43;
            this.numericUpDown5.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown5.Click += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(155, 123);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown4.TabIndex = 42;
            this.numericUpDown4.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown4.Click += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(155, 91);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown3.TabIndex = 42;
            this.numericUpDown3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Click += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(155, 59);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown2.TabIndex = 41;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Click += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(155, 27);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown1.TabIndex = 40;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // strategy6
            // 
            this.strategy6.AutoSize = true;
            this.strategy6.Location = new System.Drawing.Point(9, 189);
            this.strategy6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.strategy6.Name = "strategy6";
            this.strategy6.Size = new System.Drawing.Size(104, 24);
            this.strategy6.TabIndex = 38;
            this.strategy6.TabStop = true;
            this.strategy6.Text = "strategy 6";
            this.strategy6.UseVisualStyleBackColor = true;
            this.strategy6.Visible = false;
            this.strategy6.CheckedChanged += new System.EventHandler(this.strategy6_CheckedChanged);
            // 
            // strategy5
            // 
            this.strategy5.AutoSize = true;
            this.strategy5.Location = new System.Drawing.Point(9, 155);
            this.strategy5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.strategy5.Name = "strategy5";
            this.strategy5.Size = new System.Drawing.Size(104, 24);
            this.strategy5.TabIndex = 37;
            this.strategy5.TabStop = true;
            this.strategy5.Text = "strategy 5";
            this.strategy5.UseVisualStyleBackColor = true;
            this.strategy5.Visible = false;
            this.strategy5.CheckedChanged += new System.EventHandler(this.strategy5_CheckedChanged_1);
            // 
            // strategy4
            // 
            this.strategy4.AutoSize = true;
            this.strategy4.Location = new System.Drawing.Point(9, 123);
            this.strategy4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.strategy4.Name = "strategy4";
            this.strategy4.Size = new System.Drawing.Size(104, 24);
            this.strategy4.TabIndex = 36;
            this.strategy4.TabStop = true;
            this.strategy4.Text = "strategy 4";
            this.strategy4.UseVisualStyleBackColor = true;
            this.strategy4.Visible = false;
            this.strategy4.CheckedChanged += new System.EventHandler(this.strategy4_CheckedChanged);
            // 
            // strategy3
            // 
            this.strategy3.AutoSize = true;
            this.strategy3.Location = new System.Drawing.Point(9, 91);
            this.strategy3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.strategy3.Name = "strategy3";
            this.strategy3.Size = new System.Drawing.Size(104, 24);
            this.strategy3.TabIndex = 35;
            this.strategy3.TabStop = true;
            this.strategy3.Text = "strategy 3";
            this.strategy3.UseVisualStyleBackColor = true;
            this.strategy3.Visible = false;
            this.strategy3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // strategy2
            // 
            this.strategy2.AutoSize = true;
            this.strategy2.Location = new System.Drawing.Point(9, 59);
            this.strategy2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.strategy2.Name = "strategy2";
            this.strategy2.Size = new System.Drawing.Size(104, 24);
            this.strategy2.TabIndex = 34;
            this.strategy2.TabStop = true;
            this.strategy2.Text = "strategy 2";
            this.strategy2.UseVisualStyleBackColor = true;
            this.strategy2.Visible = false;
            this.strategy2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Enter relevance score of the Message:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RelevanceTextBox
            // 
            this.RelevanceTextBox.Location = new System.Drawing.Point(510, 137);
            this.RelevanceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RelevanceTextBox.Name = "RelevanceTextBox";
            this.RelevanceTextBox.Size = new System.Drawing.Size(148, 26);
            this.RelevanceTextBox.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Enter total number of Nodes to Send Message to: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Enter the numbers of seconds to run program: ";
            // 
            // noOfSecs
            // 
            this.noOfSecs.Location = new System.Drawing.Point(510, 325);
            this.noOfSecs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noOfSecs.Name = "noOfSecs";
            this.noOfSecs.Size = new System.Drawing.Size(148, 26);
            this.noOfSecs.TabIndex = 39;
            // 
            // noOfNodes
            // 
            this.noOfNodes.Location = new System.Drawing.Point(510, 269);
            this.noOfNodes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noOfNodes.Name = "noOfNodes";
            this.noOfNodes.Size = new System.Drawing.Size(148, 26);
            this.noOfNodes.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Strategy 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Strategy 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Strategy 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Strategy 4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Strategy 5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "Strategy 6";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 854);
            this.Controls.Add(this.noOfNodes);
            this.Controls.Add(this.noOfSecs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RelevanceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMessageType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textIndexofsendNode);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxMessageType;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textIndexofsendNode;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button buttonSend;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton strategy1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton strategy4;
        public System.Windows.Forms.RadioButton strategy3;
        public System.Windows.Forms.RadioButton strategy2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox RelevanceTextBox;
        public System.Windows.Forms.RadioButton strategy5;
        public System.Windows.Forms.RadioButton strategy6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox noOfSecs;
        public System.Windows.Forms.TextBox noOfNodes;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
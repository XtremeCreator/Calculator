namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            label4 = new Label();
            btnClear = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            lblAnswer = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSecondNum = new TextBox();
            txtFirstNum = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDivide);
            panel1.Controls.Add(btnMultiply);
            panel1.Controls.Add(btnSubtract);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblAnswer);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSecondNum);
            panel1.Controls.Add(txtFirstNum);
            panel1.Location = new Point(10, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 426);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(245, 1);
            button1.Name = "button1";
            button1.Size = new Size(29, 26);
            button1.TabIndex = 12;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 16);
            label4.Name = "label4";
            label4.Size = new Size(191, 38);
            label4.TabIndex = 11;
            label4.Text = "CALCULATOR";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.Enabled = false;
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(80, 340);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 41);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.GradientActiveCaption;
            btnDivide.Enabled = false;
            btnDivide.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(220, 273);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(47, 41);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.GradientActiveCaption;
            btnMultiply.Enabled = false;
            btnMultiply.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(152, 273);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(47, 41);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = SystemColors.GradientActiveCaption;
            btnSubtract.Enabled = false;
            btnSubtract.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtract.Location = new Point(82, 273);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(47, 41);
            btnSubtract.TabIndex = 7;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.GradientActiveCaption;
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(9, 273);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(47, 41);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.BackColor = SystemColors.ButtonHighlight;
            lblAnswer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer.Location = new Point(144, 196);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(27, 20);
            lblAnswer.TabIndex = 5;
            lblAnswer.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 196);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Answer :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 139);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 3;
            label2.Text = "Second Number :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 85);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 2;
            label1.Text = "First Number :";
            // 
            // txtSecondNum
            // 
            txtSecondNum.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSecondNum.Location = new Point(144, 132);
            txtSecondNum.Name = "txtSecondNum";
            txtSecondNum.Size = new Size(125, 27);
            txtSecondNum.TabIndex = 1;
            txtSecondNum.TextChanged += txtSecondNum_TextChanged;
            // 
            // txtFirstNum
            // 
            txtFirstNum.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFirstNum.Location = new Point(144, 78);
            txtFirstNum.Name = "txtFirstNum";
            txtFirstNum.Size = new Size(125, 27);
            txtFirstNum.TabIndex = 0;
            txtFirstNum.TextChanged += txtFirstNum_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(299, 454);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private Label lblAnswer;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSecondNum;
        private TextBox txtFirstNum;
        private Button btnClear;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Label label4;
        private Button button1;
    }
}

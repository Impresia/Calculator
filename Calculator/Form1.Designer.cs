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
            Result = new TextBox();
            btnUnary = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn1SlashX = new Button();
            btnPercent = new Button();
            btnSqr = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn0 = new Button();
            btnClearAll = new Button();
            btnSqrt = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btnPoint = new Button();
            btnClear = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // Result
            // 
            Result.BackColor = Color.DarkSlateGray;
            Result.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Result.ForeColor = SystemColors.Window;
            Result.Location = new Point(1, 28);
            Result.MaxLength = 16;
            Result.Multiline = true;
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(318, 89);
            Result.TabIndex = 24;
            // 
            // btnUnary
            // 
            btnUnary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUnary.BackColor = Color.DarkCyan;
            btnUnary.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUnary.ForeColor = SystemColors.Info;
            btnUnary.Location = new Point(1, 430);
            btnUnary.Name = "btnUnary";
            btnUnary.Size = new Size(82, 59);
            btnUnary.TabIndex = 0;
            btnUnary.Text = "+/-";
            btnUnary.UseVisualStyleBackColor = false;
            btnUnary.Click += btnUnary_Click;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn1.BackColor = Color.DarkCyan;
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.Info;
            btn1.Location = new Point(1, 374);
            btn1.Name = "btn1";
            btn1.Size = new Size(82, 59);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn4.BackColor = Color.DarkCyan;
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.ForeColor = SystemColors.Info;
            btn4.Location = new Point(1, 319);
            btn4.Name = "btn4";
            btn4.Size = new Size(82, 59);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn7
            // 
            btn7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn7.BackColor = Color.DarkCyan;
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.ForeColor = SystemColors.Info;
            btn7.Location = new Point(1, 263);
            btn7.Name = "btn7";
            btn7.Size = new Size(82, 59);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn1SlashX
            // 
            btn1SlashX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn1SlashX.BackColor = Color.SeaGreen;
            btn1SlashX.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1SlashX.ForeColor = SystemColors.Info;
            btn1SlashX.Location = new Point(1, 208);
            btn1SlashX.Name = "btn1SlashX";
            btn1SlashX.Size = new Size(82, 59);
            btn1SlashX.TabIndex = 4;
            btn1SlashX.Text = "1/x";
            btn1SlashX.UseVisualStyleBackColor = false;
            btn1SlashX.Click += btn1SlashX_Click;
            // 
            // btnPercent
            // 
            btnPercent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPercent.BackColor = Color.SeaGreen;
            btnPercent.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPercent.ForeColor = SystemColors.Info;
            btnPercent.Location = new Point(1, 154);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(82, 59);
            btnPercent.TabIndex = 5;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnSqr
            // 
            btnSqr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSqr.BackColor = Color.SeaGreen;
            btnSqr.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSqr.ForeColor = SystemColors.Info;
            btnSqr.Location = new Point(79, 208);
            btnSqr.Name = "btnSqr";
            btnSqr.Size = new Size(82, 59);
            btnSqr.TabIndex = 10;
            btnSqr.Text = "x²";
            btnSqr.UseVisualStyleBackColor = false;
            btnSqr.Click += btnSqr_Click;
            // 
            // btn8
            // 
            btn8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn8.BackColor = Color.DarkCyan;
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.ForeColor = SystemColors.Info;
            btn8.Location = new Point(79, 263);
            btn8.Name = "btn8";
            btn8.Size = new Size(82, 59);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn5.BackColor = Color.DarkCyan;
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.ForeColor = SystemColors.Info;
            btn5.Location = new Point(79, 319);
            btn5.Name = "btn5";
            btn5.Size = new Size(82, 59);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn2.BackColor = Color.DarkCyan;
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = SystemColors.Info;
            btn2.Location = new Point(79, 374);
            btn2.Name = "btn2";
            btn2.Size = new Size(82, 59);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn0
            // 
            btn0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn0.BackColor = Color.DarkCyan;
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.ForeColor = SystemColors.Info;
            btn0.Location = new Point(79, 430);
            btn0.Name = "btn0";
            btn0.Size = new Size(82, 59);
            btn0.TabIndex = 6;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClearAll.BackColor = Color.SeaGreen;
            btnClearAll.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearAll.ForeColor = SystemColors.Info;
            btnClearAll.Location = new Point(79, 154);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(161, 59);
            btnClearAll.TabIndex = 17;
            btnClearAll.Text = "C";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSqrt.BackColor = Color.SeaGreen;
            btnSqrt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSqrt.ForeColor = SystemColors.Info;
            btnSqrt.Location = new Point(158, 208);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(82, 59);
            btnSqrt.TabIndex = 16;
            btnSqrt.Text = "√x";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btn9
            // 
            btn9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn9.BackColor = Color.DarkCyan;
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.ForeColor = SystemColors.Info;
            btn9.Location = new Point(158, 263);
            btn9.Name = "btn9";
            btn9.Size = new Size(82, 59);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn6.AutoSize = true;
            btn6.BackColor = Color.DarkCyan;
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.ForeColor = SystemColors.Info;
            btn6.Location = new Point(158, 319);
            btn6.Name = "btn6";
            btn6.Size = new Size(82, 59);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn3.BackColor = Color.DarkCyan;
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = SystemColors.Info;
            btn3.Location = new Point(158, 374);
            btn3.Name = "btn3";
            btn3.Size = new Size(82, 59);
            btn3.TabIndex = 13;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnPoint
            // 
            btnPoint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPoint.BackColor = Color.DarkCyan;
            btnPoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPoint.ForeColor = SystemColors.Info;
            btnPoint.Location = new Point(158, 430);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(82, 59);
            btnPoint.TabIndex = 12;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = false;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.BackColor = Color.SeaGreen;
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.Info;
            btnClear.Location = new Point(237, 154);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 59);
            btnClear.TabIndex = 23;
            btnClear.Text = "⌫";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDivide
            // 
            btnDivide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDivide.BackColor = Color.SeaGreen;
            btnDivide.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.ForeColor = SystemColors.Info;
            btnDivide.Location = new Point(237, 208);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(82, 59);
            btnDivide.TabIndex = 22;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMultiply.BackColor = Color.SeaGreen;
            btnMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiply.ForeColor = SystemColors.Info;
            btnMultiply.Location = new Point(237, 263);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(82, 59);
            btnMultiply.TabIndex = 21;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnMinus
            // 
            btnMinus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMinus.BackColor = Color.SeaGreen;
            btnMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.ForeColor = SystemColors.Info;
            btnMinus.Location = new Point(237, 319);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(82, 59);
            btnMinus.TabIndex = 20;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPlus.BackColor = Color.SeaGreen;
            btnPlus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.ForeColor = SystemColors.Info;
            btnPlus.Location = new Point(237, 374);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(82, 59);
            btnPlus.TabIndex = 19;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEqual
            // 
            btnEqual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEqual.BackColor = Color.SeaGreen;
            btnEqual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqual.ForeColor = SystemColors.Info;
            btnEqual.Location = new Point(237, 430);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(82, 59);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(318, 486);
            Controls.Add(Result);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnEqual);
            Controls.Add(btnClearAll);
            Controls.Add(btnSqrt);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btnPoint);
            Controls.Add(btnSqr);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn0);
            Controls.Add(btnPercent);
            Controls.Add(btn1SlashX);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btnUnary);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(334, 525);
            MinimumSize = new Size(334, 525);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUnary;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btn1SlashX;
        private Button btnPercent;
        private Button btnSqr;
        private Button btn8;
        private Button btn5;
        private Button btn2;
        private Button btn0;
        private Button btnClearAll;
        private Button btnSqrt;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btnPoint;
        private Button btnClear;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnEqual;
        private TextBox Result;
    }
}
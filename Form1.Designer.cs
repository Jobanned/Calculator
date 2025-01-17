namespace calculatorrr
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            txtDisplay = new TextBox();
            btnClear = new Button();
            btnZero = new Button();
            btnDot = new Button();
            btnPlus = new Button();
            btnEquals = new Button();
            btnSubtract = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnDelete = new Button();
            btnPlusMinus = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.FromArgb(32, 32, 32);
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(23, 25);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(464, 67);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(50, 50, 50);
            btnClear.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.LightGray;
            btnClear.Location = new Point(23, 373);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 73);
            btnClear.TabIndex = 1;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.FromArgb(50, 50, 50);
            btnZero.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZero.ForeColor = Color.LightGray;
            btnZero.Location = new Point(113, 373);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(84, 73);
            btnZero.TabIndex = 2;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnNum_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(50, 50, 50);
            btnDot.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDot.ForeColor = Color.LightGray;
            btnDot.Location = new Point(203, 373);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(84, 73);
            btnDot.TabIndex = 3;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(64, 64, 64);
            btnPlus.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            btnPlus.ForeColor = Color.Silver;
            btnPlus.Location = new Point(309, 373);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(84, 73);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnOperation_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.FromArgb(64, 64, 64);
            btnEquals.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            btnEquals.ForeColor = Color.Silver;
            btnEquals.Location = new Point(399, 294);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(84, 152);
            btnEquals.TabIndex = 10;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(64, 64, 64);
            btnSubtract.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            btnSubtract.ForeColor = Color.Silver;
            btnSubtract.Location = new Point(309, 294);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(84, 73);
            btnSubtract.TabIndex = 9;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnOperation_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.FromArgb(50, 50, 50);
            btnThree.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThree.ForeColor = Color.LightGray;
            btnThree.Location = new Point(203, 294);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(84, 73);
            btnThree.TabIndex = 8;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnNum_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.FromArgb(50, 50, 50);
            btnTwo.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTwo.ForeColor = Color.LightGray;
            btnTwo.Location = new Point(113, 294);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(84, 73);
            btnTwo.TabIndex = 7;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnNum_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.FromArgb(50, 50, 50);
            btnOne.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOne.ForeColor = Color.LightGray;
            btnOne.Location = new Point(23, 294);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(84, 73);
            btnOne.TabIndex = 6;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnNum_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(64, 64, 64);
            btnDivide.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            btnDivide.ForeColor = Color.Silver;
            btnDivide.Location = new Point(399, 215);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(84, 73);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnOperation_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(64, 64, 64);
            btnMultiply.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            btnMultiply.ForeColor = Color.Silver;
            btnMultiply.Location = new Point(309, 215);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(84, 73);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnOperation_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.FromArgb(50, 50, 50);
            btnSix.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSix.ForeColor = Color.LightGray;
            btnSix.Location = new Point(203, 215);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(84, 73);
            btnSix.TabIndex = 13;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnNum_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.FromArgb(50, 50, 50);
            btnFive.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFive.ForeColor = Color.LightGray;
            btnFive.Location = new Point(113, 215);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(84, 73);
            btnFive.TabIndex = 12;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnNum_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.FromArgb(50, 50, 50);
            btnFour.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFour.ForeColor = Color.LightGray;
            btnFour.Location = new Point(23, 215);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(84, 73);
            btnFour.TabIndex = 11;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnNum_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Silver;
            btnDelete.Location = new Point(399, 136);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 73);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = Color.FromArgb(64, 64, 64);
            btnPlusMinus.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            btnPlusMinus.ForeColor = Color.Silver;
            btnPlusMinus.Location = new Point(309, 136);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(84, 73);
            btnPlusMinus.TabIndex = 19;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.FromArgb(50, 50, 50);
            btnNine.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNine.ForeColor = Color.LightGray;
            btnNine.Location = new Point(203, 136);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(84, 73);
            btnNine.TabIndex = 18;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNum_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.FromArgb(50, 50, 50);
            btnEight.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEight.ForeColor = Color.LightGray;
            btnEight.Location = new Point(113, 136);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(84, 73);
            btnEight.TabIndex = 17;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnNum_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.FromArgb(50, 50, 50);
            btnSeven.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeven.ForeColor = Color.LightGray;
            btnSeven.Location = new Point(23, 136);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(84, 73);
            btnSeven.TabIndex = 16;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnNum_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(507, 466);
            Controls.Add(btnDelete);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnEquals);
            Controls.Add(btnSubtract);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnPlus);
            Controls.Add(btnDot);
            Controls.Add(btnZero);
            Controls.Add(btnClear);
            Controls.Add(txtDisplay);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Click += btnOperation_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnClear;
        private Button btnZero;
        private Button btnDot;
        private Button btnPlus;
        private Button btnEquals;
        private Button btnSubtract;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnDelete;
        private Button btnPlusMinus;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
    }
}

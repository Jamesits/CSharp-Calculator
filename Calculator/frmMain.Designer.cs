using System.ComponentModel;
using System.Windows.Forms;

namespace Calculator
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.LabelExpression = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelExpression
            // 
            this.LabelExpression.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LabelExpression.Location = new System.Drawing.Point(0, 0);
            this.LabelExpression.Margin = new System.Windows.Forms.Padding(0);
            this.LabelExpression.Name = "LabelExpression";
            this.LabelExpression.Size = new System.Drawing.Size(322, 75);
            this.LabelExpression.TabIndex = 21;
            this.LabelExpression.Text = "Expression";
            this.LabelExpression.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LabelResult
            // 
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResult.Location = new System.Drawing.Point(0, 84);
            this.LabelResult.Margin = new System.Windows.Forms.Padding(0);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(322, 53);
            this.LabelResult.TabIndex = 1;
            this.LabelResult.Text = "Number";
            this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.Window;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(240, 457);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(0);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(82, 55);
            this.btnEqual.TabIndex = 2;
            this.btnEqual.Text = "=";
            this.btnEqual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Window;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(240, 402);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(82, 55);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.Window;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(240, 347);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(82, 55);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.BackColor = System.Drawing.SystemColors.Window;
            this.btnMultiple.FlatAppearance.BorderSize = 0;
            this.btnMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiple.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiple.Location = new System.Drawing.Point(240, 292);
            this.btnMultiple.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(82, 55);
            this.btnMultiple.TabIndex = 5;
            this.btnMultiple.Text = "*";
            this.btnMultiple.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.Window;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(240, 237);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(82, 55);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "/";
            this.btnDivide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.Window;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(158, 457);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(82, 55);
            this.btnDot.TabIndex = 7;
            this.btnDot.Text = ".";
            this.btnDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.Window;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(76, 457);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(82, 55);
            this.btn0.TabIndex = 8;
            this.btn0.Text = "0";
            this.btn0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.SystemColors.Window;
            this.btnPlusMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.Location = new System.Drawing.Point(0, 457);
            this.btnPlusMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(82, 55);
            this.btnPlusMinus.TabIndex = 9;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Window;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(0, 402);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(82, 55);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Window;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(76, 402);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(82, 55);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Window;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(158, 402);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(82, 55);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Window;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(158, 347);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(82, 55);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.Window;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(158, 292);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(82, 55);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(158, 237);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 55);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "DEL";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Window;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(0, 347);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(82, 55);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "4";
            this.btn4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Window;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(0, 292);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(82, 55);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.Window;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(0, 237);
            this.btnCE.Margin = new System.Windows.Forms.Padding(0);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(82, 55);
            this.btnCE.TabIndex = 18;
            this.btnCE.Text = "CE";
            this.btnCE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Window;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(76, 347);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(82, 55);
            this.btn5.TabIndex = 19;
            this.btn5.Text = "5";
            this.btn5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Window;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(76, 292);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(82, 55);
            this.btn8.TabIndex = 20;
            this.btn8.Text = "8";
            this.btn8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.Window;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(76, 237);
            this.btnC.Margin = new System.Windows.Forms.Padding(0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(82, 55);
            this.btnC.TabIndex = 22;
            this.btnC.Text = "C";
            this.btnC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btns_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(321, 513);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.LabelExpression);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LabelExpression;
        private Label LabelResult;
        private Button btnEqual;
        private Button btnCE;
        private Button btn5;
        private Button btn8;
        private Button btn7;
        private Button btn4;
        private Button btnDelete;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnPlusMinus;
        private Button btn0;
        private Button btnDot;
        private Button btnDivide;
        private Button btnMultiple;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnC;
    }
}


namespace Hesap_Makinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnC = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.btnC, "btnC");
            this.btnC.Name = "btnC";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn7, "btn7");
            this.btn7.Name = "btn7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.numbersAction);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn4, "btn4");
            this.btn4.Name = "btn4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.numbersAction);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.Name = "btn1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.numbersAction);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn3, "btn3");
            this.btn3.Name = "btn3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.numbersAction);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn6, "btn6");
            this.btn6.Name = "btn6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.numbersAction);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn9, "btn9");
            this.btn9.Name = "btn9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.numbersAction);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnComma, "btnComma");
            this.btnComma.Name = "btnComma";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn2, "btn2");
            this.btn2.Name = "btn2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.numbersAction);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn5, "btn5");
            this.btn5.Name = "btn5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.numbersAction);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn8, "btn8");
            this.btn8.Name = "btn8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.numbersAction);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn0, "btn0");
            this.btn0.Name = "btn0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.numbersAction);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnMultiplication, "btnMultiplication");
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnMinus, "btnMinus");
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnPlus, "btnPlus");
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnDivide, "btnDivide");
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Khaki;
            resources.ApplyResources(this.btnEqual, "btnEqual");
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btnDel, "btnDel");
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Name = "btnDel";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtResult
            // 
            resources.ApplyResources(this.txtResult, "txtResult");
            this.txtResult.Name = "txtResult";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnC);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button1;
    }
}


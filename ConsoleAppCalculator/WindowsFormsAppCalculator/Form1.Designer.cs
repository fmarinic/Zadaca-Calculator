namespace WindowsFormsAppCalculator
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
            this.lblfirstnumber = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblsecondnumber = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.inptFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.inptSecondNumber = new System.Windows.Forms.NumericUpDown();
            this.inptResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inptFirstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptSecondNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfirstnumber
            // 
            this.lblfirstnumber.AutoSize = true;
            this.lblfirstnumber.Location = new System.Drawing.Point(31, 50);
            this.lblfirstnumber.Name = "lblfirstnumber";
            this.lblfirstnumber.Size = new System.Drawing.Size(64, 17);
            this.lblfirstnumber.TabIndex = 0;
            this.lblfirstnumber.Text = "Prvi broj:";
            this.lblfirstnumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsecondnumber
            // 
            this.lblsecondnumber.AutoSize = true;
            this.lblsecondnumber.Location = new System.Drawing.Point(34, 100);
            this.lblsecondnumber.Name = "lblsecondnumber";
            this.lblsecondnumber.Size = new System.Drawing.Size(74, 17);
            this.lblsecondnumber.TabIndex = 1;
            this.lblsecondnumber.Text = "Drugi broj:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(37, 153);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(60, 17);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "Rezultat";
            // 
            // inptFirstNumber
            // 
            this.inptFirstNumber.Location = new System.Drawing.Point(141, 50);
            this.inptFirstNumber.Name = "inptFirstNumber";
            this.inptFirstNumber.Size = new System.Drawing.Size(120, 22);
            this.inptFirstNumber.TabIndex = 3;
            // 
            // inptSecondNumber
            // 
            this.inptSecondNumber.Location = new System.Drawing.Point(141, 100);
            this.inptSecondNumber.Name = "inptSecondNumber";
            this.inptSecondNumber.Size = new System.Drawing.Size(120, 22);
            this.inptSecondNumber.TabIndex = 4;
            // 
            // inptResult
            // 
            this.inptResult.Enabled = false;
            this.inptResult.Location = new System.Drawing.Point(141, 153);
            this.inptResult.Name = "inptResult";
            this.inptResult.Size = new System.Drawing.Size(100, 22);
            this.inptResult.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(301, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "(+) Zbroji";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(301, 98);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(120, 30);
            this.btnSubstract.TabIndex = 7;
            this.btnSubstract.Text = "(-) Oduzmi";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(301, 146);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(120, 30);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "(*) Pomnozi";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(301, 206);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(120, 30);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "(%) Podijeli";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 312);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inptResult);
            this.Controls.Add(this.inptSecondNumber);
            this.Controls.Add(this.inptFirstNumber);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblsecondnumber);
            this.Controls.Add(this.lblfirstnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inptFirstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptSecondNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstnumber;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblsecondnumber;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.NumericUpDown inptFirstNumber;
        private System.Windows.Forms.NumericUpDown inptSecondNumber;
        private System.Windows.Forms.TextBox inptResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
    }
}


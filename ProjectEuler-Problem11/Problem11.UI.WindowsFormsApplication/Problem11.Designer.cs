namespace Problem11.UI.WindowsFormsApplication
{
    partial class Problem11
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.txtGrid = new System.Windows.Forms.TextBox();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.btnCalcByOpenText = new System.Windows.Forms.Button();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.btnCalcFromFileName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(9, 315);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(138, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult1.Location = new System.Drawing.Point(151, 320);
            this.lblResult1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(52, 18);
            this.lblResult1.TabIndex = 1;
            this.lblResult1.Text = "result1";
            this.lblResult1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGrid
            // 
            this.txtGrid.Location = new System.Drawing.Point(9, 11);
            this.txtGrid.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrid.Multiline = true;
            this.txtGrid.Name = "txtGrid";
            this.txtGrid.Size = new System.Drawing.Size(520, 287);
            this.txtGrid.TabIndex = 2;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult2.Location = new System.Drawing.Point(151, 359);
            this.lblResult2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(52, 18);
            this.lblResult2.TabIndex = 4;
            this.lblResult2.Text = "result2";
            this.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalcByOpenText
            // 
            this.btnCalcByOpenText.Location = new System.Drawing.Point(9, 354);
            this.btnCalcByOpenText.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcByOpenText.Name = "btnCalcByOpenText";
            this.btnCalcByOpenText.Size = new System.Drawing.Size(138, 23);
            this.btnCalcByOpenText.TabIndex = 5;
            this.btnCalcByOpenText.Text = "Calc open text";
            this.btnCalcByOpenText.UseVisualStyleBackColor = true;
            this.btnCalcByOpenText.Click += new System.EventHandler(this.btnCalcByOpenText_Click);
            // 
            // lblResult3
            // 
            this.lblResult3.AutoSize = true;
            this.lblResult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult3.Location = new System.Drawing.Point(153, 397);
            this.lblResult3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(52, 18);
            this.lblResult3.TabIndex = 6;
            this.lblResult3.Text = "result3";
            this.lblResult3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalcFromFileName
            // 
            this.btnCalcFromFileName.Location = new System.Drawing.Point(11, 392);
            this.btnCalcFromFileName.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcFromFileName.Name = "btnCalcFromFileName";
            this.btnCalcFromFileName.Size = new System.Drawing.Size(138, 23);
            this.btnCalcFromFileName.TabIndex = 7;
            this.btnCalcFromFileName.Text = "Calc from file";
            this.btnCalcFromFileName.UseVisualStyleBackColor = true;
            this.btnCalcFromFileName.Click += new System.EventHandler(this.btnCalcFromFileName_Click);
            // 
            // Problem11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 424);
            this.Controls.Add(this.btnCalcFromFileName);
            this.Controls.Add(this.lblResult3);
            this.Controls.Add(this.btnCalcByOpenText);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.txtGrid);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.btnCalc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Problem11";
            this.Text = "Problem11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.TextBox txtGrid;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Button btnCalcByOpenText;
        private System.Windows.Forms.Label lblResult3;
        private System.Windows.Forms.Button btnCalcFromFileName;
    }
}


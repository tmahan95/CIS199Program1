namespace Program1
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
            this.coatsLbl = new System.Windows.Forms.Label();
            this.areaLbl = new System.Windows.Forms.Label();
            this.pricePerGallonLbl = new System.Windows.Forms.Label();
            this.totalSqFtLbl = new System.Windows.Forms.Label();
            this.ttlGallonsLbl = new System.Windows.Forms.Label();
            this.ttlHoursLbl = new System.Windows.Forms.Label();
            this.paintCostLbl = new System.Windows.Forms.Label();
            this.laborCostLbl = new System.Windows.Forms.Label();
            this.ttlCostLbl = new System.Windows.Forms.Label();
            this.inputsGroupBox = new System.Windows.Forms.GroupBox();
            this.ttlSqFtDispLbl = new System.Windows.Forms.Label();
            this.ttlGallonsDispLbl = new System.Windows.Forms.Label();
            this.ttlHoursDispLbl = new System.Windows.Forms.Label();
            this.costPaintDispLbl = new System.Windows.Forms.Label();
            this.laborCostDispLbl = new System.Windows.Forms.Label();
            this.ttlCostDispLbl = new System.Windows.Forms.Label();
            this.areaTxtBox = new System.Windows.Forms.TextBox();
            this.coatsTxtBox = new System.Windows.Forms.TextBox();
            this.priceGallonTxtBox = new System.Windows.Forms.TextBox();
            this.clcJobButton = new System.Windows.Forms.Button();
            this.clearBttn = new System.Windows.Forms.Button();
            this.inputsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // coatsLbl
            // 
            this.coatsLbl.AutoSize = true;
            this.coatsLbl.Location = new System.Drawing.Point(168, 28);
            this.coatsLbl.Name = "coatsLbl";
            this.coatsLbl.Size = new System.Drawing.Size(86, 13);
            this.coatsLbl.TabIndex = 0;
            this.coatsLbl.Text = "Number of Coats";
            // 
            // areaLbl
            // 
            this.areaLbl.AutoSize = true;
            this.areaLbl.Location = new System.Drawing.Point(17, 28);
            this.areaLbl.Name = "areaLbl";
            this.areaLbl.Size = new System.Drawing.Size(69, 13);
            this.areaLbl.TabIndex = 1;
            this.areaLbl.Text = "Area (Sq. Ft.)";
            // 
            // pricePerGallonLbl
            // 
            this.pricePerGallonLbl.AutoSize = true;
            this.pricePerGallonLbl.Location = new System.Drawing.Point(332, 28);
            this.pricePerGallonLbl.Name = "pricePerGallonLbl";
            this.pricePerGallonLbl.Size = new System.Drawing.Size(82, 13);
            this.pricePerGallonLbl.TabIndex = 2;
            this.pricePerGallonLbl.Text = "Price per Gallon";
            // 
            // totalSqFtLbl
            // 
            this.totalSqFtLbl.AutoSize = true;
            this.totalSqFtLbl.Location = new System.Drawing.Point(34, 126);
            this.totalSqFtLbl.Name = "totalSqFtLbl";
            this.totalSqFtLbl.Size = new System.Drawing.Size(62, 13);
            this.totalSqFtLbl.TabIndex = 3;
            this.totalSqFtLbl.Text = "Total Sq.Ft.";
            // 
            // ttlGallonsLbl
            // 
            this.ttlGallonsLbl.AutoSize = true;
            this.ttlGallonsLbl.Location = new System.Drawing.Point(202, 126);
            this.ttlGallonsLbl.Name = "ttlGallonsLbl";
            this.ttlGallonsLbl.Size = new System.Drawing.Size(69, 13);
            this.ttlGallonsLbl.TabIndex = 4;
            this.ttlGallonsLbl.Text = "Total Gallons";
            // 
            // ttlHoursLbl
            // 
            this.ttlHoursLbl.AutoSize = true;
            this.ttlHoursLbl.Location = new System.Drawing.Point(349, 126);
            this.ttlHoursLbl.Name = "ttlHoursLbl";
            this.ttlHoursLbl.Size = new System.Drawing.Size(62, 13);
            this.ttlHoursLbl.TabIndex = 5;
            this.ttlHoursLbl.Text = "Total Hours";
            // 
            // paintCostLbl
            // 
            this.paintCostLbl.AutoSize = true;
            this.paintCostLbl.Location = new System.Drawing.Point(34, 197);
            this.paintCostLbl.Name = "paintCostLbl";
            this.paintCostLbl.Size = new System.Drawing.Size(67, 13);
            this.paintCostLbl.TabIndex = 6;
            this.paintCostLbl.Text = "Cost of Paint";
            // 
            // laborCostLbl
            // 
            this.laborCostLbl.AutoSize = true;
            this.laborCostLbl.Location = new System.Drawing.Point(206, 197);
            this.laborCostLbl.Name = "laborCostLbl";
            this.laborCostLbl.Size = new System.Drawing.Size(70, 13);
            this.laborCostLbl.TabIndex = 7;
            this.laborCostLbl.Text = "Cost of Labor";
            // 
            // ttlCostLbl
            // 
            this.ttlCostLbl.AutoSize = true;
            this.ttlCostLbl.Location = new System.Drawing.Point(349, 197);
            this.ttlCostLbl.Name = "ttlCostLbl";
            this.ttlCostLbl.Size = new System.Drawing.Size(55, 13);
            this.ttlCostLbl.TabIndex = 8;
            this.ttlCostLbl.Text = "Total Cost";
            // 
            // inputsGroupBox
            // 
            this.inputsGroupBox.Controls.Add(this.areaTxtBox);
            this.inputsGroupBox.Controls.Add(this.coatsTxtBox);
            this.inputsGroupBox.Controls.Add(this.priceGallonTxtBox);
            this.inputsGroupBox.Controls.Add(this.areaLbl);
            this.inputsGroupBox.Controls.Add(this.coatsLbl);
            this.inputsGroupBox.Controls.Add(this.pricePerGallonLbl);
            this.inputsGroupBox.Location = new System.Drawing.Point(17, 12);
            this.inputsGroupBox.Name = "inputsGroupBox";
            this.inputsGroupBox.Size = new System.Drawing.Size(457, 100);
            this.inputsGroupBox.TabIndex = 9;
            this.inputsGroupBox.TabStop = false;
            this.inputsGroupBox.Text = "Job Details";
            // 
            // ttlSqFtDispLbl
            // 
            this.ttlSqFtDispLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttlSqFtDispLbl.Location = new System.Drawing.Point(23, 154);
            this.ttlSqFtDispLbl.Name = "ttlSqFtDispLbl";
            this.ttlSqFtDispLbl.Size = new System.Drawing.Size(100, 23);
            this.ttlSqFtDispLbl.TabIndex = 10;
            // 
            // ttlGallonsDispLbl
            // 
            this.ttlGallonsDispLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttlGallonsDispLbl.Location = new System.Drawing.Point(188, 154);
            this.ttlGallonsDispLbl.Name = "ttlGallonsDispLbl";
            this.ttlGallonsDispLbl.Size = new System.Drawing.Size(100, 23);
            this.ttlGallonsDispLbl.TabIndex = 11;
            // 
            // ttlHoursDispLbl
            // 
            this.ttlHoursDispLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttlHoursDispLbl.Location = new System.Drawing.Point(340, 154);
            this.ttlHoursDispLbl.Name = "ttlHoursDispLbl";
            this.ttlHoursDispLbl.Size = new System.Drawing.Size(100, 23);
            this.ttlHoursDispLbl.TabIndex = 12;
            // 
            // costPaintDispLbl
            // 
            this.costPaintDispLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costPaintDispLbl.Location = new System.Drawing.Point(23, 229);
            this.costPaintDispLbl.Name = "costPaintDispLbl";
            this.costPaintDispLbl.Size = new System.Drawing.Size(100, 23);
            this.costPaintDispLbl.TabIndex = 13;
            // 
            // laborCostDispLbl
            // 
            this.laborCostDispLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostDispLbl.Location = new System.Drawing.Point(188, 228);
            this.laborCostDispLbl.Name = "laborCostDispLbl";
            this.laborCostDispLbl.Size = new System.Drawing.Size(100, 23);
            this.laborCostDispLbl.TabIndex = 14;
            // 
            // ttlCostDispLbl
            // 
            this.ttlCostDispLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttlCostDispLbl.Location = new System.Drawing.Point(340, 229);
            this.ttlCostDispLbl.Name = "ttlCostDispLbl";
            this.ttlCostDispLbl.Size = new System.Drawing.Size(100, 23);
            this.ttlCostDispLbl.TabIndex = 15;
            // 
            // areaTxtBox
            // 
            this.areaTxtBox.Location = new System.Drawing.Point(6, 57);
            this.areaTxtBox.Name = "areaTxtBox";
            this.areaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.areaTxtBox.TabIndex = 16;
            // 
            // coatsTxtBox
            // 
            this.coatsTxtBox.Location = new System.Drawing.Point(171, 57);
            this.coatsTxtBox.Name = "coatsTxtBox";
            this.coatsTxtBox.Size = new System.Drawing.Size(100, 20);
            this.coatsTxtBox.TabIndex = 17;
            // 
            // priceGallonTxtBox
            // 
            this.priceGallonTxtBox.Location = new System.Drawing.Point(323, 57);
            this.priceGallonTxtBox.Name = "priceGallonTxtBox";
            this.priceGallonTxtBox.Size = new System.Drawing.Size(100, 20);
            this.priceGallonTxtBox.TabIndex = 18;
            // 
            // clcJobButton
            // 
            this.clcJobButton.Location = new System.Drawing.Point(122, 269);
            this.clcJobButton.Name = "clcJobButton";
            this.clcJobButton.Size = new System.Drawing.Size(75, 39);
            this.clcJobButton.TabIndex = 16;
            this.clcJobButton.Text = "Calculate Job";
            this.clcJobButton.UseVisualStyleBackColor = true;
            this.clcJobButton.Click += new System.EventHandler(this.clcJobButton_Click);
            // 
            // clearBttn
            // 
            this.clearBttn.Location = new System.Drawing.Point(276, 269);
            this.clearBttn.Name = "clearBttn";
            this.clearBttn.Size = new System.Drawing.Size(75, 39);
            this.clearBttn.TabIndex = 17;
            this.clearBttn.Text = "Clear";
            this.clearBttn.UseVisualStyleBackColor = true;
            this.clearBttn.Click += new System.EventHandler(this.clearBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 320);
            this.Controls.Add(this.clearBttn);
            this.Controls.Add(this.clcJobButton);
            this.Controls.Add(this.ttlCostDispLbl);
            this.Controls.Add(this.laborCostDispLbl);
            this.Controls.Add(this.costPaintDispLbl);
            this.Controls.Add(this.ttlHoursDispLbl);
            this.Controls.Add(this.ttlGallonsDispLbl);
            this.Controls.Add(this.ttlSqFtDispLbl);
            this.Controls.Add(this.inputsGroupBox);
            this.Controls.Add(this.ttlCostLbl);
            this.Controls.Add(this.laborCostLbl);
            this.Controls.Add(this.paintCostLbl);
            this.Controls.Add(this.ttlHoursLbl);
            this.Controls.Add(this.ttlGallonsLbl);
            this.Controls.Add(this.totalSqFtLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.inputsGroupBox.ResumeLayout(false);
            this.inputsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coatsLbl;
        private System.Windows.Forms.Label areaLbl;
        private System.Windows.Forms.Label pricePerGallonLbl;
        private System.Windows.Forms.Label totalSqFtLbl;
        private System.Windows.Forms.Label ttlGallonsLbl;
        private System.Windows.Forms.Label ttlHoursLbl;
        private System.Windows.Forms.Label paintCostLbl;
        private System.Windows.Forms.Label laborCostLbl;
        private System.Windows.Forms.Label ttlCostLbl;
        private System.Windows.Forms.GroupBox inputsGroupBox;
        private System.Windows.Forms.TextBox areaTxtBox;
        private System.Windows.Forms.TextBox coatsTxtBox;
        private System.Windows.Forms.TextBox priceGallonTxtBox;
        private System.Windows.Forms.Label ttlSqFtDispLbl;
        private System.Windows.Forms.Label ttlGallonsDispLbl;
        private System.Windows.Forms.Label ttlHoursDispLbl;
        private System.Windows.Forms.Label costPaintDispLbl;
        private System.Windows.Forms.Label laborCostDispLbl;
        private System.Windows.Forms.Label ttlCostDispLbl;
        private System.Windows.Forms.Button clcJobButton;
        private System.Windows.Forms.Button clearBttn;
    }
}


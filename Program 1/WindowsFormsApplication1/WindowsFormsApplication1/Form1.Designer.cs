namespace WindowsFormsApplication1
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
            this.wallSpaceInput = new System.Windows.Forms.TextBox();
            this.coatsDesiredInput = new System.Windows.Forms.TextBox();
            this.paintPPGInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coatsDesiredLabel = new System.Windows.Forms.Label();
            this.pricePPGLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalSquareFeetOutput = new System.Windows.Forms.Label();
            this.gallonsRequiredOutput = new System.Windows.Forms.Label();
            this.requiredLaborHoursOutput = new System.Windows.Forms.Label();
            this.paintCostOutput = new System.Windows.Forms.Label();
            this.laborCostOutput = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wallSpaceInput
            // 
            this.wallSpaceInput.Location = new System.Drawing.Point(201, 56);
            this.wallSpaceInput.Name = "wallSpaceInput";
            this.wallSpaceInput.Size = new System.Drawing.Size(100, 20);
            this.wallSpaceInput.TabIndex = 0;
            // 
            // coatsDesiredInput
            // 
            this.coatsDesiredInput.Location = new System.Drawing.Point(201, 92);
            this.coatsDesiredInput.Name = "coatsDesiredInput";
            this.coatsDesiredInput.Size = new System.Drawing.Size(100, 20);
            this.coatsDesiredInput.TabIndex = 1;
            // 
            // paintPPGInput
            // 
            this.paintPPGInput.Location = new System.Drawing.Point(201, 128);
            this.paintPPGInput.Name = "paintPPGInput";
            this.paintPPGInput.Size = new System.Drawing.Size(100, 20);
            this.paintPPGInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wall Space (sq ft):";
            // 
            // coatsDesiredLabel
            // 
            this.coatsDesiredLabel.AutoSize = true;
            this.coatsDesiredLabel.Location = new System.Drawing.Point(119, 95);
            this.coatsDesiredLabel.Name = "coatsDesiredLabel";
            this.coatsDesiredLabel.Size = new System.Drawing.Size(76, 13);
            this.coatsDesiredLabel.TabIndex = 4;
            this.coatsDesiredLabel.Text = "Coats Desired:";
            // 
            // pricePPGLabel
            // 
            this.pricePPGLabel.AutoSize = true;
            this.pricePPGLabel.Location = new System.Drawing.Point(67, 131);
            this.pricePPGLabel.Name = "pricePPGLabel";
            this.pricePPGLabel.Size = new System.Drawing.Size(128, 13);
            this.pricePPGLabel.TabIndex = 5;
            this.pricePPGLabel.Text = "Price of Paint (per gallon):";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(143, 181);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalSquareFeetOutput
            // 
            this.totalSquareFeetOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSquareFeetOutput.Location = new System.Drawing.Point(201, 233);
            this.totalSquareFeetOutput.Name = "totalSquareFeetOutput";
            this.totalSquareFeetOutput.Size = new System.Drawing.Size(100, 20);
            this.totalSquareFeetOutput.TabIndex = 7;
            // 
            // gallonsRequiredOutput
            // 
            this.gallonsRequiredOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsRequiredOutput.Location = new System.Drawing.Point(201, 269);
            this.gallonsRequiredOutput.Name = "gallonsRequiredOutput";
            this.gallonsRequiredOutput.Size = new System.Drawing.Size(100, 20);
            this.gallonsRequiredOutput.TabIndex = 8;
            // 
            // requiredLaborHoursOutput
            // 
            this.requiredLaborHoursOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requiredLaborHoursOutput.Location = new System.Drawing.Point(201, 305);
            this.requiredLaborHoursOutput.Name = "requiredLaborHoursOutput";
            this.requiredLaborHoursOutput.Size = new System.Drawing.Size(100, 20);
            this.requiredLaborHoursOutput.TabIndex = 9;
            // 
            // paintCostOutput
            // 
            this.paintCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintCostOutput.Location = new System.Drawing.Point(201, 341);
            this.paintCostOutput.Name = "paintCostOutput";
            this.paintCostOutput.Size = new System.Drawing.Size(100, 20);
            this.paintCostOutput.TabIndex = 10;
            // 
            // laborCostOutput
            // 
            this.laborCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostOutput.Location = new System.Drawing.Point(201, 377);
            this.laborCostOutput.Name = "laborCostOutput";
            this.laborCostOutput.Size = new System.Drawing.Size(100, 20);
            this.laborCostOutput.TabIndex = 11;
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutput.Location = new System.Drawing.Point(201, 413);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(100, 20);
            this.totalCostOutput.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total Square Feet:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Gallons Required:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Required Labor Hours:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(125, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Cost of Paint:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(135, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Labor Cost:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(138, 414);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Total Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 483);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalCostOutput);
            this.Controls.Add(this.laborCostOutput);
            this.Controls.Add(this.paintCostOutput);
            this.Controls.Add(this.requiredLaborHoursOutput);
            this.Controls.Add(this.gallonsRequiredOutput);
            this.Controls.Add(this.totalSquareFeetOutput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.pricePPGLabel);
            this.Controls.Add(this.coatsDesiredLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paintPPGInput);
            this.Controls.Add(this.coatsDesiredInput);
            this.Controls.Add(this.wallSpaceInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wallSpaceInput;
        private System.Windows.Forms.TextBox coatsDesiredInput;
        private System.Windows.Forms.TextBox paintPPGInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label coatsDesiredLabel;
        private System.Windows.Forms.Label pricePPGLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalSquareFeetOutput;
        private System.Windows.Forms.Label gallonsRequiredOutput;
        private System.Windows.Forms.Label requiredLaborHoursOutput;
        private System.Windows.Forms.Label paintCostOutput;
        private System.Windows.Forms.Label laborCostOutput;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}


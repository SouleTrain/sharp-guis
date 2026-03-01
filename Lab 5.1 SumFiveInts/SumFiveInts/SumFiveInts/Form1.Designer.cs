namespace SumFiveInts
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
            this.label1 = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.solutionLabel = new System.Windows.Forms.Label();
            this.sumButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.numList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter five numbers and this program will \r\nsum them up!";
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(158, 35);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(69, 20);
            this.numBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(158, 61);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(69, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add >>";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // solutionLabel
            // 
            this.solutionLabel.AutoSize = true;
            this.solutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionLabel.Location = new System.Drawing.Point(21, 155);
            this.solutionLabel.Name = "solutionLabel";
            this.solutionLabel.Size = new System.Drawing.Size(0, 31);
            this.solutionLabel.TabIndex = 5;
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(158, 119);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(69, 23);
            this.sumButton.TabIndex = 6;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(158, 90);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(69, 23);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove<<";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // numList
            // 
            this.numList.FormattingEnabled = true;
            this.numList.Location = new System.Drawing.Point(233, 35);
            this.numList.Name = "numList";
            this.numList.Size = new System.Drawing.Size(72, 95);
            this.numList.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 227);
            this.Controls.Add(this.numList);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.solutionLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sum Five Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label solutionLabel;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox numList;
    }
}


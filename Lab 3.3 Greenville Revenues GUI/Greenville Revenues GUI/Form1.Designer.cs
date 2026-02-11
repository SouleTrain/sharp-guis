namespace Greenville_Revenues_GUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastYearBox = new System.Windows.Forms.TextBox();
            this.thisYearBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.thisYearRev = new System.Windows.Forms.Label();
            this.lastYearRev = new System.Windows.Forms.Label();
            this.compareLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compare Contestants From This Year\r\nIn Contrast To Last Year!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrance fee: $25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Years Contestants :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "This Years Contestants :";
            // 
            // lastYearBox
            // 
            this.lastYearBox.Location = new System.Drawing.Point(444, 152);
            this.lastYearBox.Name = "lastYearBox";
            this.lastYearBox.Size = new System.Drawing.Size(50, 20);
            this.lastYearBox.TabIndex = 4;
            // 
            // thisYearBox
            // 
            this.thisYearBox.Location = new System.Drawing.Point(444, 200);
            this.thisYearBox.Name = "thisYearBox";
            this.thisYearBox.Size = new System.Drawing.Size(50, 20);
            this.thisYearBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thisYearRev
            // 
            this.thisYearRev.AutoSize = true;
            this.thisYearRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisYearRev.Location = new System.Drawing.Point(189, 328);
            this.thisYearRev.Name = "thisYearRev";
            this.thisYearRev.Size = new System.Drawing.Size(0, 20);
            this.thisYearRev.TabIndex = 7;
            this.thisYearRev.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lastYearRev
            // 
            this.lastYearRev.AutoSize = true;
            this.lastYearRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastYearRev.Location = new System.Drawing.Point(189, 295);
            this.lastYearRev.Name = "lastYearRev";
            this.lastYearRev.Size = new System.Drawing.Size(0, 20);
            this.lastYearRev.TabIndex = 8;
            this.lastYearRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compareLabel
            // 
            this.compareLabel.AutoSize = true;
            this.compareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareLabel.Location = new System.Drawing.Point(189, 365);
            this.compareLabel.Name = "compareLabel";
            this.compareLabel.Size = new System.Drawing.Size(0, 20);
            this.compareLabel.TabIndex = 9;
            this.compareLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.compareLabel);
            this.Controls.Add(this.lastYearRev);
            this.Controls.Add(this.thisYearRev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thisYearBox);
            this.Controls.Add(this.lastYearBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Greenville Revenue GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastYearBox;
        private System.Windows.Forms.TextBox thisYearBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label thisYearRev;
        private System.Windows.Forms.Label lastYearRev;
        private System.Windows.Forms.Label compareLabel;
    }
}


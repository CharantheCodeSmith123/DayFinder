
namespace DayFinder
{
    partial class DayFinder
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
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnFindDay = new System.Windows.Forms.Button();
            this.printDay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Final Frontier", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(83, 69);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(298, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Enter the date in the format yyyy-dd-mm";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(590, 69);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(227, 26);
            this.txtDate.TabIndex = 1;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // btnFindDay
            // 
            this.btnFindDay.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindDay.Location = new System.Drawing.Point(283, 145);
            this.btnFindDay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFindDay.Name = "btnFindDay";
            this.btnFindDay.Size = new System.Drawing.Size(218, 78);
            this.btnFindDay.TabIndex = 2;
            this.btnFindDay.Text = "Find The Day";
            this.btnFindDay.UseVisualStyleBackColor = true;
            this.btnFindDay.Click += new System.EventHandler(this.btnFindDay_Click);
            // 
            // printDay
            // 
            this.printDay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDay.Location = new System.Drawing.Point(153, 318);
            this.printDay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.printDay.Name = "printDay";
            this.printDay.Size = new System.Drawing.Size(456, 162);
            this.printDay.TabIndex = 3;
            this.printDay.Text = "";
            // 
            // DayFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(893, 606);
            this.Controls.Add(this.printDay);
            this.Controls.Add(this.btnFindDay);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "DayFinder";
            this.Text = "DaYFinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnFindDay;
        private System.Windows.Forms.RichTextBox printDay;
    }
}


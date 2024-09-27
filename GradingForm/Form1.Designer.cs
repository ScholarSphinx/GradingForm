
namespace GradingForm
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
            this.transfer = new System.Windows.Forms.Button();
            this.processmarks = new System.Windows.Forms.Button();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.listBoxMarks = new System.Windows.Forms.ListBox();
            this.summary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transfer
            // 
            this.transfer.Location = new System.Drawing.Point(388, 165);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(75, 23);
            this.transfer.TabIndex = 0;
            this.transfer.Text = "Transfer";
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Click += new System.EventHandler(this.transfer_Click_1);
            // 
            // processmarks
            // 
            this.processmarks.Location = new System.Drawing.Point(543, 165);
            this.processmarks.Name = "processmarks";
            this.processmarks.Size = new System.Drawing.Size(75, 23);
            this.processmarks.TabIndex = 1;
            this.processmarks.Text = "Process";
            this.processmarks.UseVisualStyleBackColor = true;
            this.processmarks.Click += new System.EventHandler(this.processmarks_Click_1);
            // 
            // textBoxMark
            // 
            this.textBoxMark.Location = new System.Drawing.Point(388, 64);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(100, 20);
            this.textBoxMark.TabIndex = 2;
            // 
            // listBoxMarks
            // 
            this.listBoxMarks.FormattingEnabled = true;
            this.listBoxMarks.Location = new System.Drawing.Point(368, 273);
            this.listBoxMarks.Name = "listBoxMarks";
            this.listBoxMarks.Size = new System.Drawing.Size(120, 95);
            this.listBoxMarks.TabIndex = 3;
            // 
            // summary
            // 
            this.summary.Location = new System.Drawing.Point(232, 165);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(75, 23);
            this.summary.TabIndex = 4;
            this.summary.Text = "Summary";
            this.summary.UseVisualStyleBackColor = true;
            this.summary.Click += new System.EventHandler(this.summary_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.listBoxMarks);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.processmarks);
            this.Controls.Add(this.transfer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.Button processmarks;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.ListBox listBoxMarks;
        private System.Windows.Forms.Button summary;
    }
}


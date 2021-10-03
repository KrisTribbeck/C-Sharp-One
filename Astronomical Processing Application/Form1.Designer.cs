
namespace Astronomical_Processing_Application
{
    partial class Application1
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
            this.TextBoxDisplay = new System.Windows.Forms.TextBox();
            this.ListBoxDisplay = new System.Windows.Forms.ListBox();
            this.ButtonRandom = new System.Windows.Forms.Button();
            this.ButtonBubbleSort = new System.Windows.Forms.Button();
            this.ButtonAddData = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxDisplay
            // 
            this.TextBoxDisplay.Location = new System.Drawing.Point(14, 14);
            this.TextBoxDisplay.Name = "TextBoxDisplay";
            this.TextBoxDisplay.Size = new System.Drawing.Size(202, 20);
            this.TextBoxDisplay.TabIndex = 1;
            // 
            // ListBoxDisplay
            // 
            this.ListBoxDisplay.FormattingEnabled = true;
            this.ListBoxDisplay.Location = new System.Drawing.Point(14, 41);
            this.ListBoxDisplay.Name = "ListBoxDisplay";
            this.ListBoxDisplay.Size = new System.Drawing.Size(121, 303);
            this.ListBoxDisplay.TabIndex = 2;
            this.ListBoxDisplay.SelectedIndexChanged += new System.EventHandler(this.ListBoxDisplay_SelectedIndexChanged);
            // 
            // ButtonRandom
            // 
            this.ButtonRandom.Location = new System.Drawing.Point(141, 41);
            this.ButtonRandom.Name = "ButtonRandom";
            this.ButtonRandom.Size = new System.Drawing.Size(75, 23);
            this.ButtonRandom.TabIndex = 3;
            this.ButtonRandom.Text = "Random";
            this.ButtonRandom.UseVisualStyleBackColor = true;
            this.ButtonRandom.Click += new System.EventHandler(this.ButtonRandom_Click);
            // 
            // ButtonBubbleSort
            // 
            this.ButtonBubbleSort.Location = new System.Drawing.Point(141, 70);
            this.ButtonBubbleSort.Name = "ButtonBubbleSort";
            this.ButtonBubbleSort.Size = new System.Drawing.Size(75, 23);
            this.ButtonBubbleSort.TabIndex = 4;
            this.ButtonBubbleSort.Text = "Sort";
            this.ButtonBubbleSort.UseVisualStyleBackColor = true;
            this.ButtonBubbleSort.Click += new System.EventHandler(this.ButtonBubbleSort_Click);
            // 
            // ButtonAddData
            // 
            this.ButtonAddData.Location = new System.Drawing.Point(141, 99);
            this.ButtonAddData.Name = "ButtonAddData";
            this.ButtonAddData.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddData.TabIndex = 5;
            this.ButtonAddData.Text = "Add Data";
            this.ButtonAddData.UseVisualStyleBackColor = true;
            this.ButtonAddData.Click += new System.EventHandler(this.ButtonAddData_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(141, 128);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(141, 157);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 7;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(141, 186);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 8;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusMsg
            // 
            this.StripStatusMsg.Name = "StripStatusMsg";
            this.StripStatusMsg.Size = new System.Drawing.Size(70, 17);
            this.StripStatusMsg.Text = "Status Label";
            // 
            // Application1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAddData);
            this.Controls.Add(this.ButtonBubbleSort);
            this.Controls.Add(this.ButtonRandom);
            this.Controls.Add(this.ListBoxDisplay);
            this.Controls.Add(this.TextBoxDisplay);
            this.Name = "Application1";
            this.Text = "8";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxDisplay;
        private System.Windows.Forms.ListBox ListBoxDisplay;
        private System.Windows.Forms.Button ButtonRandom;
        private System.Windows.Forms.Button ButtonBubbleSort;
        private System.Windows.Forms.Button ButtonAddData;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusMsg;
    }
}


namespace Dz_Week_3
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
            this.explorerTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // explorerTreeView
            // 
            this.explorerTreeView.Location = new System.Drawing.Point(12, 12);
            this.explorerTreeView.Name = "explorerTreeView";
            this.explorerTreeView.Size = new System.Drawing.Size(392, 421);
            this.explorerTreeView.TabIndex = 0;
            this.explorerTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.explorerTreeView_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 445);
            this.Controls.Add(this.explorerTreeView);
            this.Name = "Form1";
            this.Text = "Explorer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView explorerTreeView;
    }
}


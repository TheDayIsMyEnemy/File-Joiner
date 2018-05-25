namespace FileJoiner
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
            this.ChooseFolderButton = new System.Windows.Forms.Button();
            this.JoinFilesButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.CopyToClipboard = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ChooseFolderButton
            // 
            this.ChooseFolderButton.Location = new System.Drawing.Point(120, 24);
            this.ChooseFolderButton.Name = "ChooseFolderButton";
            this.ChooseFolderButton.Size = new System.Drawing.Size(100, 50);
            this.ChooseFolderButton.TabIndex = 0;
            this.ChooseFolderButton.Text = "Choose folder";
            this.ChooseFolderButton.UseVisualStyleBackColor = true;
            this.ChooseFolderButton.Click += new System.EventHandler(this.ChooseFolderButton_Click);
            // 
            // JoinFilesButton
            // 
            this.JoinFilesButton.Location = new System.Drawing.Point(120, 80);
            this.JoinFilesButton.Name = "JoinFilesButton";
            this.JoinFilesButton.Size = new System.Drawing.Size(100, 50);
            this.JoinFilesButton.TabIndex = 1;
            this.JoinFilesButton.Text = "Join files";
            this.JoinFilesButton.UseVisualStyleBackColor = true;
            this.JoinFilesButton.Click += new System.EventHandler(this.JoinFilesButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\psycho realm\\Documents\\Visual Studio 2017\\Projects";
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.Location = new System.Drawing.Point(120, 136);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(100, 50);
            this.CopyToClipboard.TabIndex = 2;
            this.CopyToClipboard.Text = "Copy to Clipboard";
            this.CopyToClipboard.UseVisualStyleBackColor = true;
            this.CopyToClipboard.Click += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(120, 192);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(100, 50);
            this.SaveFileButton.TabIndex = 3;
            this.SaveFileButton.Text = "Save file";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "C# files|*.cs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 286);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.CopyToClipboard);
            this.Controls.Add(this.JoinFilesButton);
            this.Controls.Add(this.ChooseFolderButton);
            this.Name = "Form1";
            this.Text = "File Joiner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChooseFolderButton;
        private System.Windows.Forms.Button JoinFilesButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button CopyToClipboard;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


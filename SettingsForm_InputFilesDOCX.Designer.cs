﻿namespace InputFilesDOCX
{
    partial class SettingsForm_InputFilesDOCX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm_InputFilesDOCX));
            this.SetFolderButton = new System.Windows.Forms.Button();
            this.SelectedFolderTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IncludeSubfoldersCheckbox = new System.Windows.Forms.CheckBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.PreserveParagraphsCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SetFolderButton
            // 
            this.SetFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetFolderButton.Location = new System.Drawing.Point(12, 71);
            this.SetFolderButton.Name = "SetFolderButton";
            this.SetFolderButton.Size = new System.Drawing.Size(118, 40);
            this.SetFolderButton.TabIndex = 0;
            this.SetFolderButton.Text = "Choose Folder";
            this.SetFolderButton.UseVisualStyleBackColor = true;
            this.SetFolderButton.Click += new System.EventHandler(this.SetFolderButton_Click);
            // 
            // SelectedFolderTextbox
            // 
            this.SelectedFolderTextbox.Enabled = false;
            this.SelectedFolderTextbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFolderTextbox.Location = new System.Drawing.Point(12, 42);
            this.SelectedFolderTextbox.MaxLength = 2147483647;
            this.SelectedFolderTextbox.Name = "SelectedFolderTextbox";
            this.SelectedFolderTextbox.Size = new System.Drawing.Size(606, 23);
            this.SelectedFolderTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Folder";
            // 
            // IncludeSubfoldersCheckbox
            // 
            this.IncludeSubfoldersCheckbox.AutoSize = true;
            this.IncludeSubfoldersCheckbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeSubfoldersCheckbox.Location = new System.Drawing.Point(191, 82);
            this.IncludeSubfoldersCheckbox.Name = "IncludeSubfoldersCheckbox";
            this.IncludeSubfoldersCheckbox.Size = new System.Drawing.Size(149, 20);
            this.IncludeSubfoldersCheckbox.TabIndex = 5;
            this.IncludeSubfoldersCheckbox.Text = "Include Subfolders";
            this.IncludeSubfoldersCheckbox.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(261, 151);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(118, 40);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // PreserveParagraphsCheckbox
            // 
            this.PreserveParagraphsCheckbox.AutoSize = true;
            this.PreserveParagraphsCheckbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreserveParagraphsCheckbox.Location = new System.Drawing.Point(375, 82);
            this.PreserveParagraphsCheckbox.Name = "PreserveParagraphsCheckbox";
            this.PreserveParagraphsCheckbox.Size = new System.Drawing.Size(208, 20);
            this.PreserveParagraphsCheckbox.TabIndex = 7;
            this.PreserveParagraphsCheckbox.Text = "Try to Preserve Paragraphs";
            this.PreserveParagraphsCheckbox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm_InputFilesDOCX
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 203);
            this.Controls.Add(this.PreserveParagraphsCheckbox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.IncludeSubfoldersCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedFolderTextbox);
            this.Controls.Add(this.SetFolderButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm_InputFilesDOCX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read .txt Files from Folder Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetFolderButton;
        private System.Windows.Forms.TextBox SelectedFolderTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IncludeSubfoldersCheckbox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.CheckBox PreserveParagraphsCheckbox;
    }
}
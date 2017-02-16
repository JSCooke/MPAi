﻿using MPAi.Components;

namespace MPAi.Forms.Popups
{
    partial class SystemConfig
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemConfig));
            this.audioFolderTextBox = new System.Windows.Forms.TextBox();
            this.audioFolderLabel = new System.Windows.Forms.Label();
            this.audioFolderSelectButton = new MPAiButton(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveButton = new MPAiButton(this.components);
            this.cancelButton = new MPAiButton(this.components);
            this.videoFolderSelectButton = new MPAiButton(this.components);
            this.videoFolderlabel = new System.Windows.Forms.Label();
            this.videoFolderTextBox = new System.Windows.Forms.TextBox();
            this.reportFolderSelectButton = new MPAiButton(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.reportFolderTextBox = new System.Windows.Forms.TextBox();
            this.recordingFolderSelectButton = new MPAiButton(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.recordingFolderTextBox = new System.Windows.Forms.TextBox();
            this.HTKFolderSelectButton = new MPAiButton(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.HTKFolderTextBox = new System.Windows.Forms.TextBox();
            this.formantFolderSelectButton = new MPAiButton(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.formantFolderTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // audioFolderTextBox
            // 
            this.audioFolderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.audioFolderTextBox.Enabled = false;
            this.audioFolderTextBox.Location = new System.Drawing.Point(126, 72);
            this.audioFolderTextBox.Name = "audioFolderTextBox";
            this.audioFolderTextBox.Size = new System.Drawing.Size(332, 20);
            this.audioFolderTextBox.TabIndex = 0;
            // 
            // audioFolderLabel
            // 
            this.audioFolderLabel.AutoSize = true;
            this.audioFolderLabel.Location = new System.Drawing.Point(19, 75);
            this.audioFolderLabel.Name = "audioFolderLabel";
            this.audioFolderLabel.Size = new System.Drawing.Size(66, 13);
            this.audioFolderLabel.TabIndex = 1;
            this.audioFolderLabel.Text = "Audio Folder";
            // 
            // audioFolderSelectButton
            // 
            this.audioFolderSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.audioFolderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioFolderSelectButton.ForeColor = System.Drawing.Color.White;
            this.audioFolderSelectButton.Location = new System.Drawing.Point(464, 72);
            this.audioFolderSelectButton.Name = "audioFolderSelectButton";
            this.audioFolderSelectButton.Size = new System.Drawing.Size(33, 25);
            this.audioFolderSelectButton.TabIndex = 2;
            this.audioFolderSelectButton.Text = "...";
            this.audioFolderSelectButton.UseVisualStyleBackColor = true;
            this.audioFolderSelectButton.Click += new System.EventHandler(this.audioFolderSelectButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(388, 273);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(51, 25);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(445, 273);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(53, 25);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // videoFolderSelectButton
            // 
            this.videoFolderSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.videoFolderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoFolderSelectButton.ForeColor = System.Drawing.Color.White;
            this.videoFolderSelectButton.Location = new System.Drawing.Point(464, 106);
            this.videoFolderSelectButton.Name = "videoFolderSelectButton";
            this.videoFolderSelectButton.Size = new System.Drawing.Size(33, 25);
            this.videoFolderSelectButton.TabIndex = 7;
            this.videoFolderSelectButton.Text = "...";
            this.videoFolderSelectButton.UseVisualStyleBackColor = true;
            this.videoFolderSelectButton.Click += new System.EventHandler(this.videoFolderSelectButton_Click);
            // 
            // videoFolderlabel
            // 
            this.videoFolderlabel.AutoSize = true;
            this.videoFolderlabel.Location = new System.Drawing.Point(19, 109);
            this.videoFolderlabel.Name = "videoFolderlabel";
            this.videoFolderlabel.Size = new System.Drawing.Size(66, 13);
            this.videoFolderlabel.TabIndex = 6;
            this.videoFolderlabel.Text = "Video Folder";
            // 
            // videoFolderTextBox
            // 
            this.videoFolderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.videoFolderTextBox.Enabled = false;
            this.videoFolderTextBox.Location = new System.Drawing.Point(126, 106);
            this.videoFolderTextBox.Name = "videoFolderTextBox";
            this.videoFolderTextBox.Size = new System.Drawing.Size(332, 20);
            this.videoFolderTextBox.TabIndex = 5;
            // 
            // reportFolderSelectButton
            // 
            this.reportFolderSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.reportFolderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportFolderSelectButton.ForeColor = System.Drawing.Color.White;
            this.reportFolderSelectButton.Location = new System.Drawing.Point(464, 171);
            this.reportFolderSelectButton.Name = "reportFolderSelectButton";
            this.reportFolderSelectButton.Size = new System.Drawing.Size(33, 25);
            this.reportFolderSelectButton.TabIndex = 13;
            this.reportFolderSelectButton.Text = "...";
            this.reportFolderSelectButton.UseVisualStyleBackColor = true;
            this.reportFolderSelectButton.Click += new System.EventHandler(this.reportFolderSelectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Report Folder";
            // 
            // reportFolderTextBox
            // 
            this.reportFolderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reportFolderTextBox.Enabled = false;
            this.reportFolderTextBox.Location = new System.Drawing.Point(126, 171);
            this.reportFolderTextBox.Name = "reportFolderTextBox";
            this.reportFolderTextBox.Size = new System.Drawing.Size(332, 20);
            this.reportFolderTextBox.TabIndex = 11;
            // 
            // recordingFolderSelectButton
            // 
            this.recordingFolderSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.recordingFolderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordingFolderSelectButton.ForeColor = System.Drawing.Color.White;
            this.recordingFolderSelectButton.Location = new System.Drawing.Point(464, 138);
            this.recordingFolderSelectButton.Name = "recordingFolderSelectButton";
            this.recordingFolderSelectButton.Size = new System.Drawing.Size(33, 25);
            this.recordingFolderSelectButton.TabIndex = 10;
            this.recordingFolderSelectButton.Text = "...";
            this.recordingFolderSelectButton.UseVisualStyleBackColor = true;
            this.recordingFolderSelectButton.Click += new System.EventHandler(this.recordingFolderSelectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recording Folder";
            // 
            // recordingFolderTextBox
            // 
            this.recordingFolderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.recordingFolderTextBox.Enabled = false;
            this.recordingFolderTextBox.Location = new System.Drawing.Point(126, 138);
            this.recordingFolderTextBox.Name = "recordingFolderTextBox";
            this.recordingFolderTextBox.Size = new System.Drawing.Size(332, 20);
            this.recordingFolderTextBox.TabIndex = 8;
            // 
            // HTKFolderSelectButton
            // 
            this.HTKFolderSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.HTKFolderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HTKFolderSelectButton.ForeColor = System.Drawing.Color.White;
            this.HTKFolderSelectButton.Location = new System.Drawing.Point(464, 201);
            this.HTKFolderSelectButton.Name = "HTKFolderSelectButton";
            this.HTKFolderSelectButton.Size = new System.Drawing.Size(33, 25);
            this.HTKFolderSelectButton.TabIndex = 16;
            this.HTKFolderSelectButton.Text = "...";
            this.HTKFolderSelectButton.UseVisualStyleBackColor = true;
            this.HTKFolderSelectButton.Click += new System.EventHandler(this.HTKFolderSelectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "HTK Folder";
            // 
            // HTKFolderTextBox
            // 
            this.HTKFolderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HTKFolderTextBox.Enabled = false;
            this.HTKFolderTextBox.Location = new System.Drawing.Point(126, 201);
            this.HTKFolderTextBox.Name = "HTKFolderTextBox";
            this.HTKFolderTextBox.Size = new System.Drawing.Size(332, 20);
            this.HTKFolderTextBox.TabIndex = 14;
            // 
            // formantFolderSelectButton
            // 
            this.formantFolderSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.formantFolderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formantFolderSelectButton.ForeColor = System.Drawing.Color.White;
            this.formantFolderSelectButton.Location = new System.Drawing.Point(464, 229);
            this.formantFolderSelectButton.Name = "formantFolderSelectButton";
            this.formantFolderSelectButton.Size = new System.Drawing.Size(33, 25);
            this.formantFolderSelectButton.TabIndex = 19;
            this.formantFolderSelectButton.Text = "...";
            this.formantFolderSelectButton.UseVisualStyleBackColor = true;
            this.formantFolderSelectButton.Click += new System.EventHandler(this.formantFolderSelectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Formant Folder";
            // 
            // formantFolderTextBox
            // 
            this.formantFolderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formantFolderTextBox.Enabled = false;
            this.formantFolderTextBox.Location = new System.Drawing.Point(126, 229);
            this.formantFolderTextBox.Name = "formantFolderTextBox";
            this.formantFolderTextBox.Size = new System.Drawing.Size(332, 20);
            this.formantFolderTextBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 25);
            this.label5.MaximumSize = new System.Drawing.Size(400, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "This allows you to set the file locations used by the system. Note that MPAi depe" +
    "nds on files it finds in these locations; it is advised not to change these.";
            // 
            // SystemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 304);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.formantFolderSelectButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.formantFolderTextBox);
            this.Controls.Add(this.HTKFolderSelectButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HTKFolderTextBox);
            this.Controls.Add(this.reportFolderSelectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportFolderTextBox);
            this.Controls.Add(this.recordingFolderSelectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordingFolderTextBox);
            this.Controls.Add(this.videoFolderSelectButton);
            this.Controls.Add(this.videoFolderlabel);
            this.Controls.Add(this.videoFolderTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.audioFolderSelectButton);
            this.Controls.Add(this.audioFolderLabel);
            this.Controls.Add(this.audioFolderTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set System Paths";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox audioFolderTextBox;
        private System.Windows.Forms.Label audioFolderLabel;
        private MPAiButton audioFolderSelectButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private MPAiButton saveButton;
        private MPAiButton cancelButton;
        private MPAiButton videoFolderSelectButton;
        private System.Windows.Forms.Label videoFolderlabel;
        private System.Windows.Forms.TextBox videoFolderTextBox;
        private MPAiButton reportFolderSelectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reportFolderTextBox;
        private MPAiButton recordingFolderSelectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recordingFolderTextBox;
        private MPAiButton HTKFolderSelectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HTKFolderTextBox;
        private MPAiButton formantFolderSelectButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox formantFolderTextBox;
        private System.Windows.Forms.Label label5;
    }
}
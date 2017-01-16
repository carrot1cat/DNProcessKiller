﻿namespace ProcessKiller
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.KeySettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.SettingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.CountDownKeyTextBox = new System.Windows.Forms.TextBox();
            this.ProcessKillerButtonLabel = new System.Windows.Forms.Label();
            this.ProcessKillerKeyTextbox = new System.Windows.Forms.TextBox();
            this.CountDownButtonLabel = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LoggingSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GameDicLabel = new System.Windows.Forms.Label();
            this.ServerSettingLabel = new System.Windows.Forms.Label();
            this.GameDicPathTextBox = new System.Windows.Forms.TextBox();
            this.ServerSelectionBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PathSelectionButton = new System.Windows.Forms.Button();
            this.KeySettingsGroupBox.SuspendLayout();
            this.SettingsTable.SuspendLayout();
            this.LoggingSettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeySettingsGroupBox
            // 
            this.KeySettingsGroupBox.Controls.Add(this.SettingsTable);
            this.KeySettingsGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeySettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.KeySettingsGroupBox.Name = "KeySettingsGroupBox";
            this.KeySettingsGroupBox.Size = new System.Drawing.Size(274, 141);
            this.KeySettingsGroupBox.TabIndex = 0;
            this.KeySettingsGroupBox.TabStop = false;
            this.KeySettingsGroupBox.Text = "按键设置";
            // 
            // SettingsTable
            // 
            this.SettingsTable.ColumnCount = 2;
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.10204F));
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.89796F));
            this.SettingsTable.Controls.Add(this.CountDownKeyTextBox, 1, 1);
            this.SettingsTable.Controls.Add(this.ProcessKillerButtonLabel, 0, 0);
            this.SettingsTable.Controls.Add(this.ProcessKillerKeyTextbox, 1, 0);
            this.SettingsTable.Controls.Add(this.CountDownButtonLabel, 0, 1);
            this.SettingsTable.Location = new System.Drawing.Point(7, 22);
            this.SettingsTable.Name = "SettingsTable";
            this.SettingsTable.RowCount = 2;
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingsTable.Size = new System.Drawing.Size(260, 108);
            this.SettingsTable.TabIndex = 0;
            // 
            // CountDownKeyTextBox
            // 
            this.CountDownKeyTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CountDownKeyTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDownKeyTextBox.Location = new System.Drawing.Point(146, 68);
            this.CountDownKeyTextBox.Name = "CountDownKeyTextBox";
            this.CountDownKeyTextBox.ReadOnly = true;
            this.CountDownKeyTextBox.Size = new System.Drawing.Size(88, 25);
            this.CountDownKeyTextBox.TabIndex = 3;
            this.CountDownKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProcessKillerButtonLabel
            // 
            this.ProcessKillerButtonLabel.AutoSize = true;
            this.ProcessKillerButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessKillerButtonLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessKillerButtonLabel.Location = new System.Drawing.Point(3, 0);
            this.ProcessKillerButtonLabel.Name = "ProcessKillerButtonLabel";
            this.ProcessKillerButtonLabel.Size = new System.Drawing.Size(137, 54);
            this.ProcessKillerButtonLabel.TabIndex = 0;
            this.ProcessKillerButtonLabel.Text = "掉线快捷键:";
            this.ProcessKillerButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcessKillerKeyTextbox
            // 
            this.ProcessKillerKeyTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProcessKillerKeyTextbox.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessKillerKeyTextbox.Location = new System.Drawing.Point(146, 14);
            this.ProcessKillerKeyTextbox.Name = "ProcessKillerKeyTextbox";
            this.ProcessKillerKeyTextbox.ReadOnly = true;
            this.ProcessKillerKeyTextbox.Size = new System.Drawing.Size(88, 25);
            this.ProcessKillerKeyTextbox.TabIndex = 1;
            this.ProcessKillerKeyTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountDownButtonLabel
            // 
            this.CountDownButtonLabel.AutoSize = true;
            this.CountDownButtonLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountDownButtonLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CountDownButtonLabel.Location = new System.Drawing.Point(3, 54);
            this.CountDownButtonLabel.Name = "CountDownButtonLabel";
            this.CountDownButtonLabel.Size = new System.Drawing.Size(137, 54);
            this.CountDownButtonLabel.TabIndex = 2;
            this.CountDownButtonLabel.Text = "倒计时快捷键:";
            this.CountDownButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(26, 296);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(100, 35);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "应用";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(176, 296);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 35);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LoggingSettingsGroupBox
            // 
            this.LoggingSettingsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.LoggingSettingsGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoggingSettingsGroupBox.Location = new System.Drawing.Point(12, 164);
            this.LoggingSettingsGroupBox.Name = "LoggingSettingsGroupBox";
            this.LoggingSettingsGroupBox.Size = new System.Drawing.Size(274, 120);
            this.LoggingSettingsGroupBox.TabIndex = 3;
            this.LoggingSettingsGroupBox.TabStop = false;
            this.LoggingSettingsGroupBox.Text = "登录设置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.76923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.23077F));
            this.tableLayoutPanel1.Controls.Add(this.GameDicLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ServerSettingLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ServerSelectionBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 88);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GameDicLabel
            // 
            this.GameDicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameDicLabel.AutoSize = true;
            this.GameDicLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameDicLabel.Location = new System.Drawing.Point(3, 0);
            this.GameDicLabel.Name = "GameDicLabel";
            this.GameDicLabel.Size = new System.Drawing.Size(86, 44);
            this.GameDicLabel.TabIndex = 0;
            this.GameDicLabel.Text = "游戏路径:";
            this.GameDicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerSettingLabel
            // 
            this.ServerSettingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerSettingLabel.AutoSize = true;
            this.ServerSettingLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerSettingLabel.Location = new System.Drawing.Point(3, 44);
            this.ServerSettingLabel.Name = "ServerSettingLabel";
            this.ServerSettingLabel.Size = new System.Drawing.Size(86, 44);
            this.ServerSettingLabel.TabIndex = 1;
            this.ServerSettingLabel.Text = "大区选择:";
            this.ServerSettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameDicPathTextBox
            // 
            this.GameDicPathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GameDicPathTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameDicPathTextBox.Location = new System.Drawing.Point(3, 6);
            this.GameDicPathTextBox.Name = "GameDicPathTextBox";
            this.GameDicPathTextBox.ReadOnly = true;
            this.GameDicPathTextBox.Size = new System.Drawing.Size(117, 25);
            this.GameDicPathTextBox.TabIndex = 3;
            // 
            // ServerSelectionBox
            // 
            this.ServerSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerSelectionBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerSelectionBox.FormattingEnabled = true;
            this.ServerSelectionBox.Location = new System.Drawing.Point(95, 52);
            this.ServerSelectionBox.Name = "ServerSelectionBox";
            this.ServerSelectionBox.Size = new System.Drawing.Size(162, 28);
            this.ServerSelectionBox.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.92593F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.07407F));
            this.tableLayoutPanel2.Controls.Add(this.GameDicPathTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PathSelectionButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(95, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(162, 38);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // PathSelectionButton
            // 
            this.PathSelectionButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PathSelectionButton.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PathSelectionButton.Location = new System.Drawing.Point(126, 5);
            this.PathSelectionButton.Name = "PathSelectionButton";
            this.PathSelectionButton.Size = new System.Drawing.Size(33, 28);
            this.PathSelectionButton.TabIndex = 4;
            this.PathSelectionButton.Text = "...";
            this.PathSelectionButton.UseVisualStyleBackColor = true;
            this.PathSelectionButton.Click += new System.EventHandler(this.PathSelectionButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 343);
            this.Controls.Add(this.LoggingSettingsGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.KeySettingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.KeySettingsGroupBox.ResumeLayout(false);
            this.SettingsTable.ResumeLayout(false);
            this.SettingsTable.PerformLayout();
            this.LoggingSettingsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox KeySettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel SettingsTable;
        private System.Windows.Forms.Label ProcessKillerButtonLabel;
        private System.Windows.Forms.TextBox ProcessKillerKeyTextbox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label CountDownButtonLabel;
        private System.Windows.Forms.TextBox CountDownKeyTextBox;
        private System.Windows.Forms.GroupBox LoggingSettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label GameDicLabel;
        private System.Windows.Forms.Label ServerSettingLabel;
        private System.Windows.Forms.TextBox GameDicPathTextBox;
        private System.Windows.Forms.ComboBox ServerSelectionBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button PathSelectionButton;
    }
}
﻿namespace SystemForm
{
    partial class ComplaintChildForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiNavBar1 = new Sunny.UI.UINavBar();
            uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            MainContainer = new Sunny.UI.UITabControl();
            tabPage1 = new TabPage();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            contentTextBox = new Sunny.UI.UITextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            RemindButton = new Sunny.UI.UIButton();
            DeleteButton = new Sunny.UI.UIButton();
            UpdateButton = new Sunny.UI.UIButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            informerLabel = new Sunny.UI.UILabel();
            TimeLabel = new Sunny.UI.UILabel();
            statusLabel = new Sunny.UI.UILabel();
            uiNavBar1.SuspendLayout();
            MainContainer.SuspendLayout();
            tabPage1.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiNavBar1
            // 
            uiNavBar1.BackColor = SystemColors.ActiveCaption;
            uiNavBar1.Controls.Add(uiSmoothLabel1);
            uiNavBar1.Dock = DockStyle.Top;
            uiNavBar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiNavBar1.Location = new Point(2, 36);
            uiNavBar1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiNavBar1.Name = "uiNavBar1";
            uiNavBar1.Size = new Size(1136, 99);
            uiNavBar1.TabIndex = 1;
            uiNavBar1.Text = "uiNavBar1";
            // 
            // uiSmoothLabel1
            // 
            uiSmoothLabel1.AccessibleRole = AccessibleRole.TitleBar;
            uiSmoothLabel1.BackColor = SystemColors.ActiveCaption;
            uiSmoothLabel1.Font = new Font("新宋体", 36F, FontStyle.Regular, GraphicsUnit.Point);
            uiSmoothLabel1.Location = new Point(341, 15);
            uiSmoothLabel1.Name = "uiSmoothLabel1";
            uiSmoothLabel1.RectColor = Color.White;
            uiSmoothLabel1.Size = new Size(441, 80);
            uiSmoothLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiSmoothLabel1.TabIndex = 1;
            uiSmoothLabel1.Text = "宿舍生活小助手";
            // 
            // MainContainer
            // 
            MainContainer.Controls.Add(tabPage1);
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.DrawMode = TabDrawMode.OwnerDrawFixed;
            MainContainer.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainContainer.ItemSize = new Size(0, 1);
            MainContainer.Location = new Point(2, 135);
            MainContainer.MainPage = "";
            MainContainer.Name = "MainContainer";
            MainContainer.SelectedIndex = 0;
            MainContainer.Size = new Size(1136, 490);
            MainContainer.SizeMode = TabSizeMode.Fixed;
            MainContainer.TabIndex = 3;
            MainContainer.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            MainContainer.TabVisible = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uiGroupBox1);
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1136, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(contentTextBox);
            uiGroupBox1.Controls.Add(tableLayoutPanel2);
            uiGroupBox1.Controls.Add(tableLayoutPanel1);
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(314, 18);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(482, 356);
            uiGroupBox1.TabIndex = 1;
            uiGroupBox1.Text = "举报详情：";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // contentTextBox
            // 
            contentTextBox.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            contentTextBox.Location = new Point(44, 187);
            contentTextBox.Margin = new Padding(4, 5, 4, 5);
            contentTextBox.MinimumSize = new Size(1, 16);
            contentTextBox.Multiline = true;
            contentTextBox.Name = "contentTextBox";
            contentTextBox.ShowText = false;
            contentTextBox.Size = new Size(371, 90);
            contentTextBox.TabIndex = 2;
            contentTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            contentTextBox.Watermark = "";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(RemindButton, 0, 0);
            tableLayoutPanel2.Controls.Add(DeleteButton, 1, 0);
            tableLayoutPanel2.Controls.Add(UpdateButton, 2, 0);
            tableLayoutPanel2.Location = new Point(23, 285);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(438, 56);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // RemindButton
            // 
            RemindButton.Anchor = AnchorStyles.Left;
            RemindButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RemindButton.Location = new Point(3, 6);
            RemindButton.MinimumSize = new Size(1, 1);
            RemindButton.Name = "RemindButton";
            RemindButton.Size = new Size(125, 44);
            RemindButton.TabIndex = 0;
            RemindButton.Text = "发送提醒";
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Left;
            DeleteButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(148, 6);
            DeleteButton.MinimumSize = new Size(1, 1);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(125, 44);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "删除记录";
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Anchor = AnchorStyles.Left;
            UpdateButton.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.Location = new Point(293, 6);
            UpdateButton.MinimumSize = new Size(1, 1);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(125, 44);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "更新记录";
            UpdateButton.Click += UpdateButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(uiLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(uiLabel2, 0, 1);
            tableLayoutPanel1.Controls.Add(uiLabel3, 0, 3);
            tableLayoutPanel1.Controls.Add(uiLabel4, 0, 2);
            tableLayoutPanel1.Controls.Add(informerLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(TimeLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(statusLabel, 1, 2);
            tableLayoutPanel1.Location = new Point(44, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(371, 143);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(3, 3);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(142, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "举报人：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(3, 38);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(142, 29);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "举报时间：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiLabel3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.Location = new Point(3, 109);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(142, 29);
            uiLabel3.TabIndex = 2;
            uiLabel3.Text = "举报内容：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            uiLabel3.Click += uiLabel3_Click;
            // 
            // uiLabel4
            // 
            uiLabel4.Anchor = AnchorStyles.Left;
            uiLabel4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.Location = new Point(3, 73);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(125, 29);
            uiLabel4.TabIndex = 3;
            uiLabel4.Text = "状态：";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // informerLabel
            // 
            informerLabel.Anchor = AnchorStyles.Left;
            informerLabel.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            informerLabel.Location = new Point(151, 3);
            informerLabel.Name = "informerLabel";
            informerLabel.Size = new Size(125, 29);
            informerLabel.TabIndex = 4;
            informerLabel.Text = "informer";
            informerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TimeLabel
            // 
            TimeLabel.Anchor = AnchorStyles.Left;
            TimeLabel.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.Location = new Point(151, 38);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(217, 29);
            TimeLabel.TabIndex = 5;
            TimeLabel.Text = "Time";
            TimeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.Left;
            statusLabel.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.Location = new Point(151, 73);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(125, 29);
            statusLabel.TabIndex = 6;
            statusLabel.Text = "status";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ComplaintChildForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1140, 627);
            Controls.Add(MainContainer);
            Controls.Add(uiNavBar1);
            Name = "ComplaintChildForm";
            Padding = new Padding(2, 36, 2, 2);
            ShowDragStretch = true;
            ShowRadius = false;
            ShowTitleIcon = true;
            Text = "宿舍生活小助手";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            uiNavBar1.ResumeLayout(false);
            MainContainer.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UINavBar uiNavBar1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UITabControl MainContainer;
        private TabPage tabPage1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UIButton RemindButton;
        private Sunny.UI.UIButton DeleteButton;
        private Sunny.UI.UIButton UpdateButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox contentTextBox;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel informerLabel;
        private Sunny.UI.UILabel TimeLabel;
        private Sunny.UI.UILabel statusLabel;
    }
}
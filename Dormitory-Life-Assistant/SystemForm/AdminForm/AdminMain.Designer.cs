﻿namespace SystemForm
{
    partial class AdminMain
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
            Label1 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            ID = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            sex = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            phone = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            major = new Sunny.UI.UILabel();
            MyMessage = new Sunny.UI.UIGroupBox();
            pictureBox1 = new PictureBox();
            MyMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(16, 41);
            Label1.Name = "Label1";
            Label1.Size = new Size(111, 29);
            Label1.TabIndex = 0;
            Label1.Text = "姓名";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(65, 41);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 29);
            uiLabel1.TabIndex = 1;
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(16, 99);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 29);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "工号";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ID
            // 
            ID.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ID.Location = new Point(65, 99);
            ID.Name = "ID";
            ID.Size = new Size(125, 29);
            ID.TabIndex = 3;
            ID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.Location = new Point(16, 164);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(125, 29);
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "性别";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sex
            // 
            sex.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sex.Location = new Point(65, 164);
            sex.Name = "sex";
            sex.Size = new Size(125, 29);
            sex.TabIndex = 5;
            sex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.Location = new Point(281, 41);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(125, 29);
            uiLabel5.TabIndex = 6;
            uiLabel5.Text = "电话";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // phone
            // 
            phone.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phone.Location = new Point(332, 41);
            phone.Name = "phone";
            phone.Size = new Size(125, 29);
            phone.TabIndex = 7;
            phone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.Location = new Point(285, 99);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(121, 29);
            uiLabel4.TabIndex = 8;
            uiLabel4.Text = "职务";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // major
            // 
            major.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            major.Location = new Point(334, 99);
            major.Name = "major";
            major.Size = new Size(121, 29);
            major.TabIndex = 9;
            major.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MyMessage
            // 
            MyMessage.Controls.Add(major);
            MyMessage.Controls.Add(uiLabel4);
            MyMessage.Controls.Add(phone);
            MyMessage.Controls.Add(uiLabel5);
            MyMessage.Controls.Add(sex);
            MyMessage.Controls.Add(uiLabel3);
            MyMessage.Controls.Add(ID);
            MyMessage.Controls.Add(uiLabel2);
            MyMessage.Controls.Add(uiLabel1);
            MyMessage.Controls.Add(Label1);
            MyMessage.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MyMessage.Location = new Point(269, 79);
            MyMessage.Margin = new Padding(4, 5, 4, 5);
            MyMessage.MinimumSize = new Size(1, 1);
            MyMessage.Name = "MyMessage";
            MyMessage.Padding = new Padding(0, 32, 0, 0);
            MyMessage.Size = new Size(593, 212);
            MyMessage.TabIndex = 6;
            MyMessage.Text = "我的信息";
            MyMessage.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(70, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AdminMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(975, 490);
            Controls.Add(pictureBox1);
            Controls.Add(MyMessage);
            Name = "AdminMain";
            PageIndex = 2001;
            Text = "AdminMain";
            MyMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel Label1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel ID;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel sex;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel phone;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel major;
        private Sunny.UI.UIGroupBox MyMessage;
        private PictureBox pictureBox1;
    }
}
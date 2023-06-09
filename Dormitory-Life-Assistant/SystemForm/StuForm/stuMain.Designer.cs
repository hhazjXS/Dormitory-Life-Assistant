﻿using Dormitory_Life_Assistant;

namespace SystemForm
{
    partial class stuMain
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
        private void InitializeComponent(/*Student student*/)
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel = new Sunny.UI.UIPanel();
            pictureBox1 = new PictureBox();
            uiButton1 = new Sunny.UI.UIButton();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiDataGridView2 = new Sunny.UI.UIDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            SupervisorName = new DataGridViewTextBoxColumn();
            dormMessageBindingSource = new BindingSource(components);
            SystemMessage = new Sunny.UI.UIGroupBox();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            contentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            administratorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            systemMessageBindingSource = new BindingSource(components);
            uiCalendar1 = new Sunny.UI.UICalendar();
            MyDormitory = new Sunny.UI.UIGroupBox();
            buildingno = new Sunny.UI.UILabel();
            dorm = new Sunny.UI.UILabel();
            uiLabel7 = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            MyMessage = new Sunny.UI.UIGroupBox();
            departName = new Sunny.UI.UILabel();
            myclass = new Sunny.UI.UILabel();
            label2 = new Sunny.UI.UILabel();
            grade = new Sunny.UI.UILabel();
            uiLabel8 = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            sex = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            ID = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            Label1 = new Sunny.UI.UILabel();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dormMessageBindingSource).BeginInit();
            SystemMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)systemMessageBindingSource).BeginInit();
            MyDormitory.SuspendLayout();
            MyMessage.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(pictureBox1);
            panel.Controls.Add(uiButton1);
            panel.Controls.Add(uiGroupBox1);
            panel.Controls.Add(SystemMessage);
            panel.Controls.Add(uiCalendar1);
            panel.Controls.Add(MyDormitory);
            panel.Controls.Add(MyMessage);
            panel.Dock = DockStyle.Fill;
            panel.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(4, 5, 4, 5);
            panel.MinimumSize = new Size(1, 1);
            panel.Name = "panel";
            panel.Size = new Size(974, 499);
            panel.TabIndex = 0;
            panel.Text = null;
            panel.TextAlignment = ContentAlignment.MiddleCenter;
            panel.Click += panel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Location = new Point(34, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(756, 3);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(150, 52);
            uiButton1.TabIndex = 6;
            uiButton1.Text = "备忘录";
            uiButton1.Click += uiButton1_Click;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(uiDataGridView2);
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(494, 264);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(452, 212);
            uiGroupBox1.TabIndex = 5;
            uiGroupBox1.Text = "宿舍公告";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiDataGridView2
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            uiDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView2.AutoGenerateColumns = false;
            uiDataGridView2.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView2.ColumnHeadersHeight = 32;
            uiDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView2.ColumnHeadersVisible = false;
            uiDataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, SupervisorName });
            uiDataGridView2.DataSource = dormMessageBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView2.Dock = DockStyle.Fill;
            uiDataGridView2.EnableHeadersVisualStyles = false;
            uiDataGridView2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView2.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView2.Location = new Point(0, 32);
            uiDataGridView2.Name = "uiDataGridView2";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 48, 48);
            uiDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView2.RowTemplate.Height = 29;
            uiDataGridView2.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            uiDataGridView2.SelectedIndex = -1;
            uiDataGridView2.Size = new Size(452, 180);
            uiDataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Content";
            dataGridViewTextBoxColumn1.HeaderText = "Content";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 300;
            // 
            // SupervisorName
            // 
            SupervisorName.DataPropertyName = "SupervisorName";
            SupervisorName.HeaderText = "SupervisorName";
            SupervisorName.MinimumWidth = 6;
            SupervisorName.Name = "SupervisorName";
            SupervisorName.ReadOnly = true;
            SupervisorName.Width = 125;
            // 
            // dormMessageBindingSource
            // 
            dormMessageBindingSource.DataSource = typeof(DormMessage);
            // 
            // SystemMessage
            // 
            SystemMessage.Controls.Add(uiDataGridView1);
            SystemMessage.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SystemMessage.Location = new Point(34, 264);
            SystemMessage.Margin = new Padding(4, 5, 4, 5);
            SystemMessage.MinimumSize = new Size(1, 1);
            SystemMessage.Name = "SystemMessage";
            SystemMessage.Padding = new Padding(0, 32, 0, 0);
            SystemMessage.Size = new Size(452, 212);
            SystemMessage.TabIndex = 4;
            SystemMessage.Text = "系统消息";
            SystemMessage.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView1.AutoGenerateColumns = false;
            uiDataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.ColumnHeadersVisible = false;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { contentDataGridViewTextBoxColumn, administratorNameDataGridViewTextBoxColumn });
            uiDataGridView1.DataSource = systemMessageBindingSource;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.Dock = DockStyle.Fill;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView1.Location = new Point(0, 32);
            uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(48, 48, 48);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDataGridView1.RowTemplate.Height = 29;
            uiDataGridView1.ScrollBarRectColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(452, 180);
            uiDataGridView1.TabIndex = 0;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            contentDataGridViewTextBoxColumn.HeaderText = "Content";
            contentDataGridViewTextBoxColumn.MinimumWidth = 6;
            contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            contentDataGridViewTextBoxColumn.ReadOnly = true;
            contentDataGridViewTextBoxColumn.Width = 300;
            // 
            // administratorNameDataGridViewTextBoxColumn
            // 
            administratorNameDataGridViewTextBoxColumn.DataPropertyName = "AdministratorName";
            administratorNameDataGridViewTextBoxColumn.HeaderText = "AdministratorName";
            administratorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            administratorNameDataGridViewTextBoxColumn.Name = "administratorNameDataGridViewTextBoxColumn";
            administratorNameDataGridViewTextBoxColumn.ReadOnly = true;
            administratorNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // systemMessageBindingSource
            // 
            systemMessageBindingSource.DataSource = typeof(SystemMessage);
            // 
            // uiCalendar1
            // 
            uiCalendar1.Date = new DateTime(2023, 5, 18, 0, 0, 0, 0);
            uiCalendar1.FillColor = Color.White;
            uiCalendar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiCalendar1.Location = new Point(706, 61);
            uiCalendar1.MinimumSize = new Size(240, 180);
            uiCalendar1.Name = "uiCalendar1";
            uiCalendar1.PrimaryColor = Color.FromArgb(80, 160, 255);
            uiCalendar1.Size = new Size(240, 200);
            uiCalendar1.TabIndex = 3;
            uiCalendar1.Text = "uiCalendar1";
            uiCalendar1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // MyDormitory
            // 
            MyDormitory.Controls.Add(buildingno);
            MyDormitory.Controls.Add(dorm);
            MyDormitory.Controls.Add(uiLabel7);
            MyDormitory.Controls.Add(uiLabel6);
            MyDormitory.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MyDormitory.Location = new Point(156, 25);
            MyDormitory.Margin = new Padding(4, 5, 4, 5);
            MyDormitory.MinimumSize = new Size(1, 1);
            MyDormitory.Name = "MyDormitory";
            MyDormitory.Padding = new Padding(0, 32, 0, 0);
            MyDormitory.Size = new Size(471, 98);
            MyDormitory.TabIndex = 2;
            MyDormitory.Text = "我的宿舍";
            MyDormitory.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // buildingno
            // 
            buildingno.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buildingno.Location = new Point(290, 47);
            buildingno.Name = "buildingno";
            buildingno.Size = new Size(125, 29);
            buildingno.TabIndex = 5;
            buildingno.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dorm
            // 
            dorm.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dorm.Location = new Point(83, 44);
            dorm.Name = "dorm";
            dorm.Size = new Size(125, 29);
            dorm.TabIndex = 4;
            dorm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel7.Location = new Point(214, 44);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(147, 32);
            uiLabel7.TabIndex = 1;
            uiLabel7.Text = "楼号";
            uiLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel6.Location = new Point(15, 44);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(125, 29);
            uiLabel6.TabIndex = 0;
            uiLabel6.Text = "宿舍名";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            uiLabel6.Click += uiLabel6_Click;
            // 
            // MyMessage
            // 
            MyMessage.Controls.Add(departName);
            MyMessage.Controls.Add(myclass);
            MyMessage.Controls.Add(label2);
            MyMessage.Controls.Add(grade);
            MyMessage.Controls.Add(uiLabel8);
            MyMessage.Controls.Add(uiLabel5);
            MyMessage.Controls.Add(sex);
            MyMessage.Controls.Add(uiLabel3);
            MyMessage.Controls.Add(ID);
            MyMessage.Controls.Add(uiLabel2);
            MyMessage.Controls.Add(uiLabel1);
            MyMessage.Controls.Add(Label1);
            MyMessage.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MyMessage.Location = new Point(34, 146);
            MyMessage.Margin = new Padding(4, 5, 4, 5);
            MyMessage.MinimumSize = new Size(1, 1);
            MyMessage.Name = "MyMessage";
            MyMessage.Padding = new Padding(0, 32, 0, 0);
            MyMessage.Size = new Size(593, 108);
            MyMessage.TabIndex = 1;
            MyMessage.Text = "我的信息";
            MyMessage.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // departName
            // 
            departName.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            departName.Location = new Point(460, 73);
            departName.Name = "departName";
            departName.Size = new Size(125, 29);
            departName.TabIndex = 6;
            departName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // myclass
            // 
            myclass.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            myclass.Location = new Point(460, 44);
            myclass.Name = "myclass";
            myclass.Size = new Size(125, 29);
            myclass.TabIndex = 11;
            myclass.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(392, 44);
            label2.Name = "label2";
            label2.Size = new Size(125, 29);
            label2.TabIndex = 10;
            label2.Text = "班级";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grade
            // 
            grade.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grade.Location = new Point(247, 73);
            grade.Name = "grade";
            grade.Size = new Size(125, 29);
            grade.TabIndex = 7;
            grade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel8.Location = new Point(392, 73);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(125, 29);
            uiLabel8.TabIndex = 2;
            uiLabel8.Text = "专业";
            uiLabel8.TextAlign = ContentAlignment.MiddleLeft;
            uiLabel8.Click += uiLabel8_Click;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.Location = new Point(196, 73);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(125, 29);
            uiLabel5.TabIndex = 6;
            uiLabel5.Text = "年级";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sex
            // 
            sex.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sex.Location = new Point(247, 44);
            sex.Name = "sex";
            sex.Size = new Size(125, 29);
            sex.TabIndex = 5;
            sex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.Location = new Point(196, 44);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(125, 29);
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "性别";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ID
            // 
            ID.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ID.Location = new Point(65, 73);
            ID.Name = "ID";
            ID.Size = new Size(125, 29);
            ID.TabIndex = 3;
            ID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(16, 73);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 29);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "学号";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
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
            // stuMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(974, 499);
            Controls.Add(panel);
            Name = "stuMain";
            PageIndex = 1001;
            Text = "stuMain";
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dormMessageBindingSource).EndInit();
            SystemMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)systemMessageBindingSource).EndInit();
            MyDormitory.ResumeLayout(false);
            MyMessage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel panel;
        private Sunny.UI.UIGroupBox MyMessage;
        private Sunny.UI.UILabel grade;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel sex;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel ID;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel Label1;
        private Sunny.UI.UIGroupBox SystemMessage;
        private Sunny.UI.UILabel myclass;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UICalendar uiCalendar1;
        private Sunny.UI.UIGroupBox MyDormitory;
        private Sunny.UI.UILabel departName;
        private Sunny.UI.UILabel buildingno;
        private Sunny.UI.UILabel dorm;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIDataGridView uiDataGridView1;

        private BindingSource systemMessageBindingSource;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIDataGridView uiDataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn SupervisorName;
        private BindingSource dormMessageBindingSource;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn administratorNameDataGridViewTextBoxColumn;
        private Sunny.UI.UIButton uiButton1;
        private PictureBox pictureBox1;
    }
}
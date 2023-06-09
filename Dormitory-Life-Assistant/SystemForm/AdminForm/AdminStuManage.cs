﻿using Dormitory_Life_Assistant.Service;
using Dormitory_Life_Assistant;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemForm
{
    public partial class AdminStuManage : UIPage
    {
        StudentService studentService;

        public AdminStuManage()
        {
            InitializeComponent();

            studentService = new StudentService();
            studentBindingSource.DataSource = studentService.getall();
            //uiComboBox1.SelectedIndex = 0;
            uiDataGridView1.AllowUserToAddRows = false;
        }

        public void QueryAll()
        {
            studentBindingSource.DataSource = studentService.getall();
            studentBindingSource.ResetBindings(false);
        }



        private void uiButton4_Click(object sender, EventArgs e)//查询
        {
            switch (uiComboBox1.SelectedIndex)
            {

                case 0://根据学号查询
                    studentBindingSource.DataSource = studentService.QueryStudentByID(queryText.Text);
                    break;
                case 3://根据班级查询
                    studentBindingSource.DataSource = studentService.QueryStudentByClass(queryText.Text);
                    break;
                case 2://根据专业查询
                    studentBindingSource.DataSource = studentService.QueryStudentByDepartment(queryText.Text);
                    break;
                case 1://根据姓名查询
                    studentBindingSource.DataSource = studentService.QueryStudentByName(queryText.Text);
                    break;
                default:
                    QueryAll();
                    break;
            }
            studentBindingSource.ResetBindings(false);
        }

        private void deleteButton_Click_1(object sender, EventArgs e)//删除学生
        {
            Student student = studentBindingSource.Current as Student;
            if (student == null)
            {
                UIMessageBox.Show("请选择要修改的学生");
            }
            if (student != null)
            {
                UIMessageBox.Show("是否确认删除");
                studentService.DeleteStudent(student);
                studentBindingSource.DataSource = studentService.getall();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StudentEdit studentEdit = new StudentEdit(new Student(), studentService);
            studentEdit.titleBox.Text = "添加学生";
            studentEdit.IdBox.Text = "";
            studentEdit.ShowDialog();
            QueryAll();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            Student student = studentBindingSource.Current as Student;

            if (student == null)
            {
                UIMessageBox.Show("请选择一个学生进行修改");
                return;
            }
            StudentEdit studentEdit = new StudentEdit(student, studentService);
            studentEdit.titleBox.Text = "修改学生信息";
            studentService.DeleteStudent(student);
            studentEdit.ShowDialog();
            studentBindingSource.DataSource = studentService.getall();
        }
    }
}

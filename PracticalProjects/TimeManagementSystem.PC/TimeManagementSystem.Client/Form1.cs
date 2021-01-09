﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeManagementSystem.DAL;

namespace TimeManagementSystem.PC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AddData();
        }

        private void AddData()
        {
            //新增
            for(int i = 0; i < 10; i++)
            {
                this.TheTaskList.Items.Add($"任务{i}");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //todo 根据任务状态控制按钮的可用与不可用
            if (this.TheTaskList.SelectedIndex == 0)
            {
                DeleteButton.Enabled = false;
            }
            else
            {
                DeleteButton.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Complete_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void DetailEditAddButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            

            if (this.TheTaskList.SelectedItem == null)
            {
                MessageBox.Show("未选择项目，无法删除！");
                return;
            }
            var selectItem = this.TheTaskList.SelectedItem as string;
            var r= MessageBox.Show($"是否确定删除{selectItem}？","1111",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                this.TheTaskList.Items.Remove(selectItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Model.Task> tasks = new List<Model.Task>();
            //数据库连接字符串
            var connectionString = "Data Source=C:\\Users\\Lulu\\Desktop\\CSharpLearn\\PracticalProjects\\TimeManagementSystemDatabase.db;Version=3;";
            //数据库连接SQLiteConnection
            using (SQLiteConnection cn = new SQLiteConnection(connectionString))
            {
                //打开连接
                cn.Open();
                //创建命令
                SQLiteCommand cmd = new SQLiteCommand($"select * from Task", cn);
                var reader= cmd.ExecuteReader();
                while (reader.Read())
                {
                    Model.Task task = new Model.Task();
                    task.Id= reader[$"{nameof(TimeManagementSystem.Model.Task.Id)}"].ToString();
                    task.Name = reader[$"{nameof(TimeManagementSystem.Model.Task.Name)}"].ToString();
                    //todo 其他字段的存放
                    tasks.Add(task);
                }

                //cmd.ExecuteNonQuery
                //sql update
                //sql insert
            }

            

        }
    }
}

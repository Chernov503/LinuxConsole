using System;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Classes.Folder;
using WindowsFormsApp1.Classes.User;
using WindowsFormsApp1.Classes.User.Group;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox8.Text = "";
            AbstractProcess AllUsers = new AllUsers();
            AllUsers.Start();
            textBox8.Text = AllUsers.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            AbstractProcess User = new UserAdd(textBox1.Text);
            AbstractProcess UserPassword = new UserSetPassword(textBox2.Text, textBox1.Text);
            User.Start();
            UserPassword.Start();
            Form1_Load(sender,e);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                AbstractProcess UserDelete = new UserDelete(textBox1.Text);
                UserDelete.Start();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Form1_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                AbstractProcess Internet;
                if (radioButton4.Checked && !radioButton5.Checked) { Internet = new UserInternetOn(textBox1.Text); }
                else { Internet = new UserInternetOff(textBox1.Text); }

                Internet.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string choise = "+";
            if (checkBox1.Checked) choise += "r";
            if (checkBox2.Checked) choise += "w";
            if (checkBox3.Checked) choise += "x";

            try
            {
                AbstractProcess Access = new GroapGetAccessToFolder(textBox3.Text, choise);
                Access.Start();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Путь до папки указан неверно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) radioButton5.Checked = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) radioButton4.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            try
            {
                AbstractProcess AddUserToGroap = new AddUserToGroup(textBox5.Text, textBox7.Text);
                AddUserToGroap.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            try
            {
                AbstractProcess DeleteUserToGroap = new DeleteUserFromGroup(textBox5.Text, textBox7.Text);
                DeleteUserToGroap.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string choise = "-";
            if (checkBox1.Checked) choise += "r";
            if (checkBox2.Checked) choise += "w";
            if (checkBox3.Checked) choise += "x";

            try
            {
                AbstractProcess Access = new GroapGetAccessToFolder(textBox3.Text, choise);
                Access.Start();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Путь до папки указан неверно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}

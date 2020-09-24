using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            labelLastName.Text = Resource.FullName;
            ButtonAdd.Text = Resource.Add;
            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
            buttoniras.Text = Resource.ButtonNev;
            
        }

        private void buttoniras_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (var u in users)
                {
                    sw.Write(u.ID);
                    sw.WriteLine();
                    sw.Write(u.Fullname);
                    sw.WriteLine();
                }
                sw.Close();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                Fullname = textBoxLastName.Text

            };
            users.Add(u);
        }
    }
}

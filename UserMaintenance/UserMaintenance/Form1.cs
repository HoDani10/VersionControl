﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            labelLastName.Text = Resource.LastName;
            labelFirstName.Text = Resource.FirstName;
            ButtonAdd.Text = Resource.Add;
            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
            var u = new User()
            {
                LastName=textBoxLastName.Text, 
                FirstName=textboxFirstname.Text
            };
            users.Add(u);
        }
    }
}

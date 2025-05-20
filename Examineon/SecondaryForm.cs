﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examineon
{
    public partial class SecondaryForm : Form
    {
        public SecondaryForm()
        {
            InitializeComponent();
        }
        private string userRole;

        public SecondaryForm(string role)
        {
            InitializeComponent();
            userRole = role;


            this.Text = $"Logged in as {userRole}";
        }
    }
}

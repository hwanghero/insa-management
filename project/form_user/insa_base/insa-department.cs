﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.form_user.insa_base
{
    public partial class insa_department : Form
    {
        public insa_department()
        {
            InitializeComponent();
        }

        private void insa_department_Load(object sender, EventArgs e)
        {
            user.form_user_setting form_setting = new user.form_user_setting();
            form_setting.setting(this);
        }
    }
}

﻿using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeHelper
{
    public partial class StuRepairSon : UIForm
    {
        public StuRepairSon()
        {
            InitializeComponent();
            uiAvatar1.FillColor = Color.Transparent;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}

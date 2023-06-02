﻿using Dormitory_Life_Assistant;
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
    public partial class TBreakdownForm : UIPage
    {
        Supervisor sup = new Supervisor();
        RepairServicce repairServicce = new RepairServicce();

        public TBreakdownForm(Supervisor sup)
        {
            InitializeComponent();
            this.sup = sup;
            BreakdownDataGridView.DataSource = repairServicce.getAll();
        }

        private void BreakdownDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DetailButton_Click(object sender, EventArgs e)
        {
            BreakdownChildForm bcf = new BreakdownChildForm();
            bcf.ShowDialog();
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BreakdownIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BreakdownButton_Click(object sender, EventArgs e)
        {
            RepairServicce repairServicce = new RepairServicce();
            List<Repair> result = repairServicce.getRepairListByDormID(BreakdownIndex.Text);
            /*if (result.Count == 0)
            {
                throw new Exception("cuowu");
            }*/
            BreakdownDataGridView.DataSource = result;
            BreakdownDataGridView.Refresh();
        }
    }
}

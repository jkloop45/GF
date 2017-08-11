using App.Src;
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

namespace App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ctrl_select_processes.DisplayMember = "Text";
            ctrl_select_processes.ValueMember = "Value";
            ctrl_btn_reloadProcesses_Click(sender, e);
        }

        private void ctrl_btn_reloadProcesses_Click(object sender, EventArgs e)
        {
            var processes = DataProvider.getProcesses()
                                        .OrderByDescending(x => x.pname.ToLower().First())
                                        .ToArray();
            ctrl_select_processes.Items.Clear();
            foreach (var item in processes)
            {
                ctrl_select_processes.Items.Add(new { Text = Path.GetFileName(item.pname), Value = item.pid });
            }
        }

        private void ctrl_btn_attect_Click(object sender, EventArgs e)
        {
            int selectIndex = ctrl_select_processes.SelectedIndex;
            if (selectIndex == -1)
            {
                MessageBox.Show("please chose");
                return;
            }
            long pid = (long)((dynamic)ctrl_select_processes.Items[selectIndex]).Value;
            var zzz = DataProvider.getMemoryInfo(pid, 0, 0);
        }
    }
}

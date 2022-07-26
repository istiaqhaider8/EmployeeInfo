using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpolyeeInfo
{
    public partial class MenuUI : Form
    {
        public MenuUI()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            
            SaveUI saveUI = new SaveUI();
            saveUI.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchUI searchUI = new SearchUI();
            searchUI.Show();
            this.Hide();
        }
    }
}

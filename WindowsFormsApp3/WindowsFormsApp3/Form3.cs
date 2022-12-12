using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using WindowsFormsApp3;

namespace WindowsFormsApp1
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        ORDER ord = new ORDER();


        int cash = 0;
        int stockErrorcount = 0;
        public Form3()
        {
            InitializeComponent();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.porkcount )

        }
    }
}

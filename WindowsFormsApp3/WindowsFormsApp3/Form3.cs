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
            if (ord.porkcount >= 2)
            {
                for (int i= 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_cham.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_cham.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.porkcount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.PorkSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.porkcount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_cham.Text, Convert.ToString(ord.porkcount), Convert.ToString(ord.PorkSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.porkcount++;
            }
            textBox_sumnumber.Text = Convert.ToString(ord.SumNumber());
            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_fresh_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.beefcount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_fresh.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_fresh.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.beefcount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.BeefSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.beefcount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_fresh.Text, Convert.ToString(ord.beefcount), Convert.ToString(ord.BeefSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.beefcount++;
            }
            textBox_sumnumber.Text = Convert.ToString(ord.SumNumber());
            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }
    }
}

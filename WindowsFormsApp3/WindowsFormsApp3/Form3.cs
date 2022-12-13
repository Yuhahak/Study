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
            if (ord.chamcount >= 2)
            {
                for (int i= 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_cham.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_cham.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.chamcount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.ChamSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.chamcount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_cham.Text, Convert.ToString(ord.chamcount), Convert.ToString(ord.ChamSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.chamcount++;
            }
            
            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_fresh_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.freshcount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_fresh.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_fresh.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.freshcount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.FreshSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.freshcount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_fresh.Text, Convert.ToString(ord.freshcount), Convert.ToString(ord.FreshSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.freshcount++;
            }
            
            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.startcount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_start.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_start.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.startcount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.StartSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.startcount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_start.Text, Convert.ToString(ord.startcount), Convert.ToString(ord.StartSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.startcount++;
            }
            
            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count; // 리스트뷰 항목 수 반환
            if (ord.jinrocount >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == button_jinro.Text) // 리스트 뷰에 해당 버튼의 텍스트가 있으면
                    {
                        listView1.Items[i].Focused = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.Items[i].Selected = true; // 리스트뷰 컨트롤에서 항목 선택 가능하도록 하는거
                        listView1.FocusedItem.SubItems[0].Text = button_jinro.Text; // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[1].Text = Convert.ToString(ord.jinrocount); // 포커스된 부분에 내용 덮어쓰는거
                        listView1.FocusedItem.SubItems[2].Text = Convert.ToString(ord.JinroSum()); // 포커스된 부분에 내용 덮어쓰는거
                        ord.jinrocount++;
                        listView1.Items[i].Selected = false;
                    }
                }
            }
            else
            {
                var meat = new string[] { this.button_jinro.Text, Convert.ToString(ord.jinrocount), Convert.ToString(ord.JinroSum()) };
                var lvt = new ListViewItem(meat);
                this.listView1.Items.Add(lvt);
                listView1.Focus();
                ord.jinrocount++;
            }

            textBox_sumcash.Text = Convert.ToString(ord.SumCash());
        }
    }
}

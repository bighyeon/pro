using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;
using MetroFramework.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : MetroForm
    {
        
        
        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;

            listView1.Columns.Add("Index", 50);
            listView1.Columns.Add("Target", 200);
            listView1.Columns.Add("작업내용", 200);
            listView1.Columns.Add("인자", 120);

            string[] arr = new string[4];


            string[] row = { "TT", "TT", "TT", "TT"};
            var listViewItem = new ListViewItem(row);
            var listViewItem2 = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            listView1.Items.Add(listViewItem2);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(Start_Thread));
            t1.Start();
        }

        private void Start_Thread()
        {
            Css.RandomUrl Controller = new Css.RandomUrl();
            Controller.Init_Selenium(0);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

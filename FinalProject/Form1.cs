using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        static List<List<string>> StoryParts = new List<List<string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenStory_Click(object sender, EventArgs e)
        {
            List<string> tempList = new List<string>();
            CreateBox0(tempList);
            CreateBox1(tempList);
            CreateBox2(tempList);
            CreateBox3(tempList);
            CreateBox4(tempList);
            CreateBox5(tempList);

            StoryParts.Add(tempList);
        }

        private void CreationBox0(List<string> sectionList)
        {
            string tempString = "Jim Bob";
            txtGenBox0.Text = tempString;
            sectionList.Add(tempString);
        }

        private void CreationBox1(List<string> sectionList)
        {
            string tempString = "like to";
            txtGenBox1.Text = tempString;
            sectionList.Add(tempString);
        }

    }
}

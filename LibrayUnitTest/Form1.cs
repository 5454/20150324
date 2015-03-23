using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperLibray;

namespace LibrayUnitTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void TestBtn_Click(object sender, EventArgs e) {
            logBox.AppendText(Algorithm.RandomFloatRange(Convert.ToSingle(minValueIpt.Text), Convert.ToSingle(maxValueIpt.Text)).ToString() + "\n");
        }

        private void listSubTestBtn_Click(object sender, EventArgs e) {
            List<float> listTest = new List<float>();
            listTest.Add(1);
            listTest.Add(2);
            listTest.Add(3);
            listTest.Add(4);
            listTest.Add(5);
            logBox.AppendText(listTest.Sum().ToString());
        }
    }
}

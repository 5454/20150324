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
    }
}

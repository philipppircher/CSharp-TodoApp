using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodosSelectWindow
{
    public partial class Form1 : Form
    {
        List<todostable> _todos;
        public Form1(List<todostable> list)
        {
            InitializeComponent();

            _todos = list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

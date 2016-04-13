using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class MainForm : Form
    {
        public static List<Character> characterDB = new List<Character>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateForm cf = new CreateForm();
            cf.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewForm vf = new ViewForm();
            vf.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

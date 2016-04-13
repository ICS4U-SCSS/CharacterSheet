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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MainForm.characterDB.Count(); i++)
            {
                heroSelect.Items.Add(MainForm.characterDB[i].name);
            }
        }

        private void heroSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].name;
            classOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].charClass;
            dexterityOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].dexterity;
            strengthOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].strength;
            healthOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].health;
            perkOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].perk;

            if (MainForm.characterDB[heroSelect.SelectedIndex].charClass == "Fighter")
            {
                heroImage.BackgroundImage = Properties.Resources.fighter;
            }
            else if (MainForm.characterDB[heroSelect.SelectedIndex].charClass == "Mage")
            {
                heroImage.BackgroundImage = Properties.Resources.mage2;
            }
            else if (MainForm.characterDB[heroSelect.SelectedIndex].charClass == "Ranger")
            {
                heroImage.BackgroundImage = Properties.Resources.ranger;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

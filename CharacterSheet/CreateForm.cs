using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CharacterSheet
{
    public partial class CreateForm : Form
    {
        int dexterity, strength, health, points;
        string heroClass, name, perk;
        
        public CreateForm()
        {
            InitializeComponent();
            dexterity = strength = health = points = 5;
        }

        
        #region character class

        private void mageButton_Click(object sender, EventArgs e)
        {
            imageBox.BackgroundImage = Properties.Resources.mage2;
            heroClass = "Mage";
        }

        private void rangerButton_Click(object sender, EventArgs e)
        {
            imageBox.BackgroundImage = Properties.Resources.ranger;
            heroClass = "Ranger";
        }

        private void fighterButton_Click(object sender, EventArgs e)
        {
            imageBox.BackgroundImage = Properties.Resources.fighter;
            heroClass = "Fighter";
        }

        #endregion

        #region attributes

        private void dexPlus_Click(object sender, EventArgs e)
        {
            if (points > 0)
            {
                points--;
                pointsLabel.Text = Convert.ToString(points);

                dexterity++;
                dexInput.Text = Convert.ToString(dexterity);
            }
        }

        private void dexMinus_Click(object sender, EventArgs e)
        {
            if (dexterity > 0)
            {
                points++;
                pointsLabel.Text = Convert.ToString(points);

                dexterity--;
                dexInput.Text = Convert.ToString(dexterity);
            }
        }

        private void strengthPlus_Click(object sender, EventArgs e)
        {
            if (points > 0)
            {
                points--;
                pointsLabel.Text = Convert.ToString(points);

                strength++;
                strengthInput.Text = Convert.ToString(strength);
            }
        }

        private void StregthMinus_Click(object sender, EventArgs e)
        {
            if (strength > 0)
            {
                points++;
                pointsLabel.Text = Convert.ToString(points);

                strength--;
                strengthInput.Text = Convert.ToString(strength);
            }
        }

        private void healthPlus_Click(object sender, EventArgs e)
        {
            if (points > 0)
            {
                points--;
                pointsLabel.Text = Convert.ToString(points);

                health++;
                healthInput.Text = Convert.ToString(health);
            }
        }

        private void healthMinus_Click(object sender, EventArgs e)
        {
            if (health > 0)
            {
                points++;
                pointsLabel.Text = Convert.ToString(points);

                health--;
                healthInput.Text = Convert.ToString(health);
            }
        }

        #endregion

        #region perks

        private void sneakRadio_CheckedChanged(object sender, EventArgs e)
        {
            perk = "Sneak";
        }

        private void charmRadio_CheckedChanged(object sender, EventArgs e)
        {
            perk = "Charm";
        }

        private void intuitionRadio_CheckedChanged(object sender, EventArgs e)
        {
            perk = "Intuition";
        }

        private void speedRadio_CheckedChanged(object sender, EventArgs e)
        {
            perk = "Speed";
        }

        #endregion

        private void saveButton_Click(object sender, EventArgs e)
        {
            string dex, str, hea;

            name = nameInput.Text;
            dex = Convert.ToString(dexterity);
            str = Convert.ToString(strength);
            hea = Convert.ToString(health);

            Character hero = new Character(name, heroClass, dex, str, hea, perk);
            MainForm.characterDB.Add(hero);

            Thread.Sleep(250);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

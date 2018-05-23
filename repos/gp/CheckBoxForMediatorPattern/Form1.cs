using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxForMediatorPattern
{
    public partial class Form1 : Form
    {

        Mediator med = new Mediator();

        public Form1()
        {
            InitializeComponent();

            med.Add(warrior, berserker, sorcerer);
            med.AddSecond(singlesword, doublesword, wand);
        }

        private void chkWarrior_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkbox = (CheckBox)sender;
            med.ChangeAction(chkbox);            
        }

        private void chkBerserker_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkbox = (CheckBox)sender;
            med.ChangeAction(chkbox);
        }

        private void chkSorcerer_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkbox = (CheckBox)sender;
            med.ChangeAction(chkbox);
        }
    }

    class Mediator
    {
        private CheckBox rWarrior;
        private CheckBox rBerserker;
        private CheckBox rSorcerer;

        private CheckBox rSinglesword;
        private CheckBox rDoublesword;
        private CheckBox rWand;

        public Mediator()
        {

        }

        public void Add(CheckBox warrior, CheckBox berserker, CheckBox sorcerer)
        {
            rWarrior = warrior;
            rBerserker = berserker;
            rSorcerer = sorcerer;
        }

        public void AddSecond(CheckBox singlesword, CheckBox doublesword, CheckBox wand)
        {
            rSinglesword = singlesword;
            rDoublesword = doublesword;
            rWand = wand;
        }

        public void Check(CheckBox obj)
        {
            obj.Checked = true;
        }
        public void UnCheck(CheckBox obj)
        {
            obj.Checked = false;
        }

        public void ChangeAction(CheckBox obj)
        {
            if (rWarrior.Equals(obj))
            {
                UnCheck(rBerserker);
                UnCheck(rSorcerer);

                Check(rSinglesword);
                UnCheck(rWand);
                UnCheck(rDoublesword);
            }
            else if (rBerserker.Equals(obj))
            {
                UnCheck(rWarrior);
                UnCheck(rSorcerer);

                Check(rSinglesword);
                UnCheck(rWand);
                Check(rDoublesword);
            }
            else if (rSorcerer.Equals(obj))
            {
                UnCheck(rWarrior);
                UnCheck(rBerserker);

                UnCheck(rSinglesword);
                Check(rWand);
                UnCheck(rDoublesword);
            }
        }
    }
}

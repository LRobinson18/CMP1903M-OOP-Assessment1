using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingCalculator
{
    public partial class VotingCalculator : Form
    {
        void Voting()
        {
            int YesStates = 0;
            int NoStates = 0;
            int AbStates = 0;
            double YesPop = 0;
            double NoPop = 0;
            double AbPop = 0;

            if (comboBoxAustria.Text == "Yes") { YesStates++; YesPop += 1.98; }
            else if (comboBoxAustria.Text == "No") { NoStates++; NoPop += 1.98; }
            else { AbStates++; AbPop += 1.98; }

            if (comboBoxBelgium.Text == "Yes") { YesStates++; YesPop += 2.56; }
            else if (comboBoxBelgium.Text == "No") { NoStates++; NoPop += 2.56; }
            else { AbStates++; AbPop += 2.56; }

            if (comboBoxBulgaria.Text == "Yes") { YesStates++; YesPop += 1.56; }
            else if (comboBoxBulgaria.Text == "No") { NoStates++; NoPop += 1.56; }
            else { AbStates++; AbPop += 1.56; }

            if (comboBoxCroatia.Text == "Yes") { YesStates++; YesPop += 0.91; }
            else if (comboBoxCroatia.Text == "No") { NoStates++; NoPop += 0.91; }
            else { AbStates++; AbPop += 0.91; }

            if (comboBoxCyprus.Text == "Yes") { YesStates++; YesPop += 0.20; }
            else if (comboBoxCyprus.Text == "No") { NoStates++; NoPop += 0.20; }
            else { AbStates++; AbPop += 0.20; }

            if (comboBoxCzechRepublic.Text == "Yes") { YesStates++; YesPop += 2.35; }
            else if (comboBoxCzechRepublic.Text == "No") { NoStates++; NoPop += 2.35; }
            else { AbStates++; AbPop += 2.35; }

            if (comboBoxDenmark.Text == "Yes") { YesStates++; YesPop += 1.30; }
            else if (comboBoxDenmark.Text == "No") { NoStates++; NoPop += 1.30; }
            else { AbStates++; AbPop += 1.30; }

            if (comboBoxEstonia.Text == "Yes") { YesStates++; YesPop += 0.30; }
            else if (comboBoxEstonia.Text == "No") { NoStates++; NoPop += 0.30; }
            else { AbStates++; AbPop += 0.30; }

            if (comboBoxFinland.Text == "Yes") { YesStates++; YesPop += 1.23; }
            else if (comboBoxFinland.Text == "No") { NoStates++; NoPop += 1.23; }
            else { AbStates++; AbPop += 1.23; }

            if (comboBoxFrance.Text == "Yes") { YesStates++; YesPop += 14.98; }
            else if (comboBoxFrance.Text == "No") { NoStates++; NoPop += 14.98; }
            else { AbStates++; AbPop += 14.98; }

            if (comboBoxGermany.Text == "Yes") { YesStates++; YesPop += 18.54; }
            else if (comboBoxGermany.Text == "No") { NoStates++; NoPop += 18.54; }
            else { AbStates++; AbPop += 18.54; }

            if (comboBoxGreece.Text == "Yes") { YesStates++; YesPop += 2.40; }
            else if (comboBoxGreece.Text == "No") { NoStates++; NoPop += 2.40; }
            else { AbStates++; AbPop += 2.40; }

            if (comboBoxHungary.Text == "Yes") { YesStates++; YesPop += 2.18; }
            else if (comboBoxHungary.Text == "No") { NoStates++; NoPop += 2.18; }
            else { AbStates++; AbPop += 2.18; }

            if (comboBoxIreland.Text == "Yes") { YesStates++; YesPop += 1.10; }
            else if (comboBoxIreland.Text == "No") { NoStates++; NoPop += 1.10; }
            else { AbStates++; AbPop += 1.10; }

            if (comboBoxItaly.Text == "Yes") { YesStates++; YesPop += 13.65; }
            else if (comboBoxItaly.Text == "No") { NoStates++; NoPop += 13.65; }
            else { AbStates++; AbPop += 13.65; }

            if (comboBoxLatvia.Text == "Yes") { YesStates++; YesPop += 0.43; }
            else if (comboBoxLatvia.Text == "No") { NoStates++; NoPop += 0.43; }
            else { AbStates++; AbPop += 0.43; }

            if (comboBoxLithuania.Text == "Yes") { YesStates++; YesPop += 0.62; }
            else if (comboBoxLithuania.Text == "No") { NoStates++; NoPop += 0.62; }
            else { AbStates++; AbPop += 0.62; }

            if (comboBoxLuxembourg.Text == "Yes") { YesStates++; YesPop += 0.14; }
            else if (comboBoxLuxembourg.Text == "No") { NoStates++; NoPop += 0.14; }
            else { AbStates++; AbPop += 0.14; }

            if (comboBoxMalta.Text == "Yes") { YesStates++; YesPop += 0.11; }
            else if (comboBoxMalta.Text == "No") { NoStates++; NoPop += 0.11; }
            else { AbStates++; AbPop += 0.11; }

            if (comboBoxNetherlands.Text == "Yes") { YesStates++; YesPop += 3.89; }
            else if (comboBoxNetherlands.Text == "No") { NoStates++; NoPop += 3.89; }
            else { AbStates++; AbPop += 3.89; }

            if (comboBoxPoland.Text == "Yes") { YesStates++; YesPop += 8.49; }
            else if (comboBoxPoland.Text == "No") { NoStates++; NoPop += 8.49; }
            else { AbStates++; AbPop += 8.49; }

            if (comboBoxPortugal.Text == "Yes") { YesStates++; YesPop += 2.30; }
            else if (comboBoxPortugal.Text == "No") { NoStates++; NoPop += 2.30; }
            else { AbStates++; AbPop += 2.30; }

            if (comboBoxRomania.Text == "Yes") { YesStates++; YesPop += 4.34; }
            else if (comboBoxRomania.Text == "No") { NoStates++; NoPop += 4.34; }
            else { AbStates++; AbPop += 4.34; }

            if (comboBoxSlovakia.Text == "Yes") { YesStates++; YesPop += 1.22; }
            else if (comboBoxSlovakia.Text == "No") { NoStates++; NoPop += 1.22; }
            else { AbStates++; AbPop += 1.22; }

            if (comboBoxSpain.Text == "Yes") { YesStates++; YesPop += 10.49; }
            else if (comboBoxSpain.Text == "No") { NoStates++; NoPop += 10.49; }
            else { AbStates++; AbPop += 10.49; }

            if (comboBoxSweden.Text == "Yes") { YesStates++; YesPop += 2.29; }
            else if (comboBoxSweden.Text == "No") { NoStates++; NoPop += 2.29; }
            else { AbStates++; AbPop += 2.29; }

            if (comboBoxRule.Text == "Qualified Majority")
            {
                if (YesStates > 15 && YesPop > 65)
                {
                    labelResult.Text = "Approved";
                    labelResult.ForeColor = System.Drawing.Color.LimeGreen;
                }
                else
                {
                    labelResult.Text = "Rejected";
                    labelResult.ForeColor = System.Drawing.Color.Red;
                }
            }

            if (comboBoxRule.Text == "Reinforced Qualified Majority")
            {
                if (YesStates > 20 && YesPop > 65)
                {
                    labelResult.Text = "Approved";
                    labelResult.ForeColor = System.Drawing.Color.LimeGreen;
                }
                else
                {
                    labelResult.Text = "Rejected";
                    labelResult.ForeColor = System.Drawing.Color.Red;
                }
            }

            if (comboBoxRule.Text == "Simple Majority")
            {
                if (YesStates > 14)
                {
                    labelResult.Text = "Approved";
                    labelResult.ForeColor = System.Drawing.Color.LimeGreen;
                }
                else
                {
                    labelResult.Text = "Rejected";
                    labelResult.ForeColor = System.Drawing.Color.Red;
                }
            }

            if (comboBoxRule.Text == "Unanimity")
            {
                if (YesStates > 27)
                {
                    labelResult.Text = "Approved";
                    labelResult.ForeColor = System.Drawing.Color.LimeGreen;
                }
                else
                {
                    labelResult.Text = "Rejected";
                    labelResult.ForeColor = System.Drawing.Color.Red;
                }
            }
            //
            textBoxYesStates.Text = Convert.ToString(YesStates);
            textBoxNoStates.Text = Convert.ToString(NoStates);
            textBoxAbStates.Text = Convert.ToString(AbStates);
            textBoxYesPop.Text = Convert.ToString($"{YesPop}%");
            textBoxNoPop.Text = Convert.ToString($"{NoPop}%");
            textBoxAbPop.Text = Convert.ToString($"{AbPop}%");
        }

        public VotingCalculator()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            Voting();
        }
    }
}

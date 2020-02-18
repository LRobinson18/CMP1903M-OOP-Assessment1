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
            /*State variables initially set to 0 (integer)
              Population variables initially set to 0 (floating point type - 'double')*/
            
            int YesStates = 0;
            int NoStates = 0;
            int AbStates = 0;
            double YesPop = 0;
            double NoPop = 0;
            double AbPop = 0;
            var Countries = new Dictionary<System.Windows.Forms.ComboBox,double>()
            {
                //Dictionary containing all EU countries and their respective percentages

                {comboBoxAustria,1.98},
                {comboBoxBelgium,2.56},
                {comboBoxBulgaria,1.56},
                {comboBoxCroatia,0.91},
                {comboBoxCyprus,0.20},
                {comboBoxCzechRepublic,2.35},
                {comboBoxDenmark,1.30},
                {comboBoxEstonia,0.30},
                {comboBoxFinland,1.23},
                {comboBoxFrance,14.97},
                {comboBoxGermany,18.53},
                {comboBoxGreece,2.40},
                {comboBoxHungary,2.18},
                {comboBoxIreland,1.10},
                {comboBoxItaly,13.64},
                {comboBoxLatvia,0.43},
                {comboBoxLithuania,0.62},
                {comboBoxLuxembourg,0.14},
                {comboBoxMalta,0.11},
                {comboBoxNetherlands,3.89},
                {comboBoxPoland,8.49},
                {comboBoxPortugal,2.30},
                {comboBoxRomania,4.34},
                {comboBoxSlovakia,1.22},
                {comboBoxSlovenia,0.47},
                {comboBoxSpain,10.49},
                {comboBoxSweden,2.29}
            };
            
            foreach (KeyValuePair<System.Windows.Forms.ComboBox,double> Country in Countries)
            {
                var choice = (Country.Key).Text;
                if (choice == "Yes") {YesStates++; YesPop += Country.Value;}
                else if (choice == "No") { NoStates++; NoPop += Country.Value;}
                else { AbStates++; AbPop += Country.Value;}
            }

            if (comboBoxRule.Text == "Qualified Majority")
            {
                /* If Yes States are greater than 15 and Yes Population is greater than 65% - Qualified Majority is Approved
                   otherwise Qualified Majority is Rejected */
                
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
                /* If Yes States are greater than 20 and Yes Population is greater than 65% - Reinforced Qualified Majority is Approved
                   otherwise Reinforced Qualified Majority is Rejected */

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
                /* If Yes States are greater than 14 - Simple Majority is Approved
                   otherwise Simple Majority is Rejected */
                
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
                /* If all states vote "Yes" or "Abstain" - Unanimity is Approved
                   If 1 or more states vote "No" - Unanimity is Rejected */
                
                if (YesStates == 27 - AbStates)
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

            //Converts the State/Population text to a String Data Type

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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

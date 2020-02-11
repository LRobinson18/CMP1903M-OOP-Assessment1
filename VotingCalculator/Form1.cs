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
            Console.WriteLine(YesStates);
            textBoxYesStates.Text = Convert.ToString(YesStates);
            labelResult.Text = "Rejected";
            labelResult.ForeColor = System.Drawing.Color.Red;
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

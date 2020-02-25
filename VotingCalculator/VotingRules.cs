using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingCalculator
{
    class VotingRules
    {
        //creating a list allows the methods to return 2 results, both necessary for the final outcome
        // the first result is the voting outcome and the last is the outcome message's colour
        public List<string> QualifiedMajority(int YesStates, double YesPop)
        {
            List<string> result = new List<string>();
            if (YesStates > 15 && YesPop > 65)
            {
                result.Add("Approved");
                result.Add("LimeGreen");
                return result;
            }
            else
            {
                result.Add("Rejected");
                result.Add("Red");
                return result;
            }
        }

        public List<string> ReinforcedQualifiedMajority(int YesStates, double YesPop)
        {
            List<string> result = new List<string>();
            if (YesStates > 20 && YesPop > 65)
            {
                result.Add("Approved");
                result.Add("LimeGreen");
                return result;
            }
            else
            {
                result.Add("Rejected");
                result.Add("Red");
                return result;
            }
        }

        public List<string> SimpleMajority(int YesStates)
        {
            List<string> result = new List<string>();
            if (YesStates > 14)
            {
                result.Add("Approved");
                result.Add("LimeGreen");
                return result;
            }
            else
            {
                result.Add("Rejected");
                result.Add("Red");
                return result;
            }
        }

        public List<string> Unanimity(int YesStates, int AbStates)
        {
            List<string> result = new List<string>();
            if (YesStates == 27 - AbStates)
            {
                result.Add("Approved");
                result.Add("LimeGreen");
                return result;
            }
            else
            {
                result.Add("Rejected");
                result.Add("Red");
                return result;
            }
        }
    }
}

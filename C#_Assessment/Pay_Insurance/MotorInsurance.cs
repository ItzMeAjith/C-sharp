using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay_Insurance
{
    internal class MotorInsurance:Insurance
    {
        private double idv;
        private double depPercent;
        double premium = 0;
        public double Idv { get {  return idv; } set {  idv = value; } }
        public double DepPercent { get {  return depPercent; } set { depPercent = value; } }

        public double calculatePremium()
        {
            Idv =AmountCovered-((AmountCovered*DepPercent)/100);
            Idv = AmountCovered - ((AmountCovered * DepPercent) / 100);
            return 0.03 * Idv;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay_Insurance
{
    internal class LifeInsurance:Insurance
    {
        private int policyTerm;
        private float benefitPercent;

        public int PolicyTerm { get { return policyTerm; } set {  policyTerm = value; } }
        public float BenefitPercent { get {  return benefitPercent; } set {  benefitPercent = value; } }

        public double calculatePremium()
        {
            double premium = (AmountCovered - ((AmountCovered * BenefitPercent) / 100)) / PolicyTerm;
            return premium;
        }
    }
}

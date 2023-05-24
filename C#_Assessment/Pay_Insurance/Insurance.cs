using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay_Insurance
{
    internal class Insurance
    {
        private string? insuranceNumber;
        private string? insuranceName;
        private double amountCovered;

        public string? InsuranceNumber { get { return insuranceNumber; } set {  insuranceNumber = value; } }
        public string? InsuranceName { get {  return insuranceName; } set { insuranceName = value; } }
        public double AmountCovered { get {  return amountCovered; } set {  amountCovered = value; } }


    }
}

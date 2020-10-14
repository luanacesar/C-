using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionDemo
{
    class SalesTransaction
    {
        string name;
        private double salesAmount;
        private double comission;
        private double comissionRate;

        public string Names
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                SalesTransaction();
            }
        }
        public double SalesAmount
        {
            get
            {
                return salesAmount;
            }
            set
            {
                salesAmount = value;

            }
        }
        public double Comission
        {
            get
            {
                return comission;
            }
            set
            {
                comission = value;

            }
        }
        public double ComissionRate
        {
            get
            {
                return comissionRate;
            }
            set
            {
                comissionRate = value;
            }
        }
      
        SalesTransaction ( string name, double salesAmount,  double commissionRate)
        {
           
        }


    }
}


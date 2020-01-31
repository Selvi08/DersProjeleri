using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelviGultaslarProject
{
    public abstract class Credit
    {
        public int Maturity { get; set; }
        public double Amount { get; set; }
        public int Score { get; set; }

        public double InterestRate { get; set; }
        public abstract List<PaymentTable> CreatePaymentTable();

        public double GetInterestRate(){
            if (this.Score > 180)
                return this.InterestRate * 0.90;
            if (this.Score > 160)
                return this.InterestRate * 0.92;
            if (this.Score > 140)
                return this.InterestRate * 0.94;
            if (this.Score > 120)
                return this.InterestRate * 0.96;
            if (this.Score > 100)
                return this.InterestRate * 0.98;
            else return this.InterestRate;
        }
    }


    public class Ihtiyac : Credit
    {
        public bool IsBireysel { get; set; }  
        public override List<PaymentTable> CreatePaymentTable()
        {
            List<PaymentTable> result = new List<PaymentTable>();
            double fileExpense = 0;
            if (this.IsBireysel)
                fileExpense += 400;
            else
                fileExpense += 0;


            double totalAmount = this.Amount+(this.Amount * (this.GetInterestRate() / 100) * this.Maturity)+fileExpense;

            int id = 0;
            while (Maturity > id)
            {
                id++;
                PaymentTable entity = new PaymentTable();
                entity.ID = id;
                entity.Amount = totalAmount / Maturity;
                entity.PaymentDate = System.DateTime.Today.AddMonths(id);
                entity.RemainingBalance = totalAmount - (id * entity.Amount);
                result.Add(entity);
            }
            return result;
        }
    }

    public class Konut : Credit
    {
        public int HouseAge { get; set; }        
        public bool IsNew { get; set; }
        public override List<PaymentTable> CreatePaymentTable()
        {
            List<PaymentTable> result = new List<PaymentTable>();
            double profitRate = this.GetInterestRate();

            if (!this.IsNew)
            {
                if (this.HouseAge > 5)
                    profitRate = profitRate * 1.1;
                if (this.HouseAge>10)
                    profitRate = profitRate * 1.3;
                if (this.HouseAge > 25)
                    profitRate = profitRate * 1.5;
            }

            double totalAmount = this.Amount + (this.Amount * (profitRate / 100) * this.Maturity);

            int id = 0;
            while (Maturity > id)
            {
                id++;
                PaymentTable entity = new PaymentTable();
                entity.ID = id;
                entity.Amount = totalAmount / Maturity;
                entity.PaymentDate = System.DateTime.Today.AddMonths(id);
                entity.RemainingBalance = totalAmount - (id * entity.Amount);
                result.Add(entity);
            }
            return result;
        }
    }

    public class Arac : Credit
    {
        public bool IsNew { get; set; }
        public override List<PaymentTable> CreatePaymentTable()
        {
            List<PaymentTable> result = new List<PaymentTable>();
            double profitRate = this.GetInterestRate();

            if (this.IsNew)
                profitRate = profitRate * 0.5;         


            double totalAmount = this.Amount + (this.Amount * (profitRate / 100) * this.Maturity) ;

            int id = 0;
            while (Maturity > id)
            {
                id++;
                PaymentTable entity = new PaymentTable();
                entity.ID = id;
                entity.Amount = totalAmount / Maturity;
                entity.PaymentDate = System.DateTime.Today.AddMonths(id);
                entity.RemainingBalance = totalAmount - (id * entity.Amount);
                result.Add(entity);
            }
            return result;
        }
    }

    public class Arsa : Credit
    {
        public bool IsImarli { get; set; }
        public override List<PaymentTable> CreatePaymentTable()
        {
            List<PaymentTable> result = new List<PaymentTable>();
            double fileExpense = 0;
            if (this.IsImarli)
                fileExpense += 2000;
            else
                fileExpense += 0;


            double totalAmount = this.Amount + (this.Amount * (this.GetInterestRate() / 100) * this.Maturity) + fileExpense;

            int id = 0;
            while (Maturity > id)
            {
                id++;
                PaymentTable entity = new PaymentTable();
                entity.ID = id;
                entity.Amount = totalAmount / Maturity;
                entity.PaymentDate = System.DateTime.Today.AddMonths(id);
                entity.RemainingBalance = totalAmount - (id * entity.Amount);
                result.Add(entity);
            }
            return result;
        }
    }


    public class PaymentTable
    {
        public int ID { get; set; }
        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
        public double RemainingBalance { get; set; }
    }
}

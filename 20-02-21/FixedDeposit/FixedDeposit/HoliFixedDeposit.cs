using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedDeposit
{
    class HoliFixedDeposit:IFixedDeposit
    {
        private int _accno;
        private string _name;
        private double _amt;
        private double _principal;
        private int _years;
        private FestivalType _fest;

        public HoliFixedDeposit(int accno, string name, double principal, int years, FestivalType fest)
        {
            this._accno = accno;
            this._name = name;
            this._principal = principal;
            this._years = years;
            this._fest = fest;
        }

        int IFixedDeposit.getAccno { get => this._accno; }
        string IFixedDeposit.getName { get => this._name; }
        double IFixedDeposit.getPrincipa { get => this._principal; }
        int IFixedDeposit.getyears { get => this._years; }
        int IFixedDeposit.getFestival { get => (int)this._fest; }

        double IFixedDeposit.CalculateFixedDeposit()
        {
            int temp = (int)_fest;
            Console.WriteLine("Interest: " + temp + "%");

            this. _amt = this._principal * this._years * temp / 100;
            return this._amt;

        }
        double IFixedDeposit.GetFinalAmount { get => this._principal + this._amt; }

    }
}

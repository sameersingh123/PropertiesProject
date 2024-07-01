using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProject
{
     class ReviseBank
    {
        int _CustId;
        bool _Status;
        string _CustName;
        double _Balance;
        Cities _City;
        public string State { get; set; }
        public string Country { get; } = "India";
        public ReviseBank(int custId, bool status, string custName, double balance,Cities city,string state)
        {
            this._CustId = custId;
            this._Status = status;
            this._CustName = custName;
            this._Balance = balance;
            this._City = city;
            this.State = state;
        }

        public int CustId
        {
            get { return _CustId; }
        }

        public bool Status
        {
            get { return _Status; }
        }
        public string CustName
        {
            get { return _CustName; }
            set
            {
                if(_Status == true)
                {
                    _CustName = value;
                }   
            }
        }
        public double Balance
        {
            get { return _Balance; }
            set
            {
                if(_Status==true && value >= 500)
                {
                    _Balance = value;
                }
            }
        }
        public Cities City
        {
            get { return _City; }
            set
            {
                if(_Status == true)
                {
                    _City = value;
                }
            }
        }
        

    }
}

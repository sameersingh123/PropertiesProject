using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProject
{
    internal class Customer
    {
        int _CustId;
        bool _Status;
        string _CustName;
        double _Balance;
        Cities _City;
        String _State;
        //String _Country;
        public Customer(int CustId, bool Status,string CustName, double Balance,Cities City , string State /*string Country*/)
        {
            this._CustId = CustId;
            this._Status = Status;
            this._CustName = CustName;
            this._Balance = Balance;
            this._City=City;
            this._State=State;
            //this._Country = Country;
            //this.Country= Country;
        }
        public int CustId
        {
            get
            {
                return _CustId;
            }
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
                if (_Status == true)
                {
                    _CustName = value;
                }
            }
        }
        public double Balance
        {
            get {
                return _Balance;
                //if(_Status == true)
                //{
                //    return _Balance;
                //}
                //else
                //{
                //    return 0;
                //}
               }
            set
            {
                if (_Status == true && value>=500)
                {
                    _Balance = value;
                }
                
            }
        }
        
        public Cities City
        {
            get { return _City; }
            set { if(_Status==true) _City = value; }

        }
        public string State
        {
            get { return _State; }
            protected set { if (_Status == true) _State = value; }
        }
        public string Country   //Auto Implemented or Automatic Property
        {
            get;

        } = "India";
    }
}

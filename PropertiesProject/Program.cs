namespace PropertiesProject
{
    class Program
    {

        double _Radius = 12.67;
        public double GetRadius()  //Provies only get(access) to the value
        {
            return _Radius;
        }
        public void SetRadius(double value)  //Provides only set(modify) to the value
        {
            _Radius = value;
        }
        //A property is basically a combination of a get and set method
        public double Raduis
        {
            get                      //Represents a value returning method without a parameter
            {
                return _Radius;
            }
            set                      //Represents a non-value returning method with a parameter
            {
                if (value > _Radius)
                {
                    _Radius = value;   //this value is a parameter for the property Raduis
                }

            }


        }
    }

        public class Circle 
        { 
            static void Main()
          {
            Program p=new Program();
            p.Raduis = 14.67;                //calling set accessor of the property    //We are using just like a variable(field)
            Console.WriteLine(p.Raduis);    //calling get accessor of the property
          }

        }
    
}
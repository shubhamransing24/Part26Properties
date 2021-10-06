using System;

namespace Part26GetterAndSetter
{
    class Students
    {
        private int _rollno;
        private string _name;
        private int _passmark=35;
        public void StudentDetails()
        {
            Console.WriteLine(" Roll no={0} \n Name={1} \n Passmark ={2}", _rollno, _name, _passmark);
        }
        public int RollNo
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("roll no can not be null");

                }
                this._rollno = value;
            }
            get
            {
                return _rollno;
            }
        }

    
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name Can not be empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "no name" : this._name;
            }

        }
        public int Passmark
        {
            get
            {
                return _passmark;
            }
        }
    }
  

    class Program
    {


        static void Main(string[] args)
        {
            Students s = new Students();
            s.RollNo = 101;

            s.Name = "Shubham";
            
       
            s.StudentDetails();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV8.Entities
{
    internal class Student
    {
        // propfull tab
        private string _id;
        // KỸ THUẬT THIẾT KẾ CLAS MÀ XÀI _BACKING FIELD ĐI KÈM
        // GET SET KIỂU MỚI GỌI LÀ: FULL PROPERTY
        public string MyProperty
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _yob;

        public int Yob
        {
            get { return _yob; }
            set { _yob = value; }
        }
        






    }
}

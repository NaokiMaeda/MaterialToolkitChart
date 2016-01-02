using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialToolkitChart {
    class Data{
        public int value   { set; get; }
        public       int year    { set; get; }
        
        public Data() {
            value   = 100;
            year    = 2016;
        }

        public Data(int value , int year) {
            this.value = value;
            this.year = year;
        }

    }
}

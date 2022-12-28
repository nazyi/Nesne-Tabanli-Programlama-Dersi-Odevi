using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public abstract class ana
    {

        public string isim { get; set; }

        public string soyad { get; set; }
        public string renk { get; set; }
        private int _miktar { get; set; }
        public int Miktar
        {
            get { return _miktar; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else
                {
                    _miktar = value;
                }


            }
        }
        private int _bakiye { get; set; }
        public int bakiye
        {
            get { return _bakiye; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else
                {
                    _bakiye = value;
                }
            }
        }
        
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;              
                                           
namespace Lab49                            
{                                          
    class CarInfoEventArgs : EventArgs     
    {                                      
        public string Car { get; set; }    
                                           
        public CarInfoEventArgs(string car)
        {
            Car = car;
        }
    }
}

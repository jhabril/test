using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Console_arduino
{
    class Program
    {       

        static void Main(string[] args)
        {
            SerialPort port = new SerialPort();
            port.BaudRate=9600;
            port.PortName = "COM3";
            port.Open(); 
       
            port.Write("a");  

            port.Close();



            //nomames    
        }
    }
}

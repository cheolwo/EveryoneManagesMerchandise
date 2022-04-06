using System.IO.Ports;

namespace BusinessLogic.ofIOT
{
    public class LedManager
    {
        private SerialPort port;
        public LedManager(string PortName)
        {
            port = new SerialPort(PortName);
            port.BaudRate = 9600;
        }
        public void LedOn()
        {
            port.Open();
            port.Write("1");
            port.Close();
        }
        public void LedOff()
        {
            port.Open();
            port.Write("0");
            port.Close();
        }
    }
}

using System.IO.Ports;

namespace BusinessData.ofIot.Model
{
    public class IotSerialManager
    {
        private SerialPort port = new();
        public IotSerialManager(string PortName)
        {
            port.PortName = PortName;
            port.BaudRate = 9600;
        }
        public void LedOn()
        {
            port.Open();
            var Value = port.ReadExisting();
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

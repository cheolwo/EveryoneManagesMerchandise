using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofIot
{
    public class TempHumiditySerialManager
    {
        private SerialPort SerialPort = new();
        private Queue<float> QueTemperature = new();
        private Queue<float> QueHumidity = new();
        private static int Check;
        private float BufferValue { get; set; }
        private string ReadLineValue;

        public TempHumiditySerialManager(string PortName)
        {
            SerialPort.PortName = PortName;
            SerialPort.BaudRate = 9600;
            Check = 2;
        }
        public string ReadHumidityLineDataToString()
        {
            if (!SerialPort.IsOpen) { SerialPort.Open(); }
            if (Check % 2 == 0) // Humidity
            {
                ReadLineValue = SerialPort.ReadLine();
                try
                {
                    return ReadLineValue;   
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    SerialPort.Close();
                    Check++;
                }
            }
            return "";
        }
        public string ReadTempLineDataToString()
        {
            if (!SerialPort.IsOpen) { SerialPort.Open(); }
            if (Check % 2 == 1) // Temp
            {
                ReadLineValue = SerialPort.ReadLine();
                try
                {
                    return ReadLineValue;
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    SerialPort.Close();
                    Check++;
                }
            }
            return "";
        }
    }
}

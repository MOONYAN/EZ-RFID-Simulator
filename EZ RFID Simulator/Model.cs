using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace EZ_RFID_Simulator
{
    class Model
    {
        private List<String> _idList;
        private BindingList<Item> _orderList;
        private String[] _ports;
        private SerialPort _serialPort;
        JavaScriptSerializer _serializer;

        public Model()
        {
            _idList = new List<string>() { "-KNVTYhzfF3bSlr9N1eD", "-KNVUCDYIM8vLxBpgZBB", "-KNyzBP2hsUi0oyRfu1p", "-KOTmFKKe99jO2HuaDyH", "-KOiYmEFCCSAqUJZzbUo" };
            _orderList = new BindingList<Item>();
            _ports = SerialPort.GetPortNames();
            _serializer = new JavaScriptSerializer();
        }

        public String[] Ports
        {
            get
            {
                return _ports;
            }
        }

        public List<string> IdList
        {
            get
            {
                return _idList;
            }
        }

        public BindingList<Item> OrderList
        {
            get
            {
                return _orderList;
            }
        }        

        public void PickId(string id)
        {
            var ids = _orderList.Select(item => item.Id);
            if (!ids.Contains(id))
            {
                Item item = new Item()
                {
                    Id = id,
                    Count = 1
                };
                _orderList.Add(item);
            }
            else
            {
                int index = ids.ToList().IndexOf(id);
                _orderList[index].Count++;
            }
        }

        public void Send()
        {
            string json = _serializer.Serialize(_orderList);
            Console.WriteLine(json);
            _serialPort.WriteLine(json);
        }

        public void OpenPort(string portName)
        {
            if(_serialPort == null)
            {
                _serialPort = new SerialPort(portName);
                _serialPort.Open();
                Console.WriteLine(_serialPort.PortName + "is open");
            }
        }

        public void Clear()
        {
            _orderList.Clear();
        }        
    }
}

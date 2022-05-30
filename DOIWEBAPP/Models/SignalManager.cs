using System.Collections.Generic;

namespace DOIWEBAPP.Models
{
    public class SignalManager : ISignalService
    {
        public List<Signal> GetDigital()
        {
            List<Signal> Signal_list = new List<Signal>();

            Signal signal = new Signal() { Path = "Digital1" };
            Signal signal2 = new Signal() { Path = "Digital2" };
            Signal signal3 = new Signal() { Path = "Digital3" };
            Signal signal4 = new Signal() { Path = "Digital4" };

            Signal_list.Add(signal);
            Signal_list.Add(signal2);
            Signal_list.Add(signal3);
            Signal_list.Add(signal4);
            return Signal_list;
        }

        public List<Signal> GetAnalog()

        {
            List<Signal> Signal_list2 = new List<Signal>();

            Signal signal = new Signal() { Path = "Analog1" };
            Signal signal2 = new Signal() { Path = "Analog2" };
            Signal signal3 = new Signal() { Path = "Analog3" };
            Signal signal4 = new Signal() { Path = "Analog4" };

            Signal_list2.Add(signal);
            Signal_list2.Add(signal2);
            Signal_list2.Add(signal3);
            return Signal_list2;

        }
    }
}
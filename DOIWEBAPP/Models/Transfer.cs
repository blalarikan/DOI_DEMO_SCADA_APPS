using System.Collections.Generic;

namespace DOIWEBAPP.Models
{
    public class Transfer : ITransferService
    {
        private ISignalService _signalService;

        public Transfer(ISignalService signalService)
        {
            _signalService = signalService;
        }

        public List<Signal> GetAll()
        {
            List<Signal> list1 = _signalService.GetAnalog();
            List<Signal> list2 = _signalService.GetDigital();
            list1.AddRange(list2);
            return list1;

        }
    }
}
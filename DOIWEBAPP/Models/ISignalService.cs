using System.Collections.Generic;

namespace DOIWEBAPP.Models
{
    public interface ISignalService
    {
        List<Signal> GetAnalog();
        List<Signal> GetDigital();
    }
}
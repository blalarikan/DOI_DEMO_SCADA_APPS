using System.Collections.Generic;

namespace DOIWEBAPP.Models
{
    public interface ITransferService
    {
        List<Signal> GetAll();
    }
}
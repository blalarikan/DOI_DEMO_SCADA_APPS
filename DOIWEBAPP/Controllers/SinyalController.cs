using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOIWEBAPP.Models;
using Microsoft.AspNetCore.Mvc;


namespace DOIWEBAPP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SinyalController : ControllerBase
    {
        private ITransferService _transferService;

        public SinyalController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet]
        public List<Signal> GetAllSignals()
        {
            return _transferService.GetAll();
        }
    }
}


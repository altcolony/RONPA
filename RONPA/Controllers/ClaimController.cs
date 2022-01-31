using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RONPA.Application;
using RONPA.ViewModels;

namespace RONPA.Controllers
{
    public class ClaimController : Controller
    {
        private readonly ClaimApplication _claimApplication;
        public ClaimController(ClaimApplication claimApplication)
        {
            _claimApplication = claimApplication;
        }
        public IActionResult ClaimField()
        {
            try
            {
                var vm = new ClaimFieldVM()
                {
                    
                };

                return View(vm);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

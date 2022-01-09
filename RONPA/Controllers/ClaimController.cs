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
                    ClaimVMs = _claimApplication.GetAll()
                                               .Select(x => new ClaimVM
                                               {
                                                   Id = x.Id,
                                                   Text = x.Text,
                                                   CardVMs = x.Cards.Select(x => new CardVM() 
                                                                                 {
                                                                                    Id = x.Id,
                                                                                    Text = x.Text,
                                                                                 }).ToList(),
                                               })
                                               .ToList(),
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

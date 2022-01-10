using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RONPA.Application;
using RONPA.ViewModels;

namespace RONPA.Controllers
{
    public class CardController : Controller
    {
        private readonly CardApplication _cardApplication;
        public CardController(CardApplication cardApplication)
        {
            _cardApplication = cardApplication;
        }
        public IActionResult CardField()
        {
            try
            {
                var result = _cardApplication.GetAll();
                var vm = new CardFieldVM()
                {
                    CardVMs = result.Select(x => new CardVM
                    {
                        Id = x.Id,
                        Text = x.Text,
                        EditBtnId = $"edit_{x.Id}",
                        RemoveBtnId = $"remove_{x.Id}",
                    }).ToList(),
                };
                    
                return View(vm);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult OnGenerateCard()
        {
            var vm = new CardVM() 
                         {
                            Id=2,
                            Text = string.Empty,
                            EditBtnId = $"edit_{2}",
                            RemoveBtnId = $"remove_{2}",
            };
            return PartialView("_Card",vm);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using new_testapp.Data;
using new_testapp.Data.Services;
using new_testapp.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace new_testapp.Controllers
{
    public class ActorsController : Controller
    {

        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }


        //get Actors/Create
        public IActionResult Create()
        {
            return View(); 
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {

            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }



        //get Actors/Details/1
        public async Task <IActionResult> Details(int id)
        {
            var actionDetails= await _service.GetByIdAsync(id);

            if (actionDetails == null) return View("NotFound");
            return View(actionDetails);

        }

        //get Actors/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var actionDetails = await _service.GetByIdAsync(id);
            if (actionDetails == null) return View("NotFound");
            return View(actionDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {

            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.UpdateAsync(id,actor);
            return RedirectToAction(nameof(Index));
        }

        //get Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actionDetails = await _service.GetByIdAsync(id);
            if (actionDetails == null) return View("NotFound");
            return View();
        }


        //The action name was set cause the controller is named different
        [HttpDelete, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }
    }
}

using MediatR;
using MedKomment.Models;
using MedKomment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedKomment.Controllers
{
    [Route("api/medicament")]
    [ApiController]
    public class MedicamentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMedicamentService _service;
        public MedicamentController(IMediator mediator, IMedicamentService service)
        {
            _mediator = mediator;
            _service = service;
        }
        #region old methods
        [HttpGet]
        [Route("getAll")]
        public ActionResult GetAll()
        {
            try
            {
                var medicaments = _service.GetAll().ToList();
                return Ok(Response<List<MedicamentDTO>>.Succeeded(medicaments));
            }
            catch(Exception ex)
            {
                return Ok(Response<List<MedicamentDTO>>.Failure("Something wrong (" + ex + ")!"));
            }
        }

        [HttpGet]
        [Route("getByName")]
        public ActionResult GetByName(string name)
        {
            try
            {
                var medicaments = _service.GetByName(name).ToList();
                return Ok(Response<List<MedicamentDTO>>.Succeeded(medicaments));
            }
            catch (Exception ex)
            {
                return Ok(Response<List<MedicamentDTO>>.Failure("Something wrong (" + ex + ")!"));
            }
        }
        
        [HttpGet]
        [Route("getByIngredients")]
        public ActionResult GetByIngredients(string ingredients)
        {
            try
            {
                var medicaments = _service.GetByIngredients(ingredients).ToList();
                return Ok(Response<List<MedicamentDTO>>.Succeeded(medicaments));
            }
            catch (Exception ex)
            {
                return Ok(Response<List<MedicamentDTO>>.Failure("Something wrong (" + ex + ")!"));
            }
        }

        #endregion

        #region new methods (using mediatr)

        [HttpPost]
        [Route("addNew")]
        public async Task<IActionResult> AddNew(MedicamentDTO medicament)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                var result = await _service.AddNewMedicamentAsync(medicament);

                return Ok(new { success = result });
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [Route("getAll2")]
        public async Task<IActionResult> getAll2()
        {
            try
            {
                var medicaments = await _service.GetAllMedicamentsAsync();

                return Ok(Response<List<MedicamentDTO>>.Succeeded(medicaments));
            }
            catch (Exception ex)
            {
                return Ok(Response<List<MedicamentDTO>>.Failure("Something wrong : " + ex));
            }
        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SacramentPlanner.Models;
using SacramentPlanner.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SacramentPlanner.Controllers
{
    [Route( "api/[controller]" )]
    public class AgendasController : Controller
    {
        private readonly AgendaService _agendaService;

        public AgendasController( AgendaService agendaService )
        {
            _agendaService = agendaService;
        }

        // GET: api/agendas
        [HttpGet]
        public ActionResult<List<Agenda>> Get() =>
            _agendaService.Get();

        // GET api/agendas/5
        [HttpGet( "{id:length(24)}", Name = "GetAgenda" )]
        public ActionResult<Agenda> Get( string id )
        {
            Agenda agenda = _agendaService.Get( id );

            if ( agenda == null )
            {
                return NotFound();
            }

            return agenda;
        }

        // POST api/agendas
        [HttpPost]
        public ActionResult<Agenda> Create( [FromBody] Agenda agenda )
        {
            _agendaService.Create( agenda );

            return CreatedAtRoute( "GetAgenda", new { id = agenda.AgendaId }, agenda );
        }

        // PUT api/agendas/5
        [HttpPut( "{id:length(24)}" )]
        public IActionResult Update( string id, [FromBody] Agenda agendaIn )
        {
            Agenda agenda = _agendaService.Get( id );

            if ( agenda == null )
            {
                return NotFound();
            }

            _agendaService.Update( id, agendaIn );

            return NoContent();
        }

        // DELETE api/agendas/5
        [HttpDelete( "{id:length(24)}" )]
        public IActionResult Delete( string id )
        {
            Agenda agenda = _agendaService.Get( id );

            if ( agenda == null )
            {
                return NotFound();
            }

            _agendaService.Remove( id );

            return NoContent();
        }
    }
}

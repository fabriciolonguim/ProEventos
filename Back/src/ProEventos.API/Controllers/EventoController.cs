using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        public IEnumerable<Evento> _evento = new Evento[] 
        {
               new Evento()
               {
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "Pirangi",
                Lote = "1 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToLongDateString(),
                ImageURL = "foto.png"
              },
              new Evento()
               {
                EventoId = 2,
                Tema = "E suas novidades",
                Local = "Pirangi",
                Lote = "2 Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToLongDateString(),
                ImageURL = "foto.png"
              }

        };
       

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return  _evento;
           
        }

        [HttpGet("{id}")]
        
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]

        public string Post()
        {
            return "Executando Post";
        }

        [HttpPut("{id}")]

        public string Put(int id)
        {
            return "Exemplo de Put = {id}";
        }

        [HttpDelete("{id}")]

        public string Delete(int id)
        {
            return "Exemplo de Delete = {id}";
        }
    }
}

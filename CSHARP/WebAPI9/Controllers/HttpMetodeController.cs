using Microsoft.AspNetCore.Mvc;
using WebAPI9.Models;

namespace WebAPI9.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")] // ruta ce se zvati api/v1/HttpMetode
    public class HttpMetodeController : ControllerBase // nasljedjuje ControllerBase
    {


        // ovdje pocinje ruta 
        // ruta je metoda
        [HttpGet] // ovo je atribut koji govori da je ovo metoda za GET zahtjev
        public string HelloWorld() // metoda koja vraca string
        {
            return "Hello World!";
        }
        // ovdje zavrsava ruta



        // ovdje pocinje ruta
        [HttpGet]
        [Route("pozdrav")] // ruta ce se zvati api/v1/HttpMetode/pozdrav

        public string HelloWorld(string ime) // metoda koja vraca string
        {
            return $"Hello {ime}!";
        }


        // ovdje zavrsava ruta


        // ovdje pocinje ruta

        [HttpGet]
        [Route("json")] // ruta ce se zvati api/v1/HttpMetode/json

        public IActionResult GetJson(string ime, int godina) // metoda koja vraca JSON
        {
            return Ok(new {Ime= ime, Prezime= "Doe", godina});
        }
        // ovdje završava ruta




        // ovdje pocinje ruta
        [HttpPost]
        public IActionResult Post (Osoba osoba) // metoda koja prima JSON
        {
            osoba.Ime = "Hello " + osoba.Ime;
            return StatusCode(StatusCodes.Status201Created, osoba); // vraca status 201 - StatusCode (201, osoba)
        }
        // ovdje zavrsava ruta


        //ovdje pocinje ruta
        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            osoba.Ime = "Promjenio " + osoba.Ime;
            return Ok (osoba); 
        }


        //ovdje zavrsava ruta




        // ovdje pocinje ruta
        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if (sifra <= 0)
            {
                return BadRequest(new {poruka = "Sifra mora biti veca od 0" });
            }
            else
            {
                return Ok(new {poruka = "Obrisano" });
            }
        }
        // ovdje zavrsava ruta


    }
}

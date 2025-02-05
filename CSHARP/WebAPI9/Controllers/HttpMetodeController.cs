using Microsoft.AspNetCore.Mvc;

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




    }
}

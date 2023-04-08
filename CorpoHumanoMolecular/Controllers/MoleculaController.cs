using CorpoHumanoMolecular.Entites.Constantes;
using CorpoHumanoMolecular.Entites.Model;
using CorpoHumanoMolecular.Service;
using Microsoft.AspNetCore.Mvc;


namespace CorpoHumanoMolecular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoleculaController : ControllerBase
    {
        DnaRnaService dnaRnaService;
        public MoleculaController()
        {
            dnaRnaService = new DnaRnaService();
        }

        

        [HttpGet("DNA")]
        public ActionResult<List<Nucletidio>> GetDna(string Gene)
        {
            return Ok(dnaRnaService.FitaDna(Gene));
        }

        [HttpGet("RNA")]
        public ActionResult<List<Nucletidio>> GetRNA(string Gene)
        {
            return Ok(dnaRnaService.FitaRna(Gene));
        }

        // GET api/<MoleculaController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<MoleculaController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<MoleculaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MoleculaController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

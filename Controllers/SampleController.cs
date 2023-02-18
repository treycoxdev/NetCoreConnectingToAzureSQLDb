using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using NetCoreConnectingToAzureSQLDb.Models;
using NetCoreConnectingToAzureSQLDb.Data;
using Microsoft.EntityFrameworkCore;

namespace NetCoreConnectingToAzureSQLDb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {

        private DataContext _context;

        public SampleController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<List<Sample>>> Get()
        {
            return Ok(await _context.Sample.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sample>> Get(int id)
        {
            var Sample = await _context.Sample.FindAsync(id);
            if (Sample == null)
            {
                return BadRequest("Sample not found");
            }
            return Ok(Sample);
        }


        [HttpPost]
        public async Task<ActionResult<List<Sample>>> AddSample(Sample Sample)
        {
            _context.Sample.Add(Sample);
            await _context.SaveChangesAsync();
            return Ok(Sample);
        }

        [HttpDelete]
        public async Task<ActionResult<List<Sample>>> Delete(int id)
        {
            var Sample = await _context.Sample.FindAsync(id);
            if (Sample == null)
            {
                return BadRequest("Sample not found");
            }
            _context.Sample.Remove(Sample);
            await _context.SaveChangesAsync();

            return Ok(Sample);
        }
    }
}
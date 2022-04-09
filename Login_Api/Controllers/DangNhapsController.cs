#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Login_Api.Data;
using Login_Api.Models;

namespace Login_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DangNhapsController : ControllerBase
    {
        private readonly TuyensinhContext _context;

        public DangNhapsController(TuyensinhContext context)
        {
            _context = context;
        }

        // GET: api/DangNhaps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DangNhap>>> GetDangNhaps()
        {
            return await _context.DangNhaps.ToListAsync();
        }

        // GET: api/DangNhaps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DangNhap>> GetDangNhap(int id)
        {
            var dangNhap = await _context.DangNhaps.FindAsync(id);

            if (dangNhap == null)
            {
                return NotFound();
            }

            return dangNhap;
        }

        // PUT: api/DangNhaps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDangNhap(int id, DangNhap dangNhap)
        {
            if (id != dangNhap.LoginId)
            {
                return BadRequest();
            }

            _context.Entry(dangNhap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DangNhapExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DangNhaps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DangNhap>> PostDangNhap(DangNhap dangNhap)
        {
            _context.DangNhaps.Add(dangNhap);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DangNhapExists(dangNhap.LoginId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDangNhap", new { id = dangNhap.LoginId }, dangNhap);
        }

        // DELETE: api/DangNhaps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDangNhap(int id)
        {
            var dangNhap = await _context.DangNhaps.FindAsync(id);
            if (dangNhap == null)
            {
                return NotFound();
            }

            _context.DangNhaps.Remove(dangNhap);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DangNhapExists(int id)
        {
            return _context.DangNhaps.Any(e => e.LoginId == id);
        }
    }
}

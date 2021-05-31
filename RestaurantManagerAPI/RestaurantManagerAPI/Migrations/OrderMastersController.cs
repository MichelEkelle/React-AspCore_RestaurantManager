using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagerAPI.Models;

namespace RestaurantManagerAPI.Migrations
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderMastersController : ControllerBase
    {
        private readonly RestaurantDbContext _context;

        public OrderMastersController(RestaurantDbContext context)
        {
            _context = context;
        }

        // GET: api/OrderMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderMasters>>> GetOrderMasters()
        {
            return await _context.OrderMasters.ToListAsync();
        }

        // GET: api/OrderMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderMasters>> GetOrderMasters(int id)
        {
            var orderMasters = await _context.OrderMasters.FindAsync(id);

            if (orderMasters == null)
            {
                return NotFound();
            }

            return orderMasters;
        }

        // PUT: api/OrderMasters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderMasters(int id, OrderMasters orderMasters)
        {
            if (id != orderMasters.OrderMasterID)
            {
                return BadRequest();
            }

            _context.Entry(orderMasters).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderMastersExists(id))
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

        // POST: api/OrderMasters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderMasters>> PostOrderMasters(OrderMasters orderMasters)
        {
            _context.OrderMasters.Add(orderMasters);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderMasters", new { id = orderMasters.OrderMasterID }, orderMasters);
        }

        // DELETE: api/OrderMasters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderMasters(int id)
        {
            var orderMasters = await _context.OrderMasters.FindAsync(id);
            if (orderMasters == null)
            {
                return NotFound();
            }

            _context.OrderMasters.Remove(orderMasters);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderMastersExists(int id)
        {
            return _context.OrderMasters.Any(e => e.OrderMasterID == id);
        }
    }
}

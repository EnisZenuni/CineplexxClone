
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Domain.Models;
using Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Repository.Implementation;
using Repository.Interface;
using Service.Interface;

namespace TicketManagment.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ITicketService _ticketService;
        private readonly IMovieService _movieService;
        

        public TicketsController(ITicketService ticketService,IMovieService movieService)
        {
            _ticketService = ticketService;
            _movieService = movieService;
        }

        // GET: Tickets

        //TODO be careful here for the Movie to 
        public async Task<IActionResult> Index()
        {
            //var applicationDbContext = _context.Ticket.Include(t => t.Movie);
            return View(_ticketService.GetAllTickets());
        }

        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /* var ticket = await _context.Ticket
                .Include(t => t.Movie)
                .FirstOrDefaultAsync(m => m.TicketId == id); */

            var ticket = _ticketService.GetDetailsForTicket(id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            ViewData["MovieId"] = new SelectList((System.Collections.IEnumerable)this._movieService.GetDetailsForMovies(Int32.Parse("MovieId")), "MovieId", "MovieName");
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        // public async Task<IActionResult> Create([Bind("TicketId,TicketPrice,TicketNo,dateTime,MovieId")] Ticket ticket)
        public async Task<IActionResult> Create(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
              _ticketService.CreateNewTicket(ticket);
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList((System.Collections.IEnumerable)_movieService.GetDetailsForMovies(ticket.Movie.Id), "MovieId", "MovieName", ticket.MovieId);
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = _ticketService.GetDetailsForTicket(id??0);
            if (ticket == null)
            {
                return NotFound();
            }
            ViewData["MovieId"] = new SelectList((System.Collections.IEnumerable)_movieService.GetDetailsForMovies(ticket.Movie.Id), "MovieId", "MovieName", ticket.MovieId);
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        //public async Task<IActionResult> Edit(int id, [Bind("TicketId,TicketPrice,TicketNo,dateTime,MovieId")] Ticket ticket)
        public async Task<IActionResult> Edit(int id,Ticket ticket)
        {
            if (id != ticket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _ticketService.UpdateExistingTicket(ticket);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList((System.Collections.IEnumerable)_movieService.GetDetailsForMovies(ticket.Movie.Id), "MovieId", "MovieName", ticket.MovieId);
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = _ticketService.GetDetailsForTicket(id ?? 0);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _ticketService.DeleteTicket(id);
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _ticketService.GetDetailsForTicket(id) != null;  
        }

        public IActionResult AddToCart(int ticketId)
        {
            var ticket = _ticketService.GetDetailsForTicket(ticketId);
            
            var model = new AddToShoppingCartDTO();
            
            model.SelectedTicket = ticket;
            model.TicketId = ticket.Id;
            model.Quantity = 0;
            int id = ticket.MovieId;
           /* var movieTest = _context.Movie
            .FromSqlInterpolated($"SELECT MovieName FROM dbo.Movie")
            .Where(b => b.MovieId == id).ToString();*/

            //var movie = _context.Movie.FromSqlInterpolated($"SELECT * From Movie Where MovieId = {id}").FirstOrDefault();
            return View(model);
        }
        
        [HttpPost]
        public  async Task<IActionResult> AddToShoppingCart(AddToShoppingCartDTO model)
        {
            /*
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Where(u => u.Id == userId).Include("UserShoppingCart.TicketsInShoppingCarts").
            Include("UserShoppingCart.TicketsInShoppingCarts.Ticket").FirstOrDefault();

            var userShoppingCart = user.UserShoppingCart;
            if(userShoppingCart != null)
            {
                
                var ticket = _context.Ticket.Find(model.TicketId);
                if(ticket != null)
                {
                    TicketsInShoppingCart itemToAdd = new TicketsInShoppingCart()
                    {
                        Ticket = ticket,
                        TicketId = ticket.TicketId,
                        ShoppingCart = userShoppingCart,
                        Quantity = model.Quantity
                    };
                    _context.Add(itemToAdd);
                    await _context.SaveChangesAsync();
                }
            } 
            return RedirectToAction("Index","Movies");
            */
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = _ticketService.AddToShoppingCart(model, userId);

            if (result)
            {
                return RedirectToAction("Index", "Movies");
            }
            return RedirectToAction("Index");
        }


    }
}

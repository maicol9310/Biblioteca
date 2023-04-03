using Microsoft.AspNetCore.Mvc;
using Biblioteca.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Application.Books.Queries;
using MediatR;
using Biblioteca.Application.Books.Commands;

namespace Biblioteca.Web.Controllers
{
    public class BooksController : Controller
    {
        private IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<List<BookDto>> GetBooks()
        {
            return await _mediator.Send(new GetBooksQuery());
        }

        public IActionResult Index()
        {
            var result = GetBooks().Result.ToList();

            IEnumerable<BookDto> listBooks = result;

            return View(listBooks);
        }

        public async Task<ActionResult<bool>> PostBook(AddBookCommand command)
        {
            return await _mediator.Send(command);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddBookCommand book)
        {
            if (ModelState.IsValid)
            {
                PostBook(book);
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<ActionResult<BookDto>> Update(int? id)
        {
            var result = await _mediator.Send(new GetBookQuery { IBSN = id });

            BookDto book = result;

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateBookCommand command)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(command);
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(new DeleteBookCommand {IBSN = id});
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}

using Lab._56.RepositoryContracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab._7.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _booksRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _booksRepository = bookRepository;
        }

        [Route("/get")]
        public async Task<ActionResult> GetAll()
        {
            return Ok(_booksRepository.GetAll());
        }
    }
}

using BackNexos.Api.Application;
using BackNexos.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackNexos.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly IService _Service;
        public APIController(IService service)
        {
            _Service = service;
        } 

        [HttpGet]
        public IActionResult GetAuthorById (int id)
        {
            if(id != 0)
            {
                return Ok( _Service.GetAuthor(id));
            }
            else
            {
                return null;
            }
        }
        [HttpGet]
        public IActionResult GetAuthors()
        {
                return Ok(_Service.GetAuthors());
        }
        [HttpPost]
        public async  Task<IActionResult> AddAuthor(Author autor)
        {
            if (autor != null)
            {
                return Ok( await _Service.AddAuthor(autor));
            }
            else
            {
                return null;
            }
        }
        [HttpPut]
        public async Task<IActionResult> SaveAuthor(Author autor)
        {
            if (autor != null)
            {
                return Ok( await _Service.SaveAuthor(autor));
            }
            else
            {
                return null;
            }
        }
        [HttpDelete]
        public async Task DeleteAuthor(int id)
        {
            if (id != 0)
            {
                await _Service.DeleteAuthor(id);
            }
        }


        [HttpGet]
        public IActionResult GetEditorialById(int id)
        {
            if (id != 0)
            {
                return Ok(_Service.GetEditorial(id));
            }
            else
            {
                return null;
            }
        }
        [HttpGet]
        public IActionResult GetEditorials()
        {
            return Ok(_Service.GetEditorials());
        }
        [HttpPost]
        public async Task<IActionResult> AddEditorial(Editorial model)
        {
            if (model != null)
            {
                return Ok(await _Service.AddEditorial(model));
            }
            else
            {
                return null;
            }
        }
        [HttpPut]
        public async Task<IActionResult> SaveEditorial(Editorial model)
        {
            if (model != null)
            {
                return Ok(await _Service.SaveEditorial(model));
            }
            else
            {
                return null;
            }
        }
        [HttpDelete]
        public async Task DeleteEditorial(int id)
        {
            if (id != 0)
            {
                await _Service.DeleteEditorial(id);
            }
        }


        [HttpGet]
        public IActionResult GetBookById(int id)
        {
            if (id != 0)
            {
                return Ok(_Service.GetBookById(id));
            }
            else
            {
                return null;
            }
        }
        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_Service.GetBooks());
        }
        [HttpPost]
        public async Task<IActionResult> AddBook(Book model)
        {
            if (model != null)
            {
                var listeditorial = _Service.BookGetAllEditorialId(model.EditorialId);
                var editorial = _Service.GetEditorial(model.EditorialId);
                if (editorial.MaxbookRegister != -1)
                {
                    if (listeditorial.Count >= editorial.MaxbookRegister)
                    {
                        return Ok(JsonConvert.SerializeObject("Maxioalcanzado"));
                    }
                }
                return Ok(await _Service.AddBook(model));

            }
            else
            {
                return null;
            }
        }
        [HttpPut]
        public async Task<IActionResult> SaveBook(Book model)
        {

            if (model != null)
            {
                var data = await _Service.SaveBook(model);
                if (data == null)
                {
                    return Ok(JsonConvert.SerializeObject("Maxioalcanzado"));
                }
                return Ok(data);
            }
            else
            {
                return null;
            }
        }
        [HttpDelete]
        public async Task DeleteBook(int id)
        {
            if (id != 0)
            {
                await _Service.DeleteBook(id);
            }
        }
        [HttpGet]
        public IActionResult GetSearch(string value)
        {
            if (value != null)
            {
                return Ok(_Service.BookSearch(value));
            }
            else
            {
                return null;
            }
        }
    }
}

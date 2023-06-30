using BookBorrowing.API.Interfaces;
using BookBorrowing.API.Models;
using BookBorrowing.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookBorrowing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IRepositoryClient _repositoryClient;
        private readonly ClientServices _clientServices;

        public ClientController(IRepositoryClient repositoryClient)
        {
            _repositoryClient = repositoryClient;
        }

        public async Task<ActionResult<IEnumerable<Client>>> ReadAll() 
        {
            return Ok(await _clientServices._repositoryClient.ReadAll());
        }
    }
}

using BookBorrowing.API.Interfaces;
using BookBorrowing.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookBorrowing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IRepositoryClient _repositoryClient;

        public ClientController(IRepositoryClient repositoryClient)
        {
            _repositoryClient = repositoryClient;
        }

        public async Task<ActionResult<IEnumerable<Client>>> ReadAll() 
        {
            return Ok(await _repositoryClient.ReadAll);
        }
    }
}

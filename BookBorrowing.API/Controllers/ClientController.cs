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

        public ClientController(IRepositoryClient repositoryClient, BookBorrowingContext context)
        {
            _repositoryClient = repositoryClient;
            _clientServices = new ClientServices(context);
        }

        [HttpPost("Create")]
        public async Task<ActionResult> Create(Client _client) 
        {
            _clientServices._repositoryClient.Create(_client);
            if(await _clientServices._repositoryClient.SaveChanges())
            {
                return Ok("Cliente cadastrado com sucesso!");
            }

            return BadRequest("Erro: O Cliente não doi salvo :(");
        }

        [HttpGet("ReadAll")]
        public async Task<ActionResult<IEnumerable<Client>>> ReadAll()
        {
            return Ok(await _clientServices._repositoryClient.ReadAll());
        }
    }
}

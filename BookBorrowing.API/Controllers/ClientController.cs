using AutoMapper;
using BookBorrowing.API.DTO;
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
        private readonly IMapper _mapper;

        public ClientController(IRepositoryClient repositoryClient, BookBorrowingContext context, IMapper mapper)
        {
            _repositoryClient = repositoryClient;
            _clientServices = new ClientServices(context);
            _mapper = mapper;
        }

        [HttpPost("Create")]
        public async Task<ActionResult> Create(ClientDTO clientDTO) 
        {
            var client = _mapper.Map<Client>(clientDTO);
            _clientServices._repositoryClient.Create(client);
            if(await _clientServices._repositoryClient.SaveChanges())
            {
                return Ok("Cliente cadastrado com sucesso!");
            }

            return BadRequest("Erro: O Cliente não doi salvo :(");
        }

        [HttpGet("ReadAll")]
        public async Task<ActionResult<IEnumerable<Client>>> ReadAll()
        {
            var clients = await _clientServices._repositoryClient.ReadAll();
            var clientsDTO = _mapper.Map<IEnumerable<ClientDTO>>(clients);
            return Ok(clientsDTO);
        }

        [HttpPut("Update")]
        public async Task<ActionResult> Update(ClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            _clientServices._repositoryClient.Update(client);
            if (await _clientServices._repositoryClient.SaveChanges())
            {
                return Ok("Cliente alterado com sucesso!");
            }

            if (clientDTO.IdClient == null) 
            {
                return BadRequest("Cliente não pode ser alterado porque ele não foi encontrado...");
            }

            return BadRequest("Erro: O Cliente não foi alterado :(");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            var client = await _clientServices._repositoryClient.ReadById(id);
            _clientServices._repositoryClient.Delete(client);
            if (await _clientServices._repositoryClient.SaveChanges()) 
            {
                return Ok("Usuário deletado com sucesso!");
            }

            return NotFound("O usuário não foi encontrado :(");
        }


        [HttpGet("ReadById/{id}")]
        public async Task<IActionResult> ReadById(int id)
        {
            var client = await _clientServices._repositoryClient.ReadById(id);
            var clientDTO = _mapper.Map<ClientDTO>(client);
            if (client == null)
            {
                return NotFound("Usuário não encontrado");
            }

            return Ok(clientDTO);
        }
    }
}





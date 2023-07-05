using AutoMapper;
using BookBorrowing.API.DTO;
using BookBorrowing.API.Models;

namespace BookBorrowing.API.Mappings
{
    public class EntitysDTO : Profile   
    {
        public EntitysDTO()
        {
            CreateMap<Client, ClientDTO>().ReverseMap();
        }
    }
}

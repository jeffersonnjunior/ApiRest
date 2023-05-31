﻿using ApiFilmes.Data.Dtos;
using ApiFilmes.Models;
using AutoMapper;
//teste
namespace ApiFilmes.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}

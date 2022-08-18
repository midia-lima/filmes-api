using AutoMapper;
using FilmesAPI.Data.DTO;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles
{
	public class FilmesProfile : Profile
	{

		public FilmesProfile()
		{
			CreateMap<CreateFilmeDto, Filme>();
			CreateMap<Filme, ReadFilmeDto>();
			CreateMap<UpdateFilmeDto, Filme>();
		}		
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.DTO
{
	public class UpdateFilmeDto
	{
		private const string tituloRequired = "O campo título é obrigatório";
		private const string diretorRequired = "O campo diretor é obrigatório";
		private const string generoRequired = "O campo gênero não pode passar de 30 caracteres";
		private const string generoRange = "A duração deve ter no mínimo 1 e no máximo 600 minutos";

		[Required(ErrorMessage = tituloRequired)]
		public string Titulo { get; set; }

		[Required(ErrorMessage = diretorRequired)]
		public string Diretor { get; set; }

		[StringLength(30, ErrorMessage = generoRequired)]
		public string Genero { get; set; }

		[Range(1, 600, ErrorMessage = generoRange)]
		public int Duracao { get; set; }
	}
}

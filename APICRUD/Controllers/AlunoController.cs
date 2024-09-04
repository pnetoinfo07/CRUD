using CRUD._01_Entidades;
using CRUD._03_Aplicacao;
using Microsoft.AspNetCore.Mvc;

namespace APICRUD.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
	private readonly AlunoService _service;
	public AlunoController(IConfiguration config)
	{
		_service = new AlunoService(config);
	}
	[HttpPost("adicionar-aluno")]
	public void AdicionarAluno(Aluno aluno)
	{
		_service.Adicionar(aluno);
	}
}

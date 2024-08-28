using CRUD._01_Entidades;
using CRUD._03_Aplicacao;
using Microsoft.AspNetCore.Mvc;

namespace APICRUD.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
	private readonly AlunoService _service;
	public AlunoController()
	{
		_service = new AlunoService();
	}
	[HttpPost("adicionar-aluno")]
	public void AdicionarAluno(Aluno aluno)
	{
		_service.Adicionar(aluno);
	}
}

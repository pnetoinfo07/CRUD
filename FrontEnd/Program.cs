using CRUD;
using CRUD.Aplicacao;
using CRUD.Entidades;

SimuladorBD context = new SimuladorBD();
TimeService service = new TimeService(context);

Time time1 = new Time()
{
    Id = 1,
    Nome = "Milan",
    AnoCriacao = 1930
};
Time time2 = new Time()
{
    Id = 2,
    Nome = "Juventus",
    AnoCriacao = 1920
};
Time time3 = new Time()
{
    Id =3,
    Nome = "Manchester City",
    AnoCriacao = 2000
};

service.Adicionar(time1);
service.Adicionar(time2);
service.Adicionar(time3);
List<Time> times = service.Listar();
foreach (Time t in times)
{
    Console.WriteLine($"{t.Id}");
    Console.WriteLine($"{t.Nome}");
}
int id = 1;
Time editTIme = new Time();
editTIme.Nome = "Barcelona";
editTIme.AnoCriacao = 1930;

service.Editar(id, editTIme);

times = service.Listar();
foreach (Time t in times)
{
    Console.WriteLine($"{t.Id}");
    Console.WriteLine($"{t.Nome}");
}
//Time timeEscolhido = service.BuscarTimePorId(id);
//Console.WriteLine(timeEscolhido.Id);
//Console.WriteLine(timeEscolhido.Nome);

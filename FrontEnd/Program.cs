using CRUD;
using CRUD.Aplicacao;
using CRUD.Entidades;

SimuladorBD context = new SimuladorBD();
TimeService service = new TimeService(context);

Time time1 = new Time()
{
    Nome = "Milan",
    AnoCriacao = 1930
};
Time time2 = new Time()
{
    Nome = "Juventus",
    AnoCriacao = 1920
};
Time time3 = new Time()
{
    Nome = "Manchester City",
    AnoCriacao = 2000
};

service.Adicionar(time1);
service.Adicionar(time2);
List<Time> times = service.Listar();

foreach (Time t in times)
{
    Console.WriteLine($"{t.Nome}");
}

service.Remover(time1);
times = service.Listar();

foreach (Time t in times)
{
    Console.WriteLine($"{t.Nome}");
}

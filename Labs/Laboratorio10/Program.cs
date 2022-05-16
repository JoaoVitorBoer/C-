List<Pessoa> pessoas = new List<Pessoa>{
    new Pessoa{Nome="Ana",DataNascimento=new DateTime(1980,3,14), Casada=true},
    new Pessoa{Nome="Paulo",DataNascimento=new DateTime(1978,10,23), Casada=true}, 
    new Pessoa{Nome="Maria",DataNascimento=new DateTime(2000,1,10), Casada=false}, 
    new Pessoa{Nome="Carlos",DataNascimento=new DateTime(1999,12,12), Casada=false}
};


var linq1 = from p in pessoas
            where p.Casada
            select p;

foreach(var pessoa in linq1)
{
    Console.WriteLine(pessoa);
}

var linq2 = pessoas.Where(p => p.Casada);
foreach(var pessoa in linq2)
{
    Console.WriteLine(pessoa);
}

var linq3 = from p in pessoas
            where p.Casada                              
            select p.Nome;

var linq4 = pessoas.Where(p => p.Casada)
                   .Select(p => p.Nome)
                   .ToList();

linq4.ForEach(Console.WriteLine);

var linq5 = pessoas
            .Count(p => p.DataNascimento > new DateTime(1990,1,1));
            Console.WriteLine(linq5);

List<Pessoa> pessoas = new List<Pessoa>{
    new Pessoa{Nome="Ana",DataNascimento=new DateTime(1980,3,14), Casada=true},
    new Pessoa{Nome="Paulo",DataNascimento=new DateTime(1978,10,23), Casada=true}, 
    new Pessoa{Nome="Maria",DataNascimento=new DateTime(2000,1,10), Casada=false}, 
    new Pessoa{Nome="Carlos",DataNascimento=new DateTime(1999,12,12), Casada=false}
};


var linq1 = from p in pessoas
            where p.Casada && p.DataNascimento >= new DateTime(1980, 1 , 1)
            select p;

foreach(var pessoa in linq1)
{
    Console.WriteLine(pessoa);
}

var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980, 1 , 1));
foreach(var pessoa in linq2)
{
    Console.WriteLine(pessoa);
}

Console.WriteLine("\n");

var linq3 = from p in pessoas
            group p by p.Casada into grupoPessoas
            select new {Categoria=grupoPessoas.Key, Pessoas=grupoPessoas};  //Agrupamento de solteiras e casadas
foreach(var pessoa in linq3)
{
    Console.WriteLine(pessoa);
}



var linq4 = (from p in pessoas
            orderby p.DataNascimento
            select p).Take(1);              //Pegando a mais velha
foreach(var pessoa in linq4)
{
    Console.WriteLine(pessoa);
}


var linq5 = (from p in pessoas
            orderby p.DataNascimento descending         //Pegando a pessoa solteira mais nova
            where p.Casada == false
            select p).Take(1);
foreach(var pessoa in linq5)
{
    Console.WriteLine(pessoa);
}            
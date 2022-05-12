List<string> listaStrings = new List<string>();

listaStrings.Add("Um");
listaStrings.Add("Hello"); 
listaStrings.Add("World");
Console.WriteLine(listaStrings[0]);
Console.WriteLine(listaStrings[1]); 
Console.WriteLine(listaStrings[2]);

Queue<Object> q = new Queue<Object>();
q.Enqueue(".Net Framework");
q.Enqueue(new Decimal(123.456));
q.Enqueue(654.321);
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue()); 
Console.WriteLine(q.Dequeue());

Dictionary<int, string> paises = new Dictionary<int, string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises[55] = "Brasil";
Console.WriteLine("O código 55 é: {0}", paises[55]);

foreach (KeyValuePair<int, string> item in paises)
{
    int codigo = item.Key;
    string pais = item.Value;
    Console.WriteLine("Código {0} = {1}", codigo, pais);
}


List<int> val = new List<int>() {1,2,3,4,5,6,7,8,9,10,13,543,32,7,0,1};


static int AcimaMedia(List<int> k){
    List<int> retornar = new List<int>();
    int media = 7;
    foreach( var aux in k){
        if( aux >= media){
           retornar.Add(aux);    
        }
    }
    return retornar;
}

AcimaMedia(val);

Console.WriteLine(salva);
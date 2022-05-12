//Static Class (não posso instanaciar Ex: Pessoa p = new Pessoa(). Só posso chamar Ex: Pessoa.ObterNome.)
int x=10;
int y=3;
int quociente;
int resto = Math.DivRem(x,y,out quociente);
Console.WriteLine(quociente);
Console.WriteLine(resto);

static void swap(ref int x, ref int y){
    var tmp = x;
    x = y;
    y = tmp;
}

int a= 1;
int b = 2;
swap(ref a,ref b);  // Ao passar por referencia, conseguimos efetivamente trocar os valores.
Console.WriteLine(a); // Caso fosse swap(a,b) não haveria troca de e 'a' e 'b'.
Console.WriteLine(b);
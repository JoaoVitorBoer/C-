System.Text.StringBuilder sb1 = new System.Text.StringBuilder("teste");
System.Text.StringBuilder sb2 = sb1 ;//copia de referencia
sb1.Append(" alterado");
Console.WriteLine(sb1);   // vao printar as mesmas coisas
Console.WriteLine(sb2);

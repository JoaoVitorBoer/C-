DateTime[] dt = new DateTime[2]; 
int iDate;
dt[0] = new DateTime(2002, 5, 1);
dt[1] = new DateTime(2002, 6, 1); 

for (iDate = 0; iDate < 2; iDate++) 
{ 
    Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString());
    }

foreach( var data in dt){
    Console.WriteLine(" Data = " + data.ToShortDateString());
}

List<int> list1  = new List<int>(100);
int[] list2  = new int[100];
int i;
for(i = 0; i < 100; i++){
       list1.Add(i);
    //   Console.WriteLine(list1[i]);
}

list1.CopyTo(list2);

for(i = 0; i < 100; i++){
    //Console.WriteLine(list2[i]);
}

// Array multidimensional

int[,] multi = new int[5,5] { {1,2,3,4,5}, {6,7,8,9,10}, {11,12,13,14,15}, {16,17,18,19,20}, {21,22,23,24,25} };


// Jagged array

int[][] array = new int[2][];

array[0] = new int[5] {1,2,3,4,5};
array[1] = new int[5] {6,7,8,9,10};

for(int z = 0; z < array.Length; z++){
    
}
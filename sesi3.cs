using System;

public class Sesi2 
{
    public static void Main(string[] args)
    {
        
        // Console.Write("Nama: ");
        // string nama = Console.ReadLine();
        
        // Console.Write("Nilai: ");
        // int nilai = int.Parse(Console.ReadLine());

        // string hasil;

        // if(nilai < 60){
        //     hasil = "C";
        // }
        // else if(nilai < 80){
        //     hasil = "B";
        // }
        // else{
        //     hasil = "A";
        // }

        // Console.WriteLine($"Nilai {nama} {hasil}");

        // Console.Write("Nilai: ");
        // int nilai = int.Parse(Console.ReadLine());

        // switch (nilai)
        // {
        //     case 1:{
        //         Console.WriteLine("Jan");
        //         break;
        //     }
        //     case 2:{
        //         Console.WriteLine("Feb");
        //         break;
        //     }
        //     case 3:{
        //         Console.WriteLine("Mar");
        //         break;
        //     }
        //     case 4:{
        //         Console.WriteLine("Apr");
        //         break;
        //     }
        //     case 5:{
        //         Console.WriteLine("May");
        //         break;
        //     }
        //     case 6:{
        //         Console.WriteLine("Jun");
        //         break;
        //     }
        //     case 7:{
        //         Console.WriteLine("Jul");
        //         break;
        //     }
        //     case 8:{
        //         Console.WriteLine("Aug");
        //         break;
        //     }
        //     case 9:{
        //         Console.WriteLine("Sep");
        //         break;
        //     }
        //     case 10:{
        //         Console.WriteLine("Oct");
        //         break;
        //     }
        //     case 11:{
        //         Console.WriteLine("Nov");
        //         break;
        //     }
        //     case 12:{
        //         Console.WriteLine("Dec");
        //         break;
        //     }
            
        //     default:{
        //         Console.WriteLine("Unknown");
        //         break;
        //     }
        // }



        // Console.Write("N: ");
        // int n = int.Parse(Console.ReadLine());
        
        // while (n < 20)
        // {
        //      Console.WriteLine("Nilai n = " + n);
        //      n++;
        // }
        
        string op;
        int n1, n2;

        Console.Write("N1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("N2: ");
        n2 = int.Parse(Console.ReadLine());
        int temp;
        Console.Write("Operator (+, -, *, /) : ");
        op = Console.ReadLine();

        for (int i = n1; i <= n2; i++){
            Console.WriteLine($"i : {i}");
            temp = i;
            
            if(op == "+"){
                temp += n1;
            }
            else if(op == "-"){
                temp -= n1;
            }
            else if(op == "*"){
                temp *= n1;
            }
            else if(op == "/"){
                temp /= n1;
            }
            else{
                Console.WriteLine("Unknown");
            }
            Console.WriteLine($"Hasil : {i} + {n1} = {temp}");
            Console.WriteLine("");

            
        }

        // Console.Write("Operator (+, -, *, /) : ");
        // string op = Console.ReadLine();
        // int total;
    }
}
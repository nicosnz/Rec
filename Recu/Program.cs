namespace Recu{
    class Program{
        static void Main(string[] args){
            Auto car = new Auto("Auto","Combustible");
            Bicicleta bici = new Bicicleta("Bicicleta","Pedales");
            Scooter scooter = new Scooter("Scooter","electrico");
            Transporte[] trans = new Transporte[3];
            trans[0] = car;
            trans[1] = bici;
            trans[2] = scooter;
            Console.WriteLine("\tBIENVENIDO");

            while(true){
                Console.WriteLine("\t¿QUE QUIERES HACER?");
                Console.WriteLine("\t1.- VER LOS TRANSPORTES REGISTRADOS");    
                Console.WriteLine("\t2.- MOVER LOS TRANSPORTES");
                Console.WriteLine("\t0.- SALIR");
                Console.Write("\tOpcion: ");
                int opcion;
                string input = Console.ReadLine()!;
                while(!int.TryParse(input, out opcion) || opcion < 0 || opcion > 3){
                Console.WriteLine("\tOPCION NO VALIDA");
                Console.Write("\tINTENTA DE NUEVO: ");
                input = Console.ReadLine()!;
                }
                if(opcion == 1){
                    for (int i = 0; i < trans.Length; i++)
                    {
                        Console.WriteLine($"\t{i+1}.- {trans[i].getTipo()}");
                        
                    }   
                    Console.ReadKey();
                    Console.Clear();                 
                }
                
                if(opcion == 2){
                    for (int i = 0; i < trans.Length; i++)
                    {
                        trans[i].moverse();
                        
                    }   
                    Console.ReadKey();
                    Console.Clear();                 
                }
                
                if(opcion == 0){
                    break;           
                }
                
            }
                    
            
            


        }
    
    }
}
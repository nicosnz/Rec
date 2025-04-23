namespace Recu{
    class Auto:Transporte{

        string tipoCombustible;
        public Auto(string tipo, string tipoCombus):base(tipo){
            tipoCombustible = tipoCombus;
        }
        public override void moverse()
        {
            Console.WriteLine($"\tConduciendo usando {tipoCombustible}");
        }



    }


}
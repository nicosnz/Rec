namespace Recu{
    class Auto:Transporte{

        string tipoCombustible;
        public Auto(string nombreTransp,string tipoTrans, string tipoCombus):base(nombreTransp,tipoTrans){
            tipoCombustible = tipoCombus;
        }
        public override void moverse()
        {
            Console.WriteLine($"\tConduciendo usando {tipoCombustible}");
        }



    }


}
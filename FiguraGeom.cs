namespace ProiectClase
{
    //	Clasa FiguraGeom 
    public class FiguraGeom
    {
        string denumire;
        int nrLaturi;

        //	Constructor fara parametri
        public FiguraGeom()
        {
            denumire = string.Empty;
            nrLaturi = 0;
        }

        //	Constructor cu parametri
        public FiguraGeom(string _denumire, int _nrLaturi)
        {
            denumire = _denumire;
            nrLaturi = _nrLaturi;
        }

        //	Metoda care returneaza informatiile despre figura geometrica 
        //	sub forma unui sir de caractere
        public string Info()
        {
            return string.Format("Figura {0} are {1} laturi", denumire, nrLaturi);
        }
    }
}

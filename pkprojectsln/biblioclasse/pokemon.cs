using System.Runtime.InteropServices.Marshalling;

namespace biblioclasse
{
    /// <summary>
    /// Classe créant des pokemons
    /// </summary>
    public class Pokemon
    {
        private int _dexnumber;
        private string _nom;
        private int _level;
        private int _pv;
        private int _attaque;
        private int _defense;
        private int _attaquespe;
        private int _defensespe;
        private int _vitesse;
        private Type _type1;
        private Type _type2;

        //-----------------------------------------------------------------------------------------------------------------------//
        //---------------------------------------------Les Constructeurs---------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------------------------------//

        public Pokemon(int dexnumber, string nom, int level, int pv, int attaque, int defense, int attaquespe, int defensespe, int vitesse)
        {
            Dexnumber = dexnumber;
            Nom = nom;
            Level = level;
            Pv = pv;
            Attaque = attaque;
            Defense = defense;
            Attaquespe = attaquespe;
            Defensespe = defensespe;
            Vitesse = vitesse;
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------Les Accesseurs----------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------------------------------//

        public int Dexnumber
        { 
            get => _dexnumber;
            private set
            {
                _dexnumber = value;
            }
        }

        public string Nom 
        { 
            get => _nom;
            private set
            {
                _nom = value;
            }
        }

        public int Level 
        { 
            get => _level;
            private set
            {
                _level = value;
            }
        }

        public int Pv 
        { 
            get => _pv;
            private set
            {
                _pv = value;
            }
        }

        public int Attaque 
        { 
            get => _attaque;
            private set
            {
                _attaque = value;
            }
        }

        public int Defense 
        { 
            get => _defense;
            private set
            {
                _defense = value;
            }
        }

        public int Attaquespe 
        { 
            get => _attaquespe;
            private set
            {
                _attaquespe = value;
            }
        }

        public int Defensespe 
        { 
            get => _defensespe;
            private set
            {
                _defensespe = value;
            }
        }

        public int Vitesse 
        { 
            get => _vitesse;
            private set
            {
                _vitesse = value;
            }
        }
    }
}

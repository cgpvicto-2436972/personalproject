using System.Runtime.InteropServices.Marshalling;

namespace biblioclasse
{
    /// <summary>
    /// Classe créant des pokemons
    /// </summary>
    public class pokemon
    {
        private int _dexnumber;
        private string _name;
        private int _level;
        private int _pv;
        private int _attaque;
        private int _defense;
        private int _attaquespe;
        private int _defensespe;
        private int _vitesse;



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

        public string Name 
        { 
            get => _name;
            private set
            {
                _name = value;
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

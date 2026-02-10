using System.Runtime.InteropServices.Marshalling;

namespace biblioclasse
{
    /// <summary>
    /// Classe créant des pokemons
    /// </summary>
    public class Pokemon
    {
        private int dexnumber;
        private string name;
        private int level;
        private int pv;
        private int attaque;
        private int defense;
        private int attaquespe;
        private int defensespe;
        private int vitesse;

        //-----------------------------------------------------------------------------------------------------------------------//
        //---------------------------------------------Les Constructeurs---------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------------------------------//

        public Pokemon(int dexnumber, string name, int level, int pv, int attaque, int defense, int attaquespe, int defensespe, int vitesse)
        {
            this.dexnumber = dexnumber;
            this.name = name;
            this.level = level;
            this.pv = pv;
            this.attaque = attaque;
            this.defense = defense;
            this.attaquespe = attaquespe;
            this.defensespe = defensespe;
            this.vitesse = vitesse;
        }

        //-----------------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------Les Accesseurs----------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------------------------------//

        public int Dexnumber
        { 
            get => dexnumber;
            private set
            {
                dexnumber = value;
            }
        }

        public string Name 
        { 
            get => name;
            private set
            {
                name = value;
            }
        }

        public int Level 
        { 
            get => level;
            private set
            {
                level = value;
            }
        }

        public int Pv 
        { 
            get => pv;
            private set
            {
                pv = value;
            }
        }

        public int Attaque 
        { 
            get => attaque;
            private set
            {
                attaque = value;
            }
        }

        public int Defense 
        { 
            get => defense;
            private set
            {
                defense = value;
            }
        }

        public int Attaquespe 
        { 
            get => attaquespe;
            private set
            {
                attaquespe = value;
            }
        }

        public int Defensespe 
        { 
            get => defensespe;
            private set
            {
                defensespe = value;
            }
        }

        public int Vitesse 
        { 
            get => vitesse;
            private set
            {
                vitesse = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace biblioclasse
{
    public class Type
    {
        private int _id;
        private string _nom;
        private List<Type> type_avantage;
        private List<Type> type_desavantage;


        public Type(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        public int Id 
        { 
            get => _id; 
            set => _id = value; 
        }
        public string Nom 
        { 
            get => _nom; 
            set => _nom = value; 
        }
    }
}

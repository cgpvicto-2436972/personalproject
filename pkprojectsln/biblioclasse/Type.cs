using System;
using System.Collections.Generic;
using System.Text;

namespace biblioclasse
{
    public class Type
    {
        private int _id;
        private string _name;
        private List<Type> type_avantage;
        private List<Type> type_desavantage;


        public Type(int id, string name, Type typea1 = null, Type typea2 = null, Type typea3 = null, Type typea4 = null, Type typea5 = null, Type typed1 = null, Type typed2 = null, Type typed3 = null, Type typed4 = null, Type typed5 = null, Type typed6 = null, Type typed7 = null)
        {

        }

        public int Id 
        { 
            get => _id; 
            set => _id = value; 
        }
        public string Name 
        { 
            get => _name; 
            set => _name = value; 
        }
    }
}

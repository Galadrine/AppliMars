using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppliMars {

    public class Map {

        #region variables

        private string _nomMap;
        private int _longueur;
        private int _largueur;

        #endregion


        #region accesseurs

        public int maLongueur {
            get { return _longueur; }
            set { _longueur = value; }
        }


        public int maLargeur {
            get { return _largueur; }
            set { _largueur = value; }
        }


        public string monNom {
            get { return _nomMap; }
            set { _nomMap = value; }
        }

        #endregion


        #region constructeur

        public Map(string UneImage) {
        }

        #endregion


        #region methodes


        #endregion



    }

}
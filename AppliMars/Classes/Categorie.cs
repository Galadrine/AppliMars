using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppliMars {

    public class Categorie {

        #region variables

        private string _nomCategorie;
        private Categorie _superCategorie;
        private Categorie _sousCategorie;
        private List<Activite> _listeActivite;

        #endregion


        #region accesseurs

        public Categorie maSousCategorie {
            get { return _sousCategorie; }
            set { _sousCategorie = value; }
        }

        public Categorie maSuperCategorie {
            get { return _superCategorie; }
            set { _superCategorie = value; }
        }

        public string monNom {
            get { return _nomCategorie; }
            set { _nomCategorie = value; }
        }

        public List<Activite> maListe {
            get { return _listeActivite; }
            set { _listeActivite = value; }
        }

        #endregion


        #region constructeurs

        public Categorie(string unNom) {

        }

        #endregion



    }

}
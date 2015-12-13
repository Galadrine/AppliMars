using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppliMars {

    public class Categorie {


        /*
        #region variables

        private string _nomCategorie;
        //private Categorie _superCategorie;
        //private Categorie _sousCategorie;
        private List<string> _listeActivite;

        #endregion


        #region accesseurs

        //public Categorie maSousCategorie {
        //    get { return _sousCategorie; }
        //    set { _sousCategorie = value; }
        //}

        //public Categorie maSuperCategorie {
        //    get { return _superCategorie; }
        //    set { _superCategorie = value; }
        //}

        public string monNom {
            get { return _nomCategorie; }
            set { _nomCategorie = value; }
        }

        public List<string> maListe {
            get { return _listeActivite; }
            set { _listeActivite = value; }
        }

        #endregion


        #region constructeurs

        public Categorie(string unNom, List<string> listeActivites) {
            _nomCategorie = unNom;
            _listeActivite = listeActivites;
        }

        #endregion
        */


        
        #region variables

        private string _nomCategorie;
        private List<Categorie> _sousCategorie = new List<Categorie>();

        #endregion


        #region accesseurs

        public List<Categorie> maSousCategorie {
            get { return _sousCategorie; }
            set { _sousCategorie = value; }
        }

        public string monNom {
            get { return _nomCategorie; }
            set { _nomCategorie = value; }
        }


        #endregion


        #region constructeurs

        public Categorie(string unNom) {
            _nomCategorie = unNom;
        }

        #endregion


        #region méthodes

        public void ajoutSousCategorie(Categorie sc) {
            maSousCategorie.Add(sc);
        }

        #endregion
        


    }

}
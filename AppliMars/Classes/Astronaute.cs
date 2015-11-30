using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppliMars {

    public class Astronaute {

        #region variables
        private static List<Astronaute> _mesAstronautes;
        private string _nomAstronaute;

        #endregion accesseurs


        #region accesseurs

        public string monNom {
            get { return _nomAstronaute; }
            set { _nomAstronaute = value; }
        }

        #endregion


        #region constructeurs

        public Astronaute(string nomAstronaute) {
            monNom = nomAstronaute;
            _mesAstronautes.Add(this);
        }

        #endregion


        #region méthodes


        #endregion


    }

}
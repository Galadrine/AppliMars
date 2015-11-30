using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppliMars {

    public class Astronaute {

        #region variables

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
        }

        #endregion


        #region méthodes


        #endregion


    }

}
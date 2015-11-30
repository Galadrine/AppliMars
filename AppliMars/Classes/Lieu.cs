using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppliMars {

    public class Lieu {

        #region variables

        private string _nomLieu;
        private int _posXLieu;
        private int _posYLieu;

        #endregion


        #region accesseurs

        public int maPosX {
            get { return _posXLieu; }
            set { _posXLieu = value; }
        }
        public int maPosY {
            get { return _posYLieu; }
            set { _posYLieu = value; }
        }

        public string monNom {
            get { return _nomLieu; }
            set { _nomLieu = value; }
        }


        #endregion


        #region constructeurs

        public Lieu(string unNom, Double unePosX, Double unePosY) {

        }

        #endregion


        #region méthodes


        #endregion

    }

}
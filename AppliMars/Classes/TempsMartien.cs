using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliMars.Classes {
    class TempsMartien {

        #region variables

        private DateTime dateDebut;
        private DateTime dateFin;

        private int _jour;
        private int _heure;
        private int _minutes;
        private int _secondes;

        #endregion

        #region accesseurs

        public DateTime monDebut {
            get { return dateDebut; }
            set { dateDebut = value; }
        }

        public DateTime maFin {
            get { return dateFin; }
            set { dateFin = value; }
        }

        public int monJour {
            get { return _jour; }
            set { _jour = value; }
        }

        public int monHeure {
            get { return _heure; }
            set { _heure = value; }
        }

        public int mesMinutes {
            get { return _minutes; }
            set { _minutes = value; }
        }

        public int mesSecondes {
            get { return _secondes; }
            set { _secondes = value; }
        }

        #endregion

        public TempsMartien(DateTime debut) {
            monDebut = debut;
            System.TimeSpan duration = new System.TimeSpan(0, 0, (int)(1.0275*60*60*24*500));
            maFin = monDebut + duration;

            monJour = 1;
            monHeure = 0;
            mesMinutes = 0;
            mesSecondes = 0;
        }

    }
}

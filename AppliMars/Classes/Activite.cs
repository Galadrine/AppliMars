using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppliMars {

    public class Activite {

        #region variables

        public static int _nbActTotal = 0;
        public int _idAct;
        private Lieu _lieu;
        private List<Astronaute> _participants;
        private int _heuresDebut;
        private int _minutesDebut;
        private int _heuresFin;
        private int _minutesFin;
        private string _nom;
        private string _description;
        private bool _exterieur;

        #endregion


        #region accesseurs

        public int monNbActionTotal {
            get { return _nbActTotal; }
            set { _nbActTotal = value; }
        }

        public int monID {
            get { return _idAct; }
            set { _idAct = value; }
        }

        public Lieu monLieu {
            get { return _lieu; }
            set { _lieu = value; }
        }

        public bool enExterieur {
            get { return _exterieur; }
            set { _exterieur = value; }
        }

        public string maDescription {
            get { return _description; }
            set { _description = value; }
        }

        public string monNom {
            get { return _nom; }
            set { _nom = value; }
        }

        public List<Astronaute> mesAstronautes {
            get { return _participants; }
            set { _participants = value; }
        }

        public int mesMinutesFin {
            get { return _minutesFin; }
            set { _minutesFin = value; }
        }

        public int monHeureFin {
            get { return _heuresFin; }
            set { _heuresFin = value; }
        }

        public int mesMinutesDebut {
            get { return _minutesDebut; }
            set { _minutesDebut = value; }
        }

        public int monHeureDebut {
            get { return _heuresDebut; }
            set { _heuresDebut = value; }
        }

        #endregion


        #region constructeurs

        // Création d'une nouvelle instance d'activité (pas dans au chargement du XML)
        public Activite(string unNom, bool boolExt, string uneDesc, int HDebut, int MDebut, int HFin, int MFin, List<Astronaute> participants, string nomLieu, int posX, int posY) {
            this.initAct(unNom, boolExt, uneDesc, HDebut, MDebut, HFin, MFin, participants);
            monLieu = new Lieu(nomLieu, posX, posY);
            monID = _nbActTotal + 1;
            monNbActionTotal++;
        }


        public Activite(string unNom, bool boolExt, string uneDesc, int HDebut, int MDebut, int HFin, int MFin, List<Astronaute> participants)
            : this(unNom, boolExt, uneDesc, HDebut, MDebut, HFin, MFin, participants, "Habitat", 0, 0) { }


        // Création d'une nouvelle instance d'activité au chargement du XML (avec ID prédéfini)
        public Activite(string unNom, bool boolExt, string uneDesc, int HDebut, int MDebut, int HFin, int MFin, List<Astronaute> participants, string nomLieu, int posX, int posY, int idAct) {
            this.initAct(unNom, boolExt, uneDesc, HDebut, MDebut, HFin, MFin, participants);
            monLieu = new Lieu(nomLieu, posX, posY);
            monID = idAct;
            if (_nbActTotal < monID)
                _nbActTotal = monID;
            if (idAct > monNbActionTotal) {
                monNbActionTotal = idAct+1;
            }
        }


        public Activite(string unNom, bool boolExt, string uneDesc, int HDebut, int MDebut, int HFin, int MFin, List<Astronaute> participants, int idAct)
            : this(unNom, boolExt, uneDesc, HDebut, MDebut, HFin, MFin, participants, "Habitat", 0, 0, idAct) { }

        #endregion


        #region methodes

        public void initAct(string unNom, bool boolExt, string uneDesc, int HDebut, int MDebut, int HFin, int MFin, List<Astronaute> participants) {
            monNom = unNom;
            enExterieur = boolExt;
            maDescription = uneDesc;
            monHeureDebut = HDebut;
            mesMinutesDebut = MDebut;
            monHeureFin = HFin;
            mesMinutesFin = MFin;
            mesAstronautes = new List<Astronaute>();

            foreach (var ast in participants)
            {
                mesAstronautes.Add(ast);
            }

        }

        public string getDetailsActivites() {
            return monHeureDebut.ToString("D2") + "h" + mesMinutesDebut.ToString("D2") + " - " + monHeureFin.ToString("D2") + "h" + mesMinutesFin.ToString("D2") + " : " + monNom;
        }


        #endregion


    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppliMars
{
    public class Mission
    {

        #region variables

        private string _nomMission;
        private DateTime _dateDebut;
        private int _dureeMission;
        private DateTime _dateFin;
        private int _jourJ;
        private List<Astronaute> _astronautes;
        private int _nbAstronautes;
        private string _cheminGeneralXML;
        private string _cheminPlanningXML;
        private Planning _planning;

        #endregion


        #region accesseurs

        public string monNomMission {
            get { return _nomMission; }
            set { _nomMission = value; }
        }

        public DateTime maDateDebut {
            get { return _dateDebut; }
            set { _dateDebut = value; }
        }

        public int maDureeMission {
            get { return _dureeMission; }
            set { _dureeMission = value; }
        }

        public DateTime maDateFin {
            get { return _dateFin; }
            set { _dateFin = value; }
        }

        public int monJourJ {
            get { return _jourJ; }
            set { _jourJ = value; }
        }

        public List<Astronaute> mesAstronautes {
            get { return _astronautes; }
            set { _astronautes = value; }
        }

        public int monNbAstronautes {
            get { return _nbAstronautes; }
            set { _nbAstronautes = value; }
        }

        public string monCheminGeneralXML {
            get { return _cheminGeneralXML; }
            set { _cheminGeneralXML = value; }
        }

        public string monCheminPlanningXML {
            get { return _cheminPlanningXML; }
            set { _cheminPlanningXML = value; }
        }

        public Planning monPlanning {
            get { return _planning; }
            set { _planning = value; }
        }

        #endregion


        #region constructeurs 

        public Mission(string nomMission, DateTime dateDebut, int dureeMission, List<string> nomsAstronautes) {
            // Création de l'instance
            _nomMission = nomMission;
            _dateDebut = dateDebut;
            _dureeMission = dureeMission;
            _dateFin = _dateDebut.AddDays(_dureeMission);
            _jourJ = 1;
        }


        // Création d'une nouvelle mission (Création nouveaux XML)
        public Mission (string nomMission, DateTime dateDebut, int dureeMission, List<string> nomsAstronautes, string emplacementPlanningXML)
        {
            // Création de l'instance
            _nomMission = nomMission;
            _dateDebut = dateDebut;
            _dureeMission = dureeMission;
            _dateFin = _dateDebut.AddDays(_dureeMission);
            _jourJ = 1;
            _cheminPlanningXML = "" + emplacementPlanningXML + "Planning.xml";
            _cheminGeneralXML = "" + emplacementPlanningXML + "General.xml";
            // création des astronautes 
            _astronautes = new List<Astronaute>();
            _nbAstronautes = 0;
            foreach (string nom in nomsAstronautes)
            {
                _astronautes.Add(new Astronaute(nom));
                _nbAstronautes++;
            }

            // Création du fichier XML Géréral
            XDocument _generalXML = new XDocument(
                new XElement("Mission",
                    new XElement("NomMission", nomMission),
                    new XElement("DateDebut", dateDebut),
                    new XElement("Duree", maDureeMission),
                    new XElement("Planning", monCheminGeneralXML),
                    new XElement("Map"),
                    new XElement("Home"),
                    new XElement("NbAstronautes", monNbAstronautes),
                    new XElement("Astronautes")));
            ////////////////////////////////////////////////////////////////////////////////
            ////////////////////// Y a pas une erreur ? J'ai modifié
            //_generalXML.Save(_cheminGeneralXML);
            _generalXML.Save(_cheminGeneralXML);

            // Ajout des astronautes dans le XML 
            foreach (string nom in nomsAstronautes)
            {
                _generalXML.Element("Mission").Element("Astronautes").Add(new XElement("Astronaute", nom));
            }
            
            // Création de la liste des activités par défaut d'une journée dans le XML
            #region DefaultDay
            _generalXML.Element("Mission").Add(new XElement("DefaultDay", 
                new XElement("Timetable",
                    new XElement("Activity",
                        new XElement("HeureDeb", "0:00:00"),
                        new XElement("HeureFin", "7:00:00"),
                        new XElement("Nom", "Sleeping"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                    new XElement("Activity",
                        new XElement("HeureDeb", "7:00:00"),
                        new XElement("HeureFin", "8:00:00"),
                        new XElement("Nom", "Eating"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                    new XElement("Activity",
                        new XElement("HeureDeb", "8:00:00"),
                        new XElement("HeureFin", "12:00:00"),
                        new XElement("Nom", "Private"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                    new XElement("Activity",
                        new XElement("HeureDeb", "12:00:00"),
                        new XElement("HeureFin", "14:00:00"),
                        new XElement("Nom", "Eating"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                    new XElement("Activity",
                        new XElement("HeureDeb", "14:00:00"),
                        new XElement("HeureFin", "19:00:00"),
                        new XElement("Nom", "Private"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                    new XElement("Activity",
                        new XElement("HeureDeb", "19:00:00"),
                        new XElement("HeureFin", "21:00:00"),
                        new XElement("Nom", "Eating"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                    new XElement("Activity",
                        new XElement("HeureDeb", "21:00:00"),
                        new XElement("HeureFin", "23:00:00"),
                        new XElement("Nom", "Private"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                    new XElement("Activity",
                        new XElement("HeureDeb", "23:00:00"),
                        new XElement("HeureFin", "24:00:00"),
                        new XElement("Nom", "Sleeping"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")))));
                _generalXML.Save(_cheminGeneralXML);
            #endregion

            // Création du fichier XML Planning pour la mission (depuis la journée par défaut)
            this.creaPlanningXML(_generalXML);
        }
    

        // Création d'une Mission à partir d'un fichier XML
        public Mission (string cheminXMLGeneral)
        {
            // chargement du XML général 
            XDocument _generalXML = XDocument.Load(cheminXMLGeneral);
            monNomMission = _generalXML.Element("Mission").Element("NomMission").Value;
            maDateDebut = DateTime.Parse(_generalXML.Element("Mission").Element("DateDebut").Value);
            maDureeMission = int.Parse(_generalXML.Element("Mission").Element("Duree").Value);
            maDateFin = DateTime.Parse(_generalXML.Element("Mission").Element("DateFin").Value);
            monNbAstronautes = int.Parse(_generalXML.Element("Mission").Element("NbAstronautes").Value);
            mesAstronautes = new List<Astronaute>();
            var astronautes = from astronaute in _generalXML.Descendants("Astronautes") select astronaute;
            foreach (XElement a in astronautes.Elements("Astronaute"))
            {
                string nomAstronaute = a.Value;
                mesAstronautes.Add(new Astronaute(nomAstronaute));
            }

            // MAJ du jour J
            _jourJ = calculJourJ();

            // Récupération du chemin et du nom du fichier XML du Planning
            _cheminPlanningXML = _generalXML.Element("Mission").Element("Planning").Value;
            // Génération du planning associé à la mission
            _planning = new Planning(this);
        }

        #endregion


        #region Méthodes

        // Calcul du jour actuel de la mission (Jour sur Mars) 
        public int calculJourJ()
        {
            TimeSpan ts = DateTime.Now - _dateDebut;
            int jourJ = ts.Minutes / 1480;
            return jourJ;
        }

        // Création du XML Planning (avec que des journées par défaut)
        public void creaPlanningXML(XDocument generalXML)
        {
            // _generalXML.Element("Mission").Element("Astronautes").Add(new XElement("Astronaute", nom));

            XDocument _planningXML = new XDocument(new XElement("Planning"));
            for (int i = 1; i <= _dureeMission; i++)
            {
                XElement x = new XElement("Jour",
                        new XAttribute("id", i),
                        new XElement("CRJour"),
                        new XElement("Activites"));
                _planningXML.Element("Planning").Add(x);

                // Récupération des infos de chaque activité d'une journée par défaut
                var activites = from activite in generalXML.Descendants("Timetable") select activite;
                foreach (XElement a in activites.Elements("Activity"))
                {
                    string heureDebutAct = a.Element("HeureDeb").Value;
                    string heureFinAct = a.Element("HeureFin").Value;
                    string nomAct = a.Element("Nom").Value;
                    string extBoolAct = a.Element("ExtBool").Value;
                    string descriptionAct = a.Element("Description").Value;




                    // Ajout de l'activité par défaut dans le jour que l'on crée dans le planning
                    string iToString = i.ToString();
                    var edt5 = _planningXML.Descendants("Jour").First();
                    var edt = (from jour in _planningXML.Descendants("Jour") where (string)jour.Attribute("id") == iToString select jour.Element("Activites")).FirstOrDefault();
                    edt.Add(new XElement("Activite",
                        new XElement("NomAct", nomAct),
                        new XElement("DebutAct", heureDebutAct),
                        new XElement("FinAct", heureFinAct),
                        new XElement("BoolExt", extBoolAct),
                        new XElement("DescriptionAct", descriptionAct)));
                }
            }
            _planningXML.Save(_cheminPlanningXML);
        }

        // Ajout d'un astronaute à la mission + inscription dans le xml 
        // /!\ Non gestion des doublons (ajout d'un astronaute ayant le même nom qu'un déjà inscrit)
        public void ajoutAstronaute(string nvAstronaute) 
        {
            _astronautes.Add(new Astronaute(nvAstronaute));
            XDocument _generalXML = XDocument.Load(_cheminGeneralXML);
            _generalXML.Element("Mission").Element("Astronautes").Add(new XElement("Astronaute", nvAstronaute));
            int nvNbAstronautes = int.Parse(_generalXML.Element("Mission").Element("NbAstronautes").Value) + 1;
            _generalXML.Element("Mission").SetElementValue("NbAstronautes", nvNbAstronautes);
        }



        #endregion
    }
}

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
        public string _nomMission
        {
            get;
            set;
        }

        public DateTime _dateDebut
        {
            get;
            set;
        }

        public int _dureeMission
        {
            get;
            set;
        }

        public DateTime _dateFin
        {
            get;
            set;
        }

        public int _jourJ
        {
            get;
            set;
        }

        public List<Astronaute> _astronautes
        {
            get;
            set;
        }

        public int _nbAstronautes
        {
            get;
            set;
        }

        public string _cheminGeneralXML
        {
            get;
            set;
        }

        public string _cheminPlanningXML
        {
            get;
            set;
        }

        public Planning _planning
        {
            get;
            set;
        }

        #endregion

        #region constructeurs 


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
                    new XElement("NomMission", _nomMission),
                    new XElement("DateDebut", _dateDebut),
                    new XElement("Duree", _dureeMission),
                    new XElement("Planning", _cheminPlanningXML),
                    new XElement("Map"),
                    new XElement("Home"),
                    new XElement("NbAstronautes", _nbAstronautes),
                    new XElement("Astronautes")));
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
            #region CréationXMLPlanning
            XDocument _planningXML = new XDocument();
            for (int i = 1; i <= _dureeMission; i++ )
            {
                _planningXML.Element("Planning").Add(
                    new XElement("Jour",
                        new XAttribute("id", i),
                        new XElement("CRJour"),
                        new XElement("Activites")));

                // Récupération des infos de chaque activité d'une journée par défaut
                var activites = from activite in _generalXML.Descendants("Timetable") select activite;
                foreach (XElement a in activites.Elements("Activity"))
                {
                    string heureDebutAct = a.Element("HeureDeb").Value;
                    string heureFinAct = a.Element("HeureFin").Value;
                    string nomAct = a.Element("Nom").Value;
                    string extBoolAct = a.Element("ExtBool").Value;
                    string descriptionAct = a.Element("Description").Value;
                    
                    // Ajout de l'activité par défaut dans le jour que l'on crée dans le planning
                    var edt = (from jour in _planningXML.Descendants("Planning") where jour.Attribute("id").Value == i.ToString() select jour.Element("Activites")).FirstOrDefault();
                    edt.Add(new XElement("Activite",
                        new XElement("NomAct", nomAct),
                        new XElement("DebutAct", heureDebutAct),
                        new XElement("FinAct", heureFinAct),
                        new XElement("BoolExt", extBoolAct),
                        new XElement("DescriptionAct", descriptionAct)));   
                }
                
            }
            _planningXML.Save(_cheminPlanningXML);
                #endregion
        }
    

        // Création d'une Mission à partir d'un fichier XML
        public Mission (string cheminXMLGeneral)
        {
            // chargement du XML général 
            XDocument _generalXML = XDocument.Load(cheminXMLGeneral);
            _nomMission = _generalXML.Element("Mission").Element("NomMission").Value;
            _dateDebut = DateTime.Parse(_generalXML.Element("Mission").Element("DateDebut").Value);
            _dureeMission = int.Parse(_generalXML.Element("Mission").Element("Duree").Value);
            _dateFin = DateTime.Parse(_generalXML.Element("Mission").Element("DateFin").Value);
            _nbAstronautes = int.Parse(_generalXML.Element("Mission").Element("NbAstronautes").Value);
            _astronautes = new List<Astronaute>();
            var astronautes = from astronaute in _generalXML.Descendants("Astronautes") select astronaute;
            foreach (XElement a in astronautes.Elements("Astronaute"))
            {
                string nomAstronaute = a.Value;
                _astronautes.Add(new Astronaute(nomAstronaute));
            }

            // MAJ du jour J
            _jourJ = calculJourJ();

            // Récupération du chemin et du nom du fichier XML du Planning
            _cheminPlanningXML = _generalXML.Element("Mission").Element("Planning").Value;
            // Génération du planning associé à la mission
            _planning = new Planning(_cheminPlanningXML);
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

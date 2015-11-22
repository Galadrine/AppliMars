using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppliMartienneTest
{
    class Mission
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
        public Mission (string nomMission, DateTime dateDebut, int dureeMission)
        {
            // Création de l'instance
            _nomMission = nomMission;
            _dateDebut = dateDebut;
            _dureeMission = dureeMission;
            _dateFin = _dateDebut.AddDays(_dureeMission);
            _jourJ = 1;
            _astronautes = new List<Astronaute>();
            _nbAstronautes = 0;

            // Création du fichier XML Géréral
            XDocument _generalXML = new XDocument(
                new XElement("Mission",
                    new XElement("NomMission", _nomMission),
                    new XElement("DateDebut", _dateDebut),
                    new XElement("Duree", _dureeMission),
                    new XElement("Map"),
                    new XElement("Home"),
                    new XElement("NbAstronautes", _nbAstronautes),
                    new XElement("Astronautes")));

            // Il manque l'ajout des astronautes (à partir d'une liste ?) ( cf méthode externe)


            // /!\ Il manque la liste des activités et la journée par défaut

            _generalXML.Save("GeneralXML");

            // Génération du planning par défaut
            // Création des intances 
            // Création du fichier XML Planning
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

            // Génération du planning associé à la mission
            // Récupération du chemin et du nom du fichier XML du Planning
            _cheminPlanningXML = _generalXML.Element("Mission").Element("Planning").Value;
            _planning = new Planning(_dureeMission, _cheminPlanningXML);

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

using System;
using System.Collections.Generic;
using System.IO;
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
        private List<Categorie> _listeCate;
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

        public List<Categorie> maListeCategories
        {
            get { return _listeCate; }
            set { _listeCate = value; }
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

        // Création d'une nouvelle mission (Création nouveaux XML)
        public Mission (string nomMission, DateTime dateDebut, int dureeMission, List<string> nomsAstronautes, string path)
        {
            // Création de l'instance
            monNomMission = nomMission;
            maDateDebut = dateDebut;
            maDureeMission = dureeMission;
            //maDateFin = _dateDebut.AddDays(_dureeMission);
            monJourJ = 1;
            maListeCategories = new List<Categorie>();
            // Création du dossier 
            string emplacementXML = "" + path + nomMission;
            Directory.CreateDirectory(emplacementXML); 
            monCheminPlanningXML = "" + emplacementXML + "/Planning.xml";
            monCheminGeneralXML = "" + emplacementXML + "/General.xml";
            // création des astronautes 
            mesAstronautes = new List<Astronaute>();
            _nbAstronautes = 0;
            foreach (string nom in nomsAstronautes)
            {
                mesAstronautes.Add(new Astronaute(nom));
                monNbAstronautes++;
            }

            // Création du fichier XML Géréral
            XDocument _generalXML = new XDocument(
                new XElement("Mission",
                    new XElement("NomMission", nomMission),
                    new XElement("DateDebut", dateDebut),
                    new XElement("Duree", maDureeMission),
                    new XElement("General", monCheminGeneralXML),
                    new XElement("Planning", monCheminPlanningXML),
                    new XElement("Map"),
                    new XElement("Home"),
                    new XElement("NbAstronautes", monNbAstronautes),
                    new XElement("Astronautes")));
            
            _generalXML.Save(_cheminGeneralXML);

            // Ajout des astronautes dans le XML 
            foreach (string nom in nomsAstronautes)
            {
                _generalXML.Element("Mission").Element("Astronautes").Add(new XElement("Astronaute", nom));
            }

            // Création de la liste des activités (figure2 sujet)
            #region Activites
            _generalXML.Element("Mission").Add(new XElement("Activites",
                new XElement("Categorie",
                    new XAttribute("id", "Living"),
                    new XElement("Activite", "Eating"),
                    new XElement("Activite", "Sleeping"),
                    new XElement("Activite", "Entertrainment"),
                    new XElement("Activite", "Private"),
                    new XElement("Activite", "Health controle"),
                    new XElement("Activite", "Medical act")),
                new XElement("Categorie",
                    new XAttribute("id", "Science"),
                    new XElement("Categorie", 
                        new XAttribute("id", "Exploration"),
                        new XElement("Activite", "Space suit"),
                        new XElement("Activite", "Vehicle")),
                    new XElement("Activite", "Briefind"),
                    new XElement("Activite", "Debriefing"), 
                    new XElement("Activite", "Inside Experiment"),
                    new XElement("Activite", "Outside experiment")),
                new XElement("Categorie",
                    new XAttribute("id", "Maintenance"),
                    new XElement("Activite", "Cleaning"),
                    new XElement("Activite", "LSS air system"),
                    new XElement("Activite", "LSS water system"),
                    new XElement("Activite", "LSS food system"),
                    new XElement("Activite", "Power systems"),
                    new XElement("Activite", "Space suit"),
                    new XElement("Activite", "Other")),
                new XElement("Categorie", 
                    new XAttribute("id", "Communication"),
                    new XElement("Activite", "Sending message"),
                    new XElement("Activite", "Receiving message")),
                new XElement("Categorie",
                    new XAttribute("id", "Repair"),
                    new XElement("Activite", "LSS"),
                    new XElement("Activite", "Power systems"),
                    new XElement("Activite", "Communication systems"),
                    new XElement("Activite", "Habitat"),
                    new XElement("Activite", "Space suit"),
                    new XElement("Activite", "Vehicle")),
                new XElement("Categorie",
                    new XAttribute("id", "Other"),
                    new XElement("Activite", "Emergency"))));
            _generalXML.Save(_cheminGeneralXML);
            #endregion

            // Création des instances des categories
            //var categories = from cate in _generalXML.Descendants("Categorie") select cate;
            foreach (XElement cate in _generalXML.Element("Mission").Element("Activites").Elements("Categorie"))
            {
                string nomNvCate = cate.Attribute("id").ToString();
                List<string> listeActNvCate = new List<string>();
                // Récupération des activités de cette catégorie
                foreach (XElement actCate in cate.Descendants("Activite"))
                {
                    listeActNvCate.Add(actCate.ToString());
                }
                _listeCate.Add(new Categorie(nomNvCate, listeActNvCate));
            }

            // Création de la liste des activités par défaut d'une journée dans le XML

            #region DefaultDay
            _generalXML.Element("Mission").Add(new XElement("DefaultDay", 
                new XElement("Timetable",
                    new XElement("Activity",
                        new XElement("HDebutAct", "00"),
                        new XElement("MDebutAct", "00"),
                        new XElement("HFinAct", "07"),
                        new XElement("MFinAct", "00"),
                        new XElement("Nom", "Sleeping"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                        
                    new XElement("Activity",
                        new XElement("HDebutAct", "07"),
                        new XElement("MDebutAct", "00"),
                        new XElement("HFinAct", "08"),
                        new XElement("MFinAct", "00"),
                        new XElement("HDebutAct", "00"),
                        new XElement("MDebutAct", "00"),
                        new XElement("HFinAct", "07"),
                        new XElement("MFinAct", "00"),
                        new XElement("Nom", "Eating"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),

                        /*
                    new XElement("Activity",
                        new XElement("HDebutAct", "08"),
                        new XElement("MDebutAct", "00"),
                        new XElement("HFinAct", "12"),
                        new XElement("MFinAct", "00"),
                        new XElement("Nom", "Private"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                    new XElement("Activity",
                        new XElement("HDebutAct", "12"),
                        new XElement("MDebutAct", "00"),
                        new XElement("HFinAct", "14"),
                        new XElement("MFinAct", "00"),
                        new XElement("Nom", "Eating"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                    new XElement("Activity",
                        new XElement("HDebutAct", "14"),
                        new XElement("MDebutAct", "00"),
                        new XElement("HFinAct", "19"),
                        new XElement("MFinAct", "00"),
                        new XElement("Nom", "Private"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                    new XElement("Activity",
                        new XElement("HDebutAct", "19"),
                        new XElement("MDebutAct", "00"),
                        new XElement("HFinAct", "21"),
                        new XElement("MFinAct", "00"),
                        new XElement("Nom", "Eating"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                    new XElement("Activity",
                        new XElement("HDebutAct", "21"),
                        new XElement("MDebutAct", "00"),
                        new XElement("HFinAct", "23"),
                        new XElement("MFinAct", "00"),
                        new XElement("Nom", "Private"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")),
                         */
                    new XElement("Activity",
                        new XElement("HDebutAct", "23"),
                        new XElement("MDebutAct", "00"),
                        new XElement("HFinAct", "24"),
                        new XElement("MFinAct", "40"),
                        new XElement("Nom", "Sleeping"),
                        new XElement("Description"),
                        new XElement("ExtBool", "false")))));
                _generalXML.Save(_cheminGeneralXML);
            #endregion

            // Création du fichier XML Planning pour la mission (depuis la journée par défaut)
            this.creaPlanningXML(_generalXML);
            monPlanning = new Planning(this);

        }
    
        // Création d'une Mission à partir d'un fichier XML
        public Mission (string cheminXMLGeneral)
        {
            // chargement du XML général 
            XDocument _generalXML = XDocument.Load(cheminXMLGeneral);
            monNomMission = _generalXML.Element("Mission").Element("NomMission").Value;
            maDateDebut = DateTime.Parse(_generalXML.Element("Mission").Element("DateDebut").Value);
            maDureeMission = int.Parse(_generalXML.Element("Mission").Element("Duree").Value);
            //maDateFin = DateTime.Parse(_generalXML.Element("Mission").Element("DateFin").Value);
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
            monCheminGeneralXML = _generalXML.Element("Mission").Element("General").Value;
            monCheminPlanningXML = _generalXML.Element("Mission").Element("Planning").Value;
            // Génération du planning associé à la mission
            monPlanning = new Planning(this);
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
            int numAct = 0;
            for (int i = 1; i <= _dureeMission; i++)
            {
                XElement x = new XElement("Jour",
                        new XAttribute("id", i),
                        new XElement("CRJour",""),
                        new XElement("Activites"));
                _planningXML.Element("Planning").Add(x);

                // Récupération des infos de chaque activité d'une journée par défaut
                var activites = from activite in generalXML.Descendants("Timetable") select activite;
                foreach (XElement a in activites.Elements("Activity"))
                {
                    string heureDebutAct = a.Element("HDebutAct").Value;
                    string minDebutAct = a.Element("MDebutAct").Value;
                    string heureFinAct = a.Element("HFinAct").Value;
                    string minFinAct = a.Element("MFinAct").Value;
                    string nomAct = a.Element("Nom").Value;
                    string extBoolAct = a.Element("ExtBool").Value;
                    string descriptionAct = a.Element("Description").Value;


                    // Ajout de l'activité par défaut dans le jour que l'on crée dans le planning
                    XElement parts = new XElement("Participants");
                    foreach (XElement astro in generalXML.Element("Mission").Element("Astronautes").Elements("Astronaute"))
                    {
                        parts.Add(astro);
                    }
                    var edt5 = _planningXML.Descendants("Jour").First(); // A QUOI CA SERT CA ?
                    var edt = (from jour in _planningXML.Descendants("Jour") where (string)jour.Attribute("id") == i.ToString() select jour.Element("Activites")).FirstOrDefault();
                    edt.Add(new XElement("Activite",
                        new XAttribute("idAct",numAct+1),
                        new XElement("NomAct", nomAct),
                        new XElement("HDebutAct", heureDebutAct),
                        new XElement("MDebutAct", minDebutAct),
                        new XElement("HFinAct", heureFinAct),
                        new XElement("MFinAct", minFinAct),
                        new XElement("BoolExt", extBoolAct),
                        new XElement("DescriptionAct", descriptionAct),
                        parts));

                    numAct++;
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

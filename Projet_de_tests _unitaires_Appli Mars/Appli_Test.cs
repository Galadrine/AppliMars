using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppliMars;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Appli_Mars_Tests
{
    [TestClass]
    public class Appli_Test
    {
        [TestMethod]
        ///////////////////////////////////// Test Classe Journee ////////////////////////////////

        public void Test_Journee_getPosActiviteByAct()
        {
            DateTime date = new DateTime(2015, 12, 17);
            List<string> participants = new List<string>();
            participants.Add("Moscet");
            Mission Tests = new Mission("Tests",date, 500, participants, "C:\\Users\\cmoscet\\Documents\\GitHub\\AppliMars\\AppliMars\\Missions\\Tests.Planning.xml");
            Journee J = new Journee(1, "Eat,Sleep,Rave,Repeat", Tests);

            J.getPosActiviteByIdAct(1);
        }

        public void Test_Journee_checkJourneeExterieur()
        {
            DateTime date = new DateTime(2015, 12, 17);
            List<string> participants = new List<string>();
            participants.Add("Moscet");
            Mission Tests = new Mission("Tests", date, 500, participants, "C:\\Users\\cmoscet\\Documents\\GitHub\\AppliMars\\AppliMars\\Missions\\Tests.Planning.xml");
            Journee J = new Journee(1, "Eat,Sleep,Rave,Repeat", Tests);

            J.checkJourneeExterieur();
        }

        ////////////////////////////////////// Test Classe Mission ////////////////////////////////

        public void Test_Mission_calculJourJ()
        {
            DateTime date = new DateTime(2015, 12, 17);
            List<string> participants = new List<string>();
            participants.Add("Moscet");
            Mission Tests = new Mission("Tests", date, 500, participants, "C:\\Users\\cmoscet\\Documents\\GitHub\\AppliMars\\AppliMars\\Missions\\Tests.Planning.xml");

            Tests.calculJourJ();
        }

        public void Test_Mission_creaPlanningXML()
        {
            DateTime date = new DateTime(2015, 12, 17);
            List<string> participants = new List<string>();
            participants.Add("Moscet");
            Mission Tests = new Mission("Tests", date, 500, participants, "C:\\Users\\cmoscet\\Documents\\GitHub\\AppliMars\\AppliMars\\Missions\\Tests.Planning.xml");

            //Tests.creaPlanningXML();
        }

        //////////////////////////////////// Test Classe Categorie ////////////////////////////////

        public void Test_Categorie_ajoutSousCategorie()
        {
            Categorie Matin = new Categorie("Matin");
            Categorie Petit_Dejeuner = new Categorie("Petit Dejeuner");

            Matin.ajoutSousCategorie(Petit_Dejeuner);
        }

        ////////////////////////////////////// Test Classe Activite ////////////////////////////////
        public void Test_Activite_initAct()
        {
            Astronaute Moscet = new Astronaute("Moscet");
            Astronaute Barret = new Astronaute("Barret");
            Astronaute Lydie = new Astronaute("Lydie");
            List<Astronaute> participants = new List<Astronaute>();
            participants.Add(Moscet);
            participants.Add(Barret);
            participants.Add(Lydie);
            Activite Act = new Activite("Sleeping", false, "Description", 9, 9, 14, 14, participants);

            Act.initAct("Eating", true, "Description", 9, 9, 14, 14, participants);
        }

        public void Test_Activite_getDetailsActivites()
        {
            Astronaute Moscet = new Astronaute("Moscet");
            Astronaute Barret = new Astronaute("Barret");
            Astronaute Lydie = new Astronaute("Lydie");
            List<Astronaute> participants = new List<Astronaute>();
            participants.Add(Moscet);
            participants.Add(Barret);
            participants.Add(Lydie);
            Activite Act = new Activite("Sleeping", false, "Description", 9, 9, 14, 14, participants);

            Act.getDetailsActivites();
        }

        public void Test_Activite_convertionCoordonneesXML()
        {
            Astronaute Moscet = new Astronaute("Moscet");
            Astronaute Barret = new Astronaute("Barret");
            Astronaute Lydie = new Astronaute("Lydie");
            List<Astronaute> participants = new List<Astronaute>();
            participants.Add(Moscet);
            participants.Add(Barret);
            participants.Add(Lydie);
            Activite Act = new Activite("Sleeping", false, "Description", 9, 9, 14, 14, participants);

            //System.Drawing.Point p = new System.Drawing.Point(x, y);
            //Act.convertionCoordonneesXMLVersImage();
        }




    }
}

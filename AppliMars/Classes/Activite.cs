using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Activite {

    #region variables

    private List<Astronaute> tableauAstronautes;
    private int heuresDebut;
    private int minutesDebut;
    private int heuresFin;
    private int minutesFin;
    private string nom;
    private string description;
    private bool exterieur;
    private System.Drawing.Point position;

    #endregion


    #region accesseurs

    public System.Drawing.Point maPosition {
        get { return position; }
        set { position = value; }
    }


    public bool interieurOuExterieur {
        get { return exterieur; }
        set { exterieur = value; }
    }


    public string maDescription {
        get { return description; }
        set { description = value; }
    }


    public string monNom {
        get { return nom; }
        set { nom = value; }
    }
    
    public List<Astronaute> mesAstronautes {
        get { return tableauAstronautes; }
        set { tableauAstronautes = value; }
    }

    public int mesMinutesFin {
        get { return minutesFin; }
        set { minutesFin = value; }
    }


    public int monHeuresFin {
        get { return heuresFin; }
        set { heuresFin = value; }
    }


    public int mesMinutesDebut {
        get { return minutesDebut; }
        set { minutesDebut = value; }
    }


    public int monHeureDebut {
        get { return heuresDebut; }
        set { heuresDebut = value; }
    }
    

    #endregion


    #region constructeurs

    public Activite(string unNom, bool boolExt, string uneDesc, int HDebut, int MDebut, int HFin, int MFin)
	{

    }

    #endregion


    #region methodes

    public System.Drawing.Point convertionCoordonneesXMLVersImage(int posX, int posY) {
        return new System.Drawing.Point((posX / 3) - 700, (posY / 3) - 1000);
    }

    #endregion


}


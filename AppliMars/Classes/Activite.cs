using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Activite {

    #region variables
    
    public static int _nbActTotal;

    public int _idAct;
    private List<Astronaute> _participants;
    private int _heuresDebut;
    private int _minutesDebut;
    private int _heuresFin;
    private int _minutesFin;
    private string _nom;
    private string _description;
    private bool _exterieur;
    private int _posX, _posY;

    #endregion


    #region accesseurs

    public System.Drawing.Point maPosition {
        get { return _position; }
        set { _position = value; }
    }


    public bool interieurOuExterieur {
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
        get { return _tableauAstronautes; }
        set { _tableauAstronautes = value; }
    }

    public int mesMinutesFin {
        get { return _minutesFin; }
        set { _minutesFin = value; }
    }


    public int monHeuresFin {
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
    public Activite(string unNom, bool boolExt, string uneDesc, int HDebut, int MDebut, int HFin, int MFin, List<Astronaute> participants,  int posX, int posY)
    {
        this.initAct(unNom, boolExt, uneDesc, HDebut, MDebut, HFin, MFin, participants);
        _posX = posX;
        _posY = posY;
        _idAct = _nbActTotal + 1;
        _nbActTotal++;
        
    }
    public Activite(string unNom, bool boolExt, string uneDesc, int HDebut, int MDebut, int HFin, int MFin, List<Astronaute> participants)
        : this(unNom, boolExt, uneDesc, HDebut, MDebut, HFin, MFin, participants, 0, 0) { }

    // Création d'une nouvelle instance d'activité au chargement du XML (avec ID prédéfini)
    public Activite(string unNom, bool boolExt, string uneDesc, int HDebut, int MDebut, int HFin, int MFin, List<Astronaute> participants,  int posX, int posY, int idAct)
    {
        this.initAct(unNom, boolExt, uneDesc, HDebut, MDebut, HFin, MFin, participants);
        _posX = posX;
        _posY = posY;
        _idAct = idAct;
    }
    public Activite(string unNom, bool boolExt, string uneDesc, int HDebut, int MDebut, int HFin, int MFin, List<Astronaute> participants, int idAct) 
        : this(unNom, boolExt, uneDesc, HDebut, MDebut, HFin, MFin, participants, 0, 0, idAct){}


    #endregion


    #region methodes

    public void initAct(string unNom, bool boolExt, string uneDesc, int HDebut, int MDebut, int HFin, int MFin, List<Astronaute> participants)
    {
        _nom = unNom;
        _exterieur = boolExt;
        _description = uneDesc;
        _heuresDebut = HDebut;
        _minutesDebut = MDebut;
        _heuresFin = HFin;
        _minutesFin = MFin;
        _participants = new List<Astronaute>();
        _participants = participants;
    }

    public System.Drawing.Point convertionCoordonneesXMLVersImage(int posX, int posY) {
        return new System.Drawing.Point((posX / 3) - 700, (posY / 3) - 1000);
    }

    #endregion


}


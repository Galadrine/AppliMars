﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSMon {
    CSBase _base;
    int level;

    public CSMon(CSBase csBase, int csLevel) {
        _base = csBase;
        level = csLevel;

    }

    public int Attack {
        get {return Mathf.FloorToInt((_base.Attack * level) / 100f) + 5;}
    }

    public string MaxHp {
        get {return     Mathf.FloorToInt((_base.Speed * level) / 100f) + 10;}
    }

    public string SpAttack {
        get {return Mathf.FloorToInt((_base.SpAttack * level) / 100f) + 5;}
    }

    public string Defense {
        get {return Mathf.FloorToInt((_base.Defense * level) / 100f) + 5;}
    }

    public string SpDefense {
        get {return Mathf.FloorToInt((_base.SpAttack * level) / 100f) + 5;}
    }

    public string Speed {
        get {return Mathf.FloorToInt((_base.Speed * level) / 100f) + 5;}
    }
}
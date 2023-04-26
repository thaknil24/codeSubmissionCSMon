using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Pokemon", menuName = "CSMON/Create new CSmon")]
public class CSBase : ScriptableObject {

    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite sprite;

    [SerializeField] CSType type;

    //cs stats
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    public string Name {
        get {return name;}
    }

    public string Description {
        get {return description;}
    }

    public Sprite Sprite {
        get {return sprite;}
    }

    public CSType Type {
        get {return type;}
    }

    public int MaxHp {
        get {return maxHp;}
    }

    public int Attack {
        get {return attack;}
    }

    public int SpAttack {
        get {return spAttack;}
    }

    public int Defense {
        get {return defense;}
    }

    public int SpDefense {
        get {return spDefense;}
    }

    public int Speed {
        get {return speed;}
    }
}

public enum CSType {
    Water,
    Fire,
    Grass,
    Rock
}


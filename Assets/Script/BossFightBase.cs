using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Boss", menuName = "Boss/Create new Boss")]
public class BossFightBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;


    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;
    [SerializeField] BossType type1;
    [SerializeField] BossType type2;

    // Base Stats
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int speed;

    public string Name {
        get { return name; }
    }

    public string Description {
        get {return description; }
    }

}

public enum BossType
{
    None,
    Normal,
    Sword, 
    Fighting, 
    Ground,
    Pyshics,  
    Grass, 
    Rock
}

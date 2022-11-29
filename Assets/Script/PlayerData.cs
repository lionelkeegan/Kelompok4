using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class PlayerData
{
    public float Health;
    public int level;

    //public static namePlayer playerName;
    //public TMP_Text namePlayer;

    public float[] position;
    
    public PlayerData(Player player)
    {
        level = player.level;
        Health = player.Health;

        //namePlayer = player.namePlayer;

        position = new float[2];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
    }
}

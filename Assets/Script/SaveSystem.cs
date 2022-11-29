using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//public static class SaveSystem
//public class SaveSystem : using UnityEngine;

public static class SaveSystem
{
    public static void SavePlayer(Player player)
    //public static void SavePlayer()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        //BinaryFormatter bf = new BinaryFormatter();
        //FileStream file = File.Create(Application.dataPath + "/playerInfo2.txt");
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);
        //PlayerData pData = new PlayerData();
        //Debug.Log(data.Health);
        //Debug.Log(data.level);
        //Debug.Log(data.position[0]);
        //Debug.Log(data.position[1]);

        //pData.Healths = health;
        //pData.Levels = level;
        //pData.Positions = position;

        //bf.Serialize(file,pData);
        //file.Close();

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in "+ path);
            return null;
        }
    }
    //public void Load()
    //{
        //if (File.Exists(Application.dataPath + "/playerInfo2.dat"))
        //{
            //BinaryFormatter bf = new BinaryFormatter();
            //FileStream file = File.Open(Application.dataPath + "/playerInfo2.txt", FileMode.Open);
            //PlayerData dataa = (PlayerData)bf.Deserialize(file);
            //file.Close();
 
            //position = dataa.Positions;
            //level = dataa.Levels;
            //healths = dataa.Health;
       // }
    //}
}

//[System.Serializable]
//public class PlayerData
//{
    //public float Health;
    //public List<bool> Levels = new List<bool>();
    //public static namePlayer playerName;
    //public TMP_Text namePlayer;
    //public float[] position;
//}

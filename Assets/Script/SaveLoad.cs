using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    public InputField[] playerName;
    public Text[] LoadName;

    public void ButtonSave()
    {
        for (int i = 0; i < playerName.Length ; i++)
        {
            PlayerPrefs.SetString("PlayerName" + i, playerName[i].text);
        }
    }

    public void ButtonLoad()
    {
        for (int i = 0; i < LoadName.Length ; i++)
        {
            LoadName[i].text = PlayerPrefs.GetString("PlayerName" + i, "-");
        }
    }
}

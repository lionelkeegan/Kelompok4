using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Player : MonoBehaviour
{
    public CinemachineVirtualCamera Vcam;
    public GameObject[] PlayerPrefabs;
    int characterIndex;

    private void Awake()
    {
        string name = CharacterSelect.username;
        int index = CharacterSelect.selectedIndex;
        characterIndex = PlayerPrefs.GetInt(name);
        GameObject player =  Instantiate(PlayerPrefabs[characterIndex], Vector2.zero , Quaternion.identity);
        Vcam.Follow = player.transform;
    }
}
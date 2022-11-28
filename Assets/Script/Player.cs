using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] Image avatar;
    [SerializeField] TMP_Text username;
    [SerializeField] Image healthBar;
    public CinemachineVirtualCamera Vcam;
    public GameObject[] PlayerPrefabs;
    int characterIndex;

    private void Awake()
    {
        string name = CharacterSelect.username;
        int index = CharacterSelect.selectedIndex;
        avatar.sprite = CharacterSelect.avatar;
        username.text = name;
        characterIndex = PlayerPrefs.GetInt(name);
        GameObject player =  Instantiate(PlayerPrefabs[characterIndex], Vector2.zero , Quaternion.identity);
        Vcam.Follow = player.transform;
    }
}
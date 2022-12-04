using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Cinemachine;
using System;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField] Image avatarCharacter;
    [SerializeField] Sprite[] character;
    [SerializeField] TMP_InputField usernameInput;
    public static int selectedIndex = 0;
    public static string username;
    public static Sprite avatar;

    private void Start()
    {
        avatarCharacter.sprite = character[selectedIndex];
    }

    // shifting index milih ke kiri atau kanan dari Sprite[]
    public void shiftSelectedIndex(int shift)
    {
        selectedIndex += shift;

        while (selectedIndex >= character.Length)
        {
            selectedIndex -= character.Length;
        }

        while (selectedIndex < 0)
        {
            selectedIndex += character.Length;
        }
        avatarCharacter.sprite = character[selectedIndex];
    }

    public void SaveSelectedIndex()
    {
        //simpan di local storage
        avatar = character[selectedIndex];
        username = usernameInput.text;
        PlayerPrefs.SetInt(username, selectedIndex);
        SceneManager.LoadScene("MapGame");
    }
}
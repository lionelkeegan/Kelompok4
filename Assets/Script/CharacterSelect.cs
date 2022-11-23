using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField] Image avatarImage;
    [SerializeField] Sprite[] avatarSprites;
    [SerializeField] TMP_InputField usernameInput;
    [SerializeField] string nama;
    private int selectedIndex = 0;
    string username;
    private void Start()
    
    {
        avatarImage.sprite = avatarSprites[selectedIndex];
        // SaveSelectedIndex();
    }

    // shifting index milih ke kiri atau kanan dari Sprite[]
    public void shiftSelectedIndex(int shift)
    {
        selectedIndex += shift;

        while (selectedIndex >= avatarSprites.Length)
        {
            selectedIndex -= avatarSprites.Length;
        }

        while (selectedIndex < 0)
        {
            selectedIndex += avatarSprites.Length;
        }

        avatarImage.sprite = avatarSprites[selectedIndex];

        // SaveSelectedIndex();
    }

    public void SaveSelectedIndex()
    {
        //simpan di local storage
        username = usernameInput.text;
        PlayerPrefs.SetInt(username, selectedIndex);
        Debug.Log("Name: " + username + ", avatar: " + PlayerPrefs.GetInt(username));
    }
}
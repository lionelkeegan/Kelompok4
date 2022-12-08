using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    public GameObject WarningPanel;
    public AudioSource objectSound; 


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            WarningPanel.SetActive(true);
            objectSound.Play();
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            WarningPanel.SetActive(false);
        }
    }

    public void LoadToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

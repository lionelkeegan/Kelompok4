using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public GameObject WarningPanel;
    public GameObject CanvasPlayer;
    GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            WarningPanel.SetActive(true);
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
        GameObject.DontDestroyOnLoad(CanvasPlayer);
        player.transform.position = new Vector3(-4.5f, -0.5f, 0);
        GameObject.DontDestroyOnLoad(player);
    }
}
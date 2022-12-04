using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    GameObject PlayerScale;
    Vector3 Bigscale, Minscale;
    private void Awake()
    {
        PlayerScale = GameObject.FindGameObjectWithTag("Player");
        Bigscale = new Vector3(5f, 5f, 5f);
        Minscale = new Vector3(3f, 3f, 3f);
    }

    public void ChangeBigScale()
    {
        PlayerScale.transform.localScale = Bigscale;
    }

    public void ChangeMinScale()
    {
        this.transform.localScale = Minscale;
    }
}

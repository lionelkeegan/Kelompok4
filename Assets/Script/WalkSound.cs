using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSound : MonoBehaviour
{
   public AudioSource walkSound;

   void Update()
   {
        if(Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.S)))))
        {
            walkSound.enabled = true;
        }
        else
        {
            walkSound.enabled = false;
        }
   }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DetectCrash : MonoBehaviour
{   void OnTriggerEnter2D(Collider2D other) 
   {
       if(other.tag == "ground")
       {
           SceneManager.LoadScene(0);
       }
   }
}

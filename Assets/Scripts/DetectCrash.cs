using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DetectCrash : MonoBehaviour

{  
    [SerializeField] float fltloadDelay = 0.5f;
     void OnTriggerEnter2D(Collider2D other) 
   {
       if(other.tag == "ground")
       {
           Invoke("ReloadScene", fltloadDelay);
       }
     
   }
     void ReloadScene()
       {
           SceneManager.LoadScene(0);
       }
    }




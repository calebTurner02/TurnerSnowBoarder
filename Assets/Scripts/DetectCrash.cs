using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DetectCrash : MonoBehaviour

{  
    [SerializeField] float fltloadDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    
     void OnTriggerEnter2D(Collider2D other) 
   {
       if(other.tag == "ground")
       {
           FindObjectOfType<PlayerController>().DisableControls();
           crashEffect.Play();
           GetComponent<AudioSource>().PlayOneShot(crashSFX);
           Invoke("ReloadScene", fltloadDelay);
       }
     
   }
     void ReloadScene()
       {
           SceneManager.LoadScene(1);
       }
    }




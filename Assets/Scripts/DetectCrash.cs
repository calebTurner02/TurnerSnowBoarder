using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCrash : MonoBehaviour
{   void OnTriggerEnter2D(Collider2D other) 
   {
       if(other.tag == "ground")
       {
           Debug.Log("You hit your head!");
       }
   }
}

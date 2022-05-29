using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido_p : MonoBehaviour
 {
        public AudioSource audioSource;
  

   private void OnTriggerEnter2D(Collider2D other) {
      if (other.tag == "Player" && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
   }
    private void OnTriggerExit2D(Collider2D other) {
      if (other.tag == "Player" && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
   }

    }

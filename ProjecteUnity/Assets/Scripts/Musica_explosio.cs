using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica_explosio : MonoBehaviour
{
      public AudioClip sonidoexplosion1;
    public AudioSource controlexplosion1;

  void musica (){
      controlexplosion1.clip = sonidoexplosion1;
      controlexplosion1.maxDistance = 100;
  
}
}

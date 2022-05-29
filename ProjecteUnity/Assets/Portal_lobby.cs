using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal_lobby : MonoBehaviour
{
   public string Lobby;
 
  public void OnTriggerEnter2D(Collider2D other)
  {
      SceneManager.LoadScene(Lobby);

  }
}

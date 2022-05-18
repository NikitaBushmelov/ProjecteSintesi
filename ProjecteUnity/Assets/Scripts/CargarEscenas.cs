using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CargarEscenas : MonoBehaviour
{
    // Start is called before the first frame update
    
    
     public void CargarJuego()
    {
        
        SceneManager.LoadScene("Lobby");
    
    }

     public void Menu()
    {
        
        SceneManager.LoadScene("Menu");
    }
     public void Exit()
    {
        Application.Quit();
    }
   
}

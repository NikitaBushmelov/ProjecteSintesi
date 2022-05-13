using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class FullScreen : MonoBehaviour
{
    public Toggle toggle;



    void Start()
    {
        if (Screen.fullScreen)
        {
           toggle.isOn =true;
        }else{
            toggle.isOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void ActivarPantallaComleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }
}

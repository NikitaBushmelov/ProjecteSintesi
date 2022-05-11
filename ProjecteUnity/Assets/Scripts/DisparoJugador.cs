using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisparoJugador : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;

    public Text AttackSpeed;
    [SerializeField] private float tiempoEntreDisparos;


    private float tiempoSiguienteDisparo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= tiempoSiguienteDisparo)
        {
            Disparar();
            tiempoSiguienteDisparo = Time.time + tiempoEntreDisparos;
        }
        aaSpeedText();
    }
    void aaSpeedText() {
        AttackSpeed.text = "" + tiempoEntreDisparos;
    }
    private void Disparar ()
    {
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
    }
}

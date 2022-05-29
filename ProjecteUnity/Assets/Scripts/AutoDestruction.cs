using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("des",1.0f);
    }
    void des(){
        Destroy(gameObject);

    }
}

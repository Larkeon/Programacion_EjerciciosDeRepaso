using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float veneno;
    float vida = 120f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        veneno += 0.03f;
        vida = vida - (vida * veneno);
        Debug.Log("Vida " + vida);
    }
}

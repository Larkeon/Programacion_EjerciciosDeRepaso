using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oro = 7, oroObtenido;
    int tiempo = 3600 * 4;

    // Start is called before the first frame update
    void Start()
    {
        tiempo += 1;
        oroObtenido = tiempo * oro;
        Debug.Log("Oro obtenido " + oroObtenido);

    }

    // Update is called once per frame
    void Update()
    {      
        
    }
}

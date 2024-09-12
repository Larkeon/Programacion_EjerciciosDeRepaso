using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 20;
    float exp = 2.5f;
    float productoVE, cocienteVE, restoVE, dobleV, tripleE;
    // Start is called before the first frame update
    void Start()
    {
        productoVE = vidas * exp;
        cocienteVE = vidas / exp;
        restoVE = vidas % exp;
        dobleV = vidas * 2;
        tripleE = exp * 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

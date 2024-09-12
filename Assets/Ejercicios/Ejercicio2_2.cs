using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 100;
    float exp = 38f;
    char carac = ' ';
    float resultadoSuma;
    float resultadoResta;

    // Start is called before the first frame update
    void Start()
    {
        resultadoSuma = vidas + exp;
        resultadoResta = exp - vidas;
        Debug.Log("ResultaSuma es " + resultadoSuma + " y ResultadoResta es " + resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

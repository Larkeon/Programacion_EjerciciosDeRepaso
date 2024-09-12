using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 37;
    int puntuacion2 = 28;
    int puntuacion3 = 2;
    int puntuacionM;
    // Start is called before the first frame update
    void Start()
    {
        puntuacionM = (puntuacion1 + puntuacion2 + puntuacion3) / 3;
        Debug.Log("Puntuacion1 es " + puntuacion1);
        Debug.Log("Puntuacion2 es " + puntuacion2);
        Debug.Log("Puntuacion3 es " + puntuacion3);
        Debug.Log("La puntuacion media de las tres es " + puntuacionM);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

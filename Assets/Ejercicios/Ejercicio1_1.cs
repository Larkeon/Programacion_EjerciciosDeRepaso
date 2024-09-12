using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    string nombreUsuario = "Ibai";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola Mundo!" + " Este es el primer videojuego de " + nombreUsuario + ". Estoy aprendiendo C#.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame.");
        /*Esta ultima frase aparece cada vez que pasa un frame.
        */
    }
}

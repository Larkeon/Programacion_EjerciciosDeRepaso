using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] int velocidadKmH;
    int velocidadMS;
    // Start is called before the first frame update
    void Start()
    {
        velocidadMS = velocidadKmH * 3600 / 1000;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("La velocidad en m/s es " +  velocidadMS);
    }
}

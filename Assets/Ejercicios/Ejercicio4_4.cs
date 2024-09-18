using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    [SerializeField] float kmH;
    // Start is called before the first frame update
    void Start()
    {
        Velocidad(kmH);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Velocidad(float kmH)
    {
        float mS = kmH * 1000 / 3600;
        Debug.Log(kmH + " Km/h son " + mS + " m/s");
        return kmH;
    }
}

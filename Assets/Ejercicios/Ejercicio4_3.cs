using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    float conversi�n = 1.11f;
    [SerializeField] float cantidad;
    [SerializeField] string moneda;

    // Start is called before the first frame update
    void Start()
    {
        Convertir(cantidad, moneda);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Convertir(float cantidad, string moneda)
    {
        float euros = cantidad * 1 / conversi�n;
        Debug.Log(cantidad + " dolares son " + euros + " euros.");
        float dolares = cantidad * conversi�n;
        Debug.Log(cantidad + " euros son " + dolares + " dolares.");
        return dolares;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float pi = 3.14f;
    float longitudCirc, areaCirc;
    // Start is called before the first frame update
    void Start()
    {
        longitudCirc = 2 * pi * radio;
        areaCirc = pi * Mathf.Pow(radio,2);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Longitud circunferencia " + longitudCirc + ", Area circunferencia " + areaCirc);
    }
}

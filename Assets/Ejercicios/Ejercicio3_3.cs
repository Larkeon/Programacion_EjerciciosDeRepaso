using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero = 2;
    int numeroDoble, numeroTriple;
    // Start is called before the first frame update
    void Start()
    {
        numeroDoble = numero * 2;
        numeroTriple = numero * 3;
        Debug.Log("El numero " + numero + ", su doble es " + numeroDoble + " y su triple es " + numeroTriple);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

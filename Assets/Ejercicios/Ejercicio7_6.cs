using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        while (numero >= -numero)
        {
            Debug.Log("El numero es " + numero);
            numero--;
        
        }
        for (numero = numero; numero != -numero; numero--)
        {
            Debug.Log("El numero es " + numero);
        
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;
    int numInicial = 1;
    // Start is called before the first frame update
    void Start()
    {
        while(numInicial <= numero)
        {
            Debug.Log("El numero es " + numInicial);
            numInicial++; 
            
        }
        for(int numInicial = 1; numInicial <= numero; numInicial++)
        {
            Debug.Log("El numero es " + numInicial);
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

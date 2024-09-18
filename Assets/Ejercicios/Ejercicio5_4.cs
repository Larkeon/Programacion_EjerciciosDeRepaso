using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    int cociente;
    // Start is called before the first frame update
    void Start()
    {
        cociente = numero1/numero2;
        if(cociente != 0)
        {
            Debug.Log("EL resultado es " + cociente);
        }
        else
        {
            Debug.Log("EL resultado es 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

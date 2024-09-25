using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    int num = 100;
    // Start is called before the first frame update
    void Start()
    {
        while(num > 0)
        {
            Debug.Log("El numero es " + num);
            num--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

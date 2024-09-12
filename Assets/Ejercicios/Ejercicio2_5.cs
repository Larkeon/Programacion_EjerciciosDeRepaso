using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1I = 40;
    int vidasPlayer1;
    int vidasPlayer2I = 10;
    int vidasPlayer2;
    int vidasPlayer3I = 100;
    int vidasPlayer3;
    int vidasPlayer4I = 75 ;
    int vidasPlayer4;

    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2 = vidasPlayer3I;
        vidasPlayer3 = vidasPlayer1I;
        vidasPlayer1 = vidasPlayer4I;
        vidasPlayer4 = vidasPlayer2I;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

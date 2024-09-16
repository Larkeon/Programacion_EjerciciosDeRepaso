using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] int basee;
    [SerializeField] int altura;
    [SerializeField] int lado;
    [SerializeField] float radio;
    // Start is called before the first frame update
    void Start()
    {
        AreaCirculo(radio);
        AreaCuadrado(lado);
        AreaTriangulo(basee, altura);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AreaCirculo(float radio)
    {
        float areaCirculo = radio / 2 * 3.14f;
        Debug.Log("Area del circulo " + areaCirculo);
    }

    void AreaTriangulo(int basee, int altura)
    {
        int areaTriangulo = basee * altura / 2;
        Debug.Log("Area del triangulo " + areaTriangulo);
    }

    void AreaCuadrado(int lado)
    {
        int areaCuadrado = lado * lado;
        Debug.Log("Area del cuadrado " + areaCuadrado);

    }
}

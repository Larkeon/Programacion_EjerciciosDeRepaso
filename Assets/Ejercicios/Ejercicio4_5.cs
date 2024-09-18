using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    float conversión = 1.11f;
    [SerializeField] string moneda;
    [SerializeField] int altura;
    [SerializeField] int lado;
    // Start is called before the first frame update
    void Start()
    {
        Convertir(AreaCuadrado(lado), moneda);
        Convertir(AreaCirculo(lado), moneda);
        Convertir(AreaTriangulo(lado, altura), moneda);
    }

    // Update is called once per frame
    void Update()
    {

    }

    float AreaCirculo(float lado)
    {
        float areaCirculo = lado / 2 * 3.14f;
        Debug.Log("Area del circulo " + areaCirculo);
        return areaCirculo; 
    }

    float AreaTriangulo(int lado, int altura)
    {
        int areaTriangulo = lado * altura / 2;
        Debug.Log("Area del triangulo " + areaTriangulo);
        return areaTriangulo;
    }

    float AreaCuadrado(int lado)
    {
        int areaCuadrado = lado * lado;
        Debug.Log("Area del cuadrado " + areaCuadrado);
        return areaCuadrado;

    }

    float Convertir(float cantidad, string moneda)
    {
        float euros = cantidad * 1 / conversión;
        Debug.Log(cantidad + " dolares son " + euros + " euros.");
        float dolares = cantidad * conversión;
        Debug.Log(cantidad + " euros son " + dolares + " dolares.");
        return dolares;

    }
}

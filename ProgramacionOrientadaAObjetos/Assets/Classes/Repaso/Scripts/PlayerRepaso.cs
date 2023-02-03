using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRepaso : MonoBehaviour
{
    private int num1;
    private int num2;
    private int num3;


    void Start()
    {
        num1 = 7;
        num2 = 7;
        num3 = 7;
        int este = Resta(num1, num2);

    }

    void Update()
    {
        
    }

    int Suma(int numero1, int numero2, int numero3)
    {

        int result = num1 + num2 + num3;
        return result;

    }

    int Resta(int numero1, int numero2, int numero3)
    {

        int result = num1 - num2 - num3;
        return result;

    }

    int Resta(int numero1, int numero2)
    {

        int result = num1 - num2;
        return result;

    }

    float Resta(float numero1, float numero2)
    {

        float result = num1 - num2;
        return result;

    }
}

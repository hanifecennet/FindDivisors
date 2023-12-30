//Hanife Cennet Alkan - 30.12.23 - Odev2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondHomework : MonoBehaviour
{
    [SerializeField] int firstNumber = 2;
    [SerializeField] int secondNumber = 100;
    string result = "";
    void FindDivisors(int x, int y)
    {   
        for(int i = 1; i <= 5; i++)
        {
            result = i + "'e tam bolunen sayilar : ";
            for(int j = firstNumber; j <= secondNumber; j++)
            {
                if(j % i == 0)
                {
                    result += " # " +j.ToString();
                }
            }
        }
        Debug.Log(result);
    }
    void Start()
    {
        FindDivisors(firstNumber, secondNumber);
    }
}

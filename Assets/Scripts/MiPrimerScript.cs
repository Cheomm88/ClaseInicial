using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{

    //Variables
    // El TIpo de Dato       Nombre
    int numeroDeSaltos = 0;

    public int primerLogroSaltos = 5;
    public int segundoLogroSaltos = 10;
    public int tecerLogroSaltos = 15;

    
    private void OnCollisionEnter(Collision infoChoque)
    {
        numeroDeSaltos = numeroDeSaltos + 1;


        if (numeroDeSaltos == primerLogroSaltos || numeroDeSaltos == segundoLogroSaltos || numeroDeSaltos == tecerLogroSaltos)
        {
            Debug.Log(gameObject.name + " ha chocado " + numeroDeSaltos + " veces");

        }
    }
}

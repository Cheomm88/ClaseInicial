using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{

    public Vector3 speedRotation;
    // Update is called once per frame
    void Update()
    {
       // Rotar la moneda
        transform.Rotate(speedRotation * Time.deltaTime, Space.World);
    }
}

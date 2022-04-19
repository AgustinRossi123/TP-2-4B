using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayorDeEdad : MonoBehaviour
{
    public int edad;
    public Text mitexto;
    // Start is called before the first frame update
    void Start()
    {
        if (edad >= 18)
        {
            mitexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }
        else if(edad <= 18)
        {
            mitexto.text = "No es mayor de edad";
            Debug.Log("Es menor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

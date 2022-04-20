using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validar_contraseña : MonoBehaviour
{
    string contraseniacorrecta;
    string contraseniausuario;
    public Text ingresousuario;

    // Start is called before the first frame update
    void Start()
    {
        contraseniacorrecta = "12345";    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidarContrasenia()
    {
        contraseniausuario = ingresousuario.text;
        if (contraseniausuario==contraseniacorrecta)
        {
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }
}

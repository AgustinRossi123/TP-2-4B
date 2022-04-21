using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validar_contraseña : MonoBehaviour
{
    string contraseniacorrecta;
    string contraseniausuario;
    public Text ingresousuario;
    public Text textoMsj;
    public GameObject cartelitoMsj;

    // Start is called before the first frame update
    void Start()
    {
        contraseniacorrecta = "12345";
        cartelitoMsj.SetActive(false);
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
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}

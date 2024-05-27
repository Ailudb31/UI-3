using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public string contraseña;
    public Text txtBienvenido;
    public InputField inputContra;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Verificacion()
    {
        if (contraseña == inputContra.text)
        {
            Debug.Log("Acess granted");
        }
        else
        {
            Debug.Log("Acess denied");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrindoporta : MonoBehaviour
{
    int porta;

    void start()
	{
        porta = 0;
        classeporta pta = new classeporta();
        classeporta.Porta = porta;
    }

    public void abrirporta()
    {
        transform.localPosition = new Vector3(22, 5, 12);
    }
    public void fecharporta()
    {
        transform.localPosition = new Vector3(22, -4, 12);
    }
    void Update()
    {


        if (Input.GetKey(KeyCode.Mouse0))
        {
            porta += 1;
            
        }
        else
        {
            porta = 0;
        }
        if (porta > 0)
        {
            
            abrirporta();
        }
		else
		{
            fecharporta();
        }
    }
}
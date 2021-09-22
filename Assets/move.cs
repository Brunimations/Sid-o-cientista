using UnityEngine;
using System.Collections;
//Classe move.
public class move : MonoBehaviour
{
    float _velocidadeFrente;
    float _velocidadeTras;
    float _velocidadeGirar;
    //Metodo Start e executado uma unica vez, quando o script e executado.
    void Start()
    {
        _velocidadeFrente = 30;
        _velocidadeTras = 15;
        _velocidadeGirar = 180;
    }

    //Medodo Update e executado a cada Frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, (_velocidadeFrente * Time.deltaTime));
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, (-_velocidadeTras * Time.deltaTime));
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(0, (-_velocidadeGirar * Time.deltaTime), 0);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(0, (_velocidadeGirar * Time.deltaTime), 0);
        }
    }
}
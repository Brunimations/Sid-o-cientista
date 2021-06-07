using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    void Update()
    {

            transform.localScale = new Vector3(Random.Range(0.2f, 5.0f), 1, Random.Range(0.2f, 5.0f));
  
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrindoporta : MonoBehaviour
{
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
			abrirporta();
		}
		else
		{
			fecharporta();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapete : MonoBehaviour
    {
	private Color m_oldColor = Color.red;
	void OnTriggerEnter(Collider other)
	{
		Renderer render = GetComponent<Renderer>();

		m_oldColor = render.material.color;
		render.material.color = Color.blue;
	}
	void OnTriggerExit(Collider other)
	{
		Renderer render = GetComponent<Renderer>();
		render.material.color = m_oldColor;
	}
}

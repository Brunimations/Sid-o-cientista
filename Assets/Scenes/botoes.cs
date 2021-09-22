using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botoes : MonoBehaviour
{
	public void jogar()
	{
		SceneManager.LoadScene(1);

	}
	public void sair()
	{
		Application.Quit();
	}
}

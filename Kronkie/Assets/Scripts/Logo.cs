using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logo : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WaitAndChange());
    }

    IEnumerator WaitAndChange()
    {
        yield return new WaitForSeconds(8);
    }

	public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene (name);
	}
}
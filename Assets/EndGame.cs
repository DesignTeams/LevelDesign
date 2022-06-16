using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    private void Awake()
    {
        StartCoroutine(CloseGame());
    }

    IEnumerator CloseGame()
    {
        yield return new WaitForSeconds(2);
        Application.Quit();
    }
}

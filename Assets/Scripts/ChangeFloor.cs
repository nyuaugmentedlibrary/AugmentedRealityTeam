using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeFloor : MonoBehaviour
{
    public void GoToFloor3()
    {
        SceneManager.LoadScene("3rdFloor");
    }

    public void GoToFloor4()
    {
        SceneManager.LoadScene("4thFloor");
    }
}

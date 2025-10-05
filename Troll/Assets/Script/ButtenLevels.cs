using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtenLevels : MonoBehaviour
{
    public string nameScene;

    public void OnClick()
    {
        SceneManager.LoadScene(nameScene);
    }
}

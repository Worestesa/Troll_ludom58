using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClikcCounter : MonoBehaviour
{
    public int clickNumbers;
    public string nameScene;
    public TMP_Text numbersText;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            clickNumbers++;
            numbersText.text = $"Кликнуто около:{clickNumbers}";
            if (clickNumbers >= 10)
            {
                SceneManager.LoadScene(nameScene);
            }
        }
    }
}

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
    [SerializeField] private GameObject UIbes;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.gameObject.TryGetComponent(out Button _))
        {
            clickNumbers++;
            
            numbersText.text = $"Кликнуто около:{clickNumbers} из 10";
            if (clickNumbers >= 10)
            {
                SceneManager.LoadScene(nameScene);
            }
        }
    }
}

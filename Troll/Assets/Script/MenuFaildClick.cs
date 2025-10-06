using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuFaildClick : MonoBehaviour
{
    [SerializeField] private GameObject UIoff;
    [SerializeField] private GameObject UIon;

    public void OnPointerClick(PointerEventData eventData)
    {
        UIoff.SetActive(false);
        UIon.SetActive(true);
    }
}

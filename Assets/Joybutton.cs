using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joybutton : MonoBehaviour,IPointerUpHandler,IPointerDownHandler
{
    [HideInInspector]
    public bool presi;
    public void OnPointerDown(PointerEventData eventData)
    {
        presi = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        presi = false;
    }
}

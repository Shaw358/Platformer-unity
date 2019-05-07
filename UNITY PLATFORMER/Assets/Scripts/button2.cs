using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class button2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject textMesh;
    // Start is called before the first frame update


    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");
        textMesh.GetComponent<script>().selector = 2;

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        textMesh.GetComponent<script>().selector = 0;
    }

}

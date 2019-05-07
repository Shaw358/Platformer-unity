using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class location : MonoBehaviour
{
    float time = 4;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("back", time);
    }

    void back()
    {
        GetComponent<TextMeshPro>().text = "";
    }
}

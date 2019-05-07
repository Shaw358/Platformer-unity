using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    public GameObject myButton;
    public bool disabled;
    // Start is called before the first frame update
    void Start()
    {
        disabled = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (disabled == true)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        if (disabled == false)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }

    }
}
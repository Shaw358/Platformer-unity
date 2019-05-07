using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightsAlarm : MonoBehaviour
{

    Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    // Update is called once per frame
    IEnumerator Flashing ()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.65f);
            light.enabled = !light.enabled;
        }
    }
}

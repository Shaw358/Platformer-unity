using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    public GameObject viper;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        viper.GetComponent<box>().chip = true;
    }
}

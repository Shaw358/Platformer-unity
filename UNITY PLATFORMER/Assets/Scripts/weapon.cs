using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public bool right;
    public Transform firepointR;

    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Oh well");
            Shoot();
        }

    }

    void Shoot()
    {
            Instantiate(bulletPrefab, firepointR.position, firepointR.rotation);
    }
}

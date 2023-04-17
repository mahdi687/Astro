using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSwitcher : MonoBehaviour
{
    public GameObject Grapple;
    public GameObject scan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) )
        {
            Grapple.SetActive(false);
            scan.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            Grapple.SetActive(true);
            scan.SetActive(false);
        }
    }
}

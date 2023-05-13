using LidarProject;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSwitcher : MonoBehaviour
{
    public GameObject sn;
    public GameObject Grapple;
    public GameObject scan;
    public bool ISscanning=false;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) )
        {
            ISscanning=true;
            sn.SetActive(true);
            Grapple.SetActive(false);
            scan.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            sn.SetActive(false);
            Grapple.SetActive(true);
            scan.SetActive(false);
        }
    }
}

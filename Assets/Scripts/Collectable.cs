using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Collectable : MonoBehaviour
{

    public GameObject TEXT;

    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 15f))
        {
            Debug.Log("wow");
            print("hit!!");
            if (Input.GetKeyDown(KeyCode.Mouse0) )
            {

                StartCoroutine(delay());
            }


        }
        else
        {

            TEXT.SetActive(false);
        }
        


    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(.5f);
        TEXT.SetActive(true);
    }
    

}
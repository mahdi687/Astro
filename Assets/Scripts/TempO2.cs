using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TempO2 : MonoBehaviour
{
    public bool v;
    public Slider temp;
    public float deg;

    public Slider O2;
    public bool o;

    public Slider Hp; 



    // Update is called once per frame
    void Update()
    {
        if (v)
        {
            temp.value += deg ;
        }
        else
        {
            temp.value -= deg ;
        }

        if (!o)
        {
            O2.value -= 0.01f; 

        }
        else
        {
            O2.value += deg ;
        }
        if (( temp.value == temp.maxValue ) || ( O2.value == O2.minValue )) 
        {
            Hp.value -= 0.1f; 
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("temp")) 
        { 
          v = true;
        }
       
    }
    public void OnCollisionExit(Collision other)
    {

        if (other.collider.CompareTag("temp"))
        {
            v = false;
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("O2"))
        {
            o = true;
        }
        if (other.CompareTag("health"))
        {
            Hp.value += 20f;
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("O2"))
        {
            o = false;
        }
    }

}

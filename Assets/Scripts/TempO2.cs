using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; 

public class TempO2 : MonoBehaviour
{
    public bool v;
    public Slider temp;
    public int valtemp;
    public int valO2;
    public float deg;

    public Slider O2;
    public bool o;

    public Slider Hp;
    public Text temptxt;
    public Text O2txt;



    // Update is called once per frame
    void Update()
    {
        if (v)
        {
            temp.value += deg ;
            valtemp= Convert.ToInt32(temp.value) + 37;
            temptxt.text = valtemp.ToString() + "°";
            
        }
        else
        {
            temp.value -= deg ;
            valtemp = Convert.ToInt32(temp.value)+37;
            temptxt.text = valtemp.ToString() + "°";
        }

        if (!o)
        {
            O2.value -= 0.01f;
            valO2 = Convert.ToInt32(O2.value) ;
            O2txt.text = valO2.ToString()+"%";
        }
        else
        {
            O2.value += 0.01f;
            valO2 = Convert.ToInt32(O2.value);
            O2txt.text = valO2.ToString() + "%";
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

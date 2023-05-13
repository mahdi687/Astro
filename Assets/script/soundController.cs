using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundController : MonoBehaviour
{
    
    public Slider sound;
   
    
    public void changevolume()
    {

        AudioListener.volume = sound.value;
    }
}

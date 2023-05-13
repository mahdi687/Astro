using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject settings;
    public void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape))
        {
            settings.SetActive(false);
        }
    }
    public void opensettings()
    {
        settings.SetActive(true);
    }

}

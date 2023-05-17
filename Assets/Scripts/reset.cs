using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    bool fail=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(fail)
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            SceneManager.LoadScene("TUTO");
        }
    }
}

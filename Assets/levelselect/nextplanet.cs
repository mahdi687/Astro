using System.Collections;
using System.Collections.Generic;
using Packages.Rider.Editor.UnitTesting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextplanet : MonoBehaviour
{
    public AudioSource TP;
    public bool test = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TP.Play();
            test = true;
            StartCoroutine(delay());
        }

    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(4);
        if (test)
        {
            SceneManager.LoadScene("Movement_Test");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LandingToLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(delay());
    }

    IEnumerator delay() 
    {
        yield return new WaitForSeconds(18);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}

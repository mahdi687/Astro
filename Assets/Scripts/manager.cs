using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(delay());
    }

    // Update is called once per frame
    

    IEnumerator delay()
    {
        yield return new WaitForSeconds(23);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}

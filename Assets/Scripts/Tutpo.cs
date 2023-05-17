using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutpo : MonoBehaviour
{
    public GameObject welcome;
    public GameObject walk;
    public GameObject climb;
    public GameObject scan;
    public GameObject jump;
    public GameObject wallRun;
    public GameObject slide;
    public GameObject grapplle;
    public GameObject hot;
    public GameObject oxy;
    public GameObject health;
    public GameObject end;

  

    private void OnTriggerEnter(Collider other)
    {
       if(other.tag=="Climb")
        {
            welcome.SetActive(false);
            walk.SetActive(false);
            climb.SetActive(true);
        }
        if (other.tag == "Scan")
        {
            climb.SetActive(false);
            scan.SetActive(true);
        }
        if (other.tag == "Jump")
        {
            scan.SetActive(false);
            jump.SetActive(true);
        }
        if (other.tag == "WAll")
        {
            jump.SetActive(false);
            wallRun.SetActive(true);
        }
        if (other.tag == "Slide")
        {
            wallRun.SetActive(false);
            slide.SetActive(true);
        }
        if (other.tag == "Grapple")
        {
            slide.SetActive(false);
            grapplle.SetActive(true);
        }
        if (other.tag == "Hot")
        {
            grapplle.SetActive(false);
            hot.SetActive(true);
        }
        if (other.tag == "Oxy")
        {
            hot.SetActive(false);
            oxy.SetActive(true);
        }

        if (other.tag == "Health")
        {
            oxy.SetActive(false);
            health.SetActive(true);
        }
        if (other.tag == "health")
        {
            health.SetActive(false);
            end.SetActive(true);
            StartCoroutine(delay());
        }

    }

    IEnumerator delay()
    {
        
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    


}

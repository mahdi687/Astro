using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskManager : MonoBehaviour
{
    public int total = 0;
    public int plantOne = 0;
    public int plantTwo = 0;
    public int crystalOne = 0;
    public int powerCellOne = 0;
    public int boneOne = 0;
    public int beaconOne = 0;
    public int waterOne = 0;
    public GameObject plant1;
    public GameObject plant2;
    public GameObject crystal;
    public GameObject beacon;
    public GameObject powerCell;
    public GameObject bone;
    public GameObject Water;

    public GameObject WaterTask;
    public GameObject itemTask;

    public GameObject GameEnded;
    

    // Update is called once per frame
    void Update()
    {
        if (plant1.activeSelf) 
        {
            plantOne = 1;
        }
        if (plant2.activeSelf)
        {
            plantTwo = 1;
        }
        if (crystal.activeSelf)
        {
            crystalOne = 1;
        }
        if (beacon.activeSelf)
        {
            beaconOne = 1;
        }
        if (bone.activeSelf)
        {
            boneOne = 1;
        }
        if (powerCell.activeSelf)
        {
            powerCellOne = 1;
        }

        total = plantOne + plantTwo + crystalOne + beaconOne + boneOne + powerCellOne;
        
        if (total == 6)
        {
            WaterTask.SetActive(true);
            itemTask.SetActive(false);
        }
        if (Water.activeSelf)
        {
            waterOne = 1;
        }
        total += waterOne;

        if (total==7 && !Water.activeSelf) 
        {
            StartCoroutine(delay());
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(4);
        GameEnded.SetActive(true);
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

using UnityEngine;

public class RotateGun : MonoBehaviour
{

    public PlayerMovementAdvanced pm;
    public SwingingDone grappling; 

    private Quaternion desiredRotation;
    private float rotationSpeed = 5f;

    void Update()
    {
        if (!pm.swinging)
        {
            desiredRotation = transform.parent.rotation;
        }
        else
        {
            desiredRotation = Quaternion.LookRotation(grappling.predictionPoint.position - transform.position);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, Time.deltaTime * rotationSpeed);
    }

}
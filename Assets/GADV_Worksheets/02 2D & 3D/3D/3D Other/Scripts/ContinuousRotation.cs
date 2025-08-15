using UnityEngine;

public class ContinuousRotation : MonoBehaviour
{
    // Rotation speed for each axis (degrees per second)
    public Vector3 rotationSpeed = new Vector3(30f, 45f, 60f);

    void Update()
    {
        // Rotate the object by rotationSpeed * deltaTime
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}

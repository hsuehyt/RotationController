using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [System.Serializable]
    public class RotationSettings
    {
        public GameObject objectToRotate; // The 3D GameObject to rotate
        public Vector3 rotationDirection; // The direction of rotation (x, y, z axes)
        public float rotationSpeed; // The speed of rotation
    }

    public List<RotationSettings> objectsToRotate = new List<RotationSettings>();

    // Update is called once per frame
    void Update()
    {
        foreach (var rotationSettings in objectsToRotate)
        {
            if (rotationSettings.objectToRotate != null)
            {
                // Rotate the object based on the specified direction and speed
                rotationSettings.objectToRotate.transform.Rotate(rotationSettings.rotationDirection * rotationSettings.rotationSpeed * Time.deltaTime);
            }
        }
    }
}

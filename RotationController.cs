using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [System.Serializable]
    public class RotationSettings
    {
        public GameObject objectToRotate; // The 3D GameObject to rotate
        public float rotationSpeed; // The speed of rotation
        [HideInInspector]
        public Vector3 rotationDirection; // The direction of rotation (automatically set)
    }

    public List<RotationSettings> objectsToRotate = new List<RotationSettings>();

    private void Start()
    {
        SetRotationDirections();
    }

    // Automatically set rotation directions based on the number of objects
    void SetRotationDirections()
    {
        int numberOfObjects = objectsToRotate.Count; // Use the number of objects in the list
        float angleStep = 360f / numberOfObjects; // Calculate angle between each object's direction

        for (int i = 0; i < objectsToRotate.Count; i++)
        {
            float angleInRadians = Mathf.Deg2Rad * angleStep * i; // Convert to radians for trigonometric functions
            float x = Mathf.Cos(angleInRadians); // Calculate x component
            float y = Mathf.Sin(angleInRadians); // Calculate y component
            float z = Mathf.Cos(angleInRadians * 0.5f); // Example: z component based on a different angle ratio

            objectsToRotate[i].rotationDirection = new Vector3(x, y, z).normalized; // Normalize to keep consistent speed
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var rotationSettings in objectsToRotate)
        {
            if (rotationSettings.objectToRotate != null)
            {
                // Rotate the object based on the automatically assigned direction and user-defined speed
                rotationSettings.objectToRotate.transform.Rotate(rotationSettings.rotationDirection * rotationSettings.rotationSpeed * Time.deltaTime);
            }
        }
    }
}

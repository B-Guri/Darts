using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartShoot : MonoBehaviour
{
    [SerializeField] private GameObject dartObject;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float tForce = 12f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 direction = new Vector3(0f, transform.localEulerAngles.y + 90f, cameraTransform.localEulerAngles.x);
            GameObject newDart = Instantiate(dartObject, transform.position, Quaternion.Euler(direction));
            newDart.GetComponent<Rigidbody>().AddForce(newDart.transform.TransformDirection(Vector3.left) * tForce, ForceMode.Impulse);
        }
    }
}

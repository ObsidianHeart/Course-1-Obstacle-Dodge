using System.Threading;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropTimer = 5; // Time in seconds before the object drops

    MeshRenderer meshRenderer;
    Rigidbody rb;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false; // Hide the object initially

        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // Disable gravity initially
    }
    void Update()
    {
        if (Time.time > dropTimer)
        {
            meshRenderer.enabled = true; // Show the object
            rb.useGravity = true; // Enable gravity to drop the object
        }
    }
}

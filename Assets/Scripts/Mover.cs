using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float Xvalue = 0.0f;
    [SerializeField] float Yvalue = 1.0f;
    [SerializeField] float Zvalue = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(Xvalue, Yvalue, Zvalue);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Xvalue * Time.deltaTime, Yvalue * Time.deltaTime, Zvalue * Time.deltaTime);
    }
}

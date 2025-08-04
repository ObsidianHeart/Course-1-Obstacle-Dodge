using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float speed = 5.0f ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Xvalue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float Yvalue = 0;
        float Zvalue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Xvalue, Yvalue , Zvalue);
    }
}

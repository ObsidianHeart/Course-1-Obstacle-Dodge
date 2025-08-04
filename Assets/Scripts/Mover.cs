using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game !");
        Debug.Log("Use WASD or Arrow keys to move the object.");
    }

    void MovePlayer()
    {
        float Xvalue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float Yvalue = 0;
        float Zvalue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Xvalue, Yvalue, Zvalue);

    }

}
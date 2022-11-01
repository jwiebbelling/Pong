using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;
    public float speed = 0.5f;
    public float maxY;
    public float minY;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveUp) && maxY > transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
        if (Input.GetKey(moveDown) && minY < transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
        }
    }
}


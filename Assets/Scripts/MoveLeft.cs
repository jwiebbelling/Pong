using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public float speed = 0.01f;
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

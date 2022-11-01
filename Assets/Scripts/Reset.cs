using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        name = collision.gameObject.name;
        if (name == "TriggerLeft" || name == "TriggerRight")
        {
            transform.position = new Vector2(0, 0);

        }
    }
}

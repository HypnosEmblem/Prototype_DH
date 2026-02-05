using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDuckMovement : MonoBehaviour
    
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("HorizontalMovement", 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y > 6)
        {
            //Destroy(this.gameObject);
        }
    }
    void HorizontalMovement()
    {
        int direction = Random.Range(1, 2);
        switch (direction)
        {
            case 1:
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                break;
            case 2:
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                break;
        }
    }
}

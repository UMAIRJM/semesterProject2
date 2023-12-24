using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hurdleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 0.02f;
    public float moveSpeed2 = 0.02f;
    public float moveSpeed3 = 0.02f;
    public GameObject checkPoint;
    public GameObject saw;
    void Start()
    {
        checkPoint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.myScore == fruitsGenerator.fruitCounter) {
            checkPoint.SetActive(true);
        }
        Vector2 position = transform.position;
        
        if (position.y >= 3.62f) {

            moveSpeed = -0.02f;
        }
        else if (position.y <= -1.8f) {
            moveSpeed = 0.02f;    
        }
        transform.Translate(0, moveSpeed, 0);
        Vector2 position2 = saw.transform.position;
        if (position2.x <= 1.75f)
        {
            moveSpeed2 = 0.02f;

        }
        if (position2.x >= 4.97f) {
            moveSpeed2 = -0.02f;
        }
        saw.transform.Translate(moveSpeed2, 0, 0);
        Vector2 position3 = checkPoint.transform.position;
        if (position3.y>=3.82f) {
            moveSpeed3 = -0.02f;
        }
        if (position3.y <= -2.33f) {
            moveSpeed3 = 0.02f;
        }
        checkPoint.transform.Translate(0, moveSpeed3, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fruitsGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] fruits;
    public static int fruitCounter;
    public Text target;

    void Start()
    {
        fruitGenerator(3.91f, -10.8f, -6.83f, 4);
        fruitGenerator(3.91f, -3.45f, 8.05f,8);
        fruitGenerator(0.73f, 6.46f, 8.42f, 3);
        fruitGenerator(0.73f, -2.68f, -2.4f, 2);
        fruitGenerator(-1.88f, -10.49f, -8f, 4);
        fruitGenerator(-1.88f, -2f, -0.5f, 4);
        fruitGenerator(0.82f, -10.1f, -7.18f, 3);
        print(fruitCounter);
        target.text = "You have to collect " + fruitCounter.ToString() + "fruits to complete this level";
        
        
    }


    public void fruitGenerator(float yLocation, float xStarting, float xEnding,int count) {
        if (count < 4)
        {

            for (int i = 0; i < count; i++)
            {
                fruitCounter++;
                float x = Random.Range(xStarting, xEnding);
                Vector2 position = new Vector2(x, yLocation);
                Instantiate(fruits[i], position, Quaternion.identity);
            }
        }
        else {
            int index;
            for (int i = 0; i < count; i++)
            {
                fruitCounter++;
                index = i;
                float x = Random.Range(xStarting, xEnding);
                Vector2 position = new Vector2(x, yLocation);
                if (i > 2) {
                    index = Random.Range(0, 2);
                    
                }
                Instantiate(fruits[index], position, Quaternion.identity);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
}

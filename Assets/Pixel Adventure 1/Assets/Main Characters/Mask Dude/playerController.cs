using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class playerController : MonoBehaviour
{   
    Animator anim;
    public static int myScore = 0;
    public Text myScoreText;
    void Start()
    {
        myScoreText.text = "Score: " + myScore.ToString(); 
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {


        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(0.05f, 0, 0);
            anim.SetBool("isWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)) {
            anim.SetBool("isWalking", false);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            transform.localScale = new Vector3(5f, 4f, 5f);
            
        }
        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            transform.localScale = new Vector3(4f, 4f, 4f);
                    }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.rotation = Quaternion.Euler(0, 180f, 0);
            transform.Translate(0.05f, 0, 0);
            anim.SetBool("isWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow)) {
            anim.SetBool("isWalking", false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            anim.SetBool("isJumping", true);
            transform.Translate(Vector2.up * 50 * Time.fixedDeltaTime);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            anim.SetBool("isJumping", false);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            anim.SetBool("isJumping", true);
            //transform.Translate(0, 3f, 0);
            transform.Translate(Vector2.up * 80 * Time.fixedDeltaTime);
        }
        if (Input.GetKeyUp(KeyCode.Space)) {
            anim.SetBool("isJumping", false);
        }
        

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("apple") || collision.gameObject.name.StartsWith("banana") || collision.gameObject.name.StartsWith("strawberry")) {
            myScore++;
            myScoreText.text = "Score: " + myScore.ToString();
            Destroy(collision.gameObject);
            print(myScore);
        }
        if (collision.gameObject.name.StartsWith("checkPoint")) {
            SceneManager.LoadScene("level2");
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("firsthurdle")|| collision.gameObject.name.StartsWith("saw")) {
            Destroy(transform.gameObject);
            SceneManager.LoadScene("GameOverScene");
        
        }

    }
}

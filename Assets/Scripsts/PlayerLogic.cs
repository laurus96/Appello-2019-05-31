using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLogic : MonoBehaviour
{
    public int score = 0;
    public Text textScore;


    // Update is called once per frame
    void LateUpdate()
    {
        if(score >= 10)
        {
            StartCoroutine(waitWin());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monetina"))
        {
            score++;
            textScore.text = "Score: " + score;
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Muro"))
        {
            StartCoroutine(waitOver());
        }
    }

    IEnumerator waitOver()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("GameOver");

    }

    IEnumerator waitWin()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Win");

    }
}

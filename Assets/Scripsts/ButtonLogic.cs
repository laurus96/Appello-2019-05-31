using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonLogic : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    public Sprite imageRed;


    public void restart()
    {
        StartCoroutine(wait());
    }

    public void changeColorEnter()
    {
        buttonText.GetComponent<Text>().color = Color.red;
    }

    public void changeColorExit()
    {
        buttonText.GetComponent<Text>().color = Color.white;
    }

    public void changeImage()
    {
        button.image.sprite = imageRed;
        changeColorToBlue();
    }

    private void changeColorToBlue()
    {
        buttonText.GetComponent<Text>().color = Color.blue;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Gioco");
    }

}

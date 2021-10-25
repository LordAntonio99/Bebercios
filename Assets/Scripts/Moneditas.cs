using UnityEngine;
using UnityEngine.SceneManagement;

public class Moneditas : MonoBehaviour
{
    public Animator animacionesBoton;
    public GameObject replayButton;
    public GameObject boton;
    public GameObject cara;
    public GameObject cruz;

    public void Clicked()
    {
        animacionesBoton.SetBool("isClicked", true);
        int numero = Random.Range(0,9);
        Debug.Log(numero);

        if (numero % 2 == 0)
        {
            Debug.Log("cara");
            cara.gameObject.SetActive(true);
            replayButton.SetActive(true);
        }
        else
        {
            Debug.Log("cruz");
            cruz.gameObject.SetActive(true);
            replayButton.SetActive(true);
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

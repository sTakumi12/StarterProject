using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    public Text winText;
    public GameManagerScript gameManager;
    [SerializeField] private AudioSource tickingSoundEffect;
    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        winText.text = "";
        tickingSoundEffect.Play();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString ("0");

        if (currentTime <=0)
        {
            currentTime = 0;
            winText.text = "You Win!";
            gameManager.winScreen();
            tickingSoundEffect.Stop();
            
        }
    }
}

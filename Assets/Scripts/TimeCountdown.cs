using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeCountdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 15f;
    [SerializeField] Text countdownText;
    
    public GameObject gameoverui;
    public static bool gameispaused;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }
    public void Newgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        gameispaused = false;
    }
    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString();
        
    }
    public void FixedUpdate()
    {
        if (currentTime <= 0)
        {
            gameoverui.SetActive(true);
            gameispaused = true;
        }
    }
}

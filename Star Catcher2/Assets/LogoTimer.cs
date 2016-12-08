using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogoTimer : MonoBehaviour
{
    float timeAmount = 5;
    float time;
    public Timer timeText;

    void Start()
    {
        time = timeAmount;
    }

    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
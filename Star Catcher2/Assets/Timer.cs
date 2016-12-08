using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timeAmount = 115;
    float time;
    public Text timeText;

    void Start()
    {
        time = timeAmount;
    }

    void Update()
    {
        time -= Time.deltaTime;
        timeText.text = "Time: " + time.ToString("F");
        if (time <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StarCollection : MonoBehaviour {

    private int count = 0;
    public Text countText;

	void Start ()
    {
        SetCountText();
	}

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
           other.gameObject.SetActive(false);
           count = count + 1;
        }
        else if (other.gameObject.CompareTag("Drop"))
        {
            count = count - 1;
            if (count < 0)
            {
                SceneManager.LoadScene(3);
            }
        }

        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
}

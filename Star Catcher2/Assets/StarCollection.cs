using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarCollection : MonoBehaviour {

    private int count;
    public Text countText;
	
	void Start () {
        count = 0;
        SetCountText();
	}
	
	
	void Update () {
	
	}

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
           other.gameObject.SetActive(false);
           count = count + 1;
           SetCountText();
        }

        if (other.gameObject.CompareTag("Drop"))
        {
            count = count - 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
}

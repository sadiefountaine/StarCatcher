using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StarCollection : MonoBehaviour {

    private int count = 0;
    public Text countText;

    /*public Image damageImage;
    public float flashSpeed = 5;
    public Color flashColor = new Color(1, 0, 0, 0.1f);

    bool damaged;*/

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
            
            //Play Sound
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }
        else if (other.gameObject.CompareTag("Drop"))
        {
            /*if (damaged)
            {
                damageImage.color = flashColor;
            }

            else
            {
                damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
            }
            damaged = false;*/

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

    /*public void TakeDamage(int amount)
    {
        damaged = true;
    }*/
}

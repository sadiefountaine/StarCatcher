using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Button StartText;
    public Button ExitText;

	
	void Start ()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        StartText = StartText.GetComponent<Button>();
        ExitText = ExitText.GetComponent<Button>();
        quitMenu.enabled = false;
	}
	public void ExitPress()
    {
        quitMenu.enabled = true;
        StartText.enabled = false;
        ExitText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        StartText.enabled = true;
        ExitText.enabled = true;
    }

	public void StartLevel ()
    {
        SceneManager.LoadScene (2);
    }

    
    public void ExitGame ()
    {
        Application.Quit();
    }
	
}

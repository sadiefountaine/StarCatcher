using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Button StartText;
    public Button ExitText;
    public Button MainMenuText;

	
	void Start ()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        StartText = StartText.GetComponent<Button>();
        ExitText = ExitText.GetComponent<Button>();
        MainMenuText = MainMenuText.GetComponent<Button>();
        quitMenu.enabled = false;
	}
	public void ExitPress()
    {
        quitMenu.enabled = true;
        StartText.enabled = false;
        ExitText.enabled = false;
        MainMenuText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        StartText.enabled = true;
        ExitText.enabled = true;
        MainMenuText.enabled = true;
    }

	public void StartLevel ()
    {
        SceneManager.LoadScene (2);
    }

    public void ExitGame ()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
	
}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CancelPanel;
    public GameObject CancelButton;
    public AudioSource audio;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audio.Play();
        }
    }

    public void CancelButtonClick()
    {
        Time.timeScale = 0;
        CancelPanel.SetActive(true);
        CancelButton.SetActive(false);
    }

    public void CancelPanelNoButton()
    {
        Time.timeScale = 1;
        CancelPanel.SetActive(false);
        CancelButton.SetActive(true);
    }

    public void CancelPanelYesButton()
    {
        Application.Quit();
    }
}

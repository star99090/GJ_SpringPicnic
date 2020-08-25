using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject CancelPanel;
    public GameObject CancelButton;
    public AudioSource audioSource;
    public Text ButtonText1;
    public Text ButtonText2;

    Color originColor = new Color(0.34f, 0.24f, 0.24f, 1f);

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
        }
        if(SceneManager.GetActiveScene().name == "EndingCredit")
        {
            CancelButton.SetActive(false);
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

    public void ButtonChange()
    {
        ButtonText1.color = Color.white;
    }

    public void ButtonReturn()
    {
        ButtonText1.color = originColor;
    }

    public void ButtonChange2()
    {
        ButtonText2.color = Color.white;
    }

    public void ButtonReturn2()
    {
        ButtonText2.color = originColor;
    }
}

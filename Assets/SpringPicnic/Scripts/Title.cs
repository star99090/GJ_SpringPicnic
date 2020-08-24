using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject CancleButton;
    public Text ButtonText;
    public Text SkipTip;
    
    Color originColor = new Color(0.34f, 0.24f, 0.24f, 1f);

    private void Start()
    {
        Invoke("Starting", 2f);
    }

    public void Starting()
    {
        StartButton.SetActive(true);
        CancleButton.SetActive(true);
        SkipTip.text = " 대화 스킵 : ESC";
    }

    public void LScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonChange()
    {
        ButtonText.color = Color.white;
    }

    public void ButtonReturn()
    {
        ButtonText.color = originColor;
    }
}

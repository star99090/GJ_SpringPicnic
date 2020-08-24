using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject StartButton;
    public Text ButtonText;
    public Text Skip;

    float timer = 0f;
    bool isStart = false;
    Color originColor = new Color(0.34f, 0.24f, 0.24f, 1f);
    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 2f && !isStart)
        {
            Starting();
        }
    }

    public void Starting()
    {
        StartButton.SetActive(true);
        Skip.text = " 대화 스킵 : ESC";
        isStart = true;
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

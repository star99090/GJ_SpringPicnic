using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    public Text ButtonText;
    Color originColor = new Color(87f, 61f, 61f, 255f);
    
    public void ButtonChange()
    {
        ButtonText.color = Color.white;
    }

    public void ButtonReturn()
    {
        ButtonText.color = originColor;
    }
}

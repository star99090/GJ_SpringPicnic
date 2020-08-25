using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingCredit : MonoBehaviour
{
    Vector3 move = new Vector3(0f, 0.03f, 0f);

    void Update()
    {
        if (this.transform.position.y >= -26f)
        {
            this.transform.position -= move;
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}

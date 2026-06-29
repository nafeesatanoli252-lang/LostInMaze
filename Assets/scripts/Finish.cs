using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("YOU WIN!");

            Time.timeScale = 0f; // Game stop
        }
    }

    private void OnGUI()
    {
        if (Time.timeScale == 0f)
        {
            GUIStyle style = new GUIStyle();
            style.fontSize = 40;
            style.normal.textColor = Color.green;

            GUI.Label(new Rect(Screen.width / 2 - 100,
                               Screen.height / 2 - 25,
                               200, 50),
                               "YOU WIN!", style);
        }
    }
}
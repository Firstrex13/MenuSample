using UnityEngine;

public class Menu : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
            Pause();
    }
    private void Pause()
    {
        gameObject.SetActive(true);
    }
}

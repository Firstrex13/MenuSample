using UnityEngine;

public class StarterGame : MonoBehaviour
{
    [SerializeField] private Menu _menu;

    public void StartGame()
    {
        _menu.gameObject.SetActive(false);
    }
}

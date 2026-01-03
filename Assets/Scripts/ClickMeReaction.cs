using UnityEngine;

public class ClickMeReaction : MonoBehaviour
{
    [SerializeField]
    private Renderer rend;
    [SerializeField]
    private Material mat;
    private void OnEnable()
    {
        EventManager.ClickedThing += EventManagerClicked;
        EventManager.ReleasedThing += EventManagerReleased;
    }
    private void OnDisable()
    {
        EventManager.ClickedThing -= EventManagerClicked;
        EventManager.ReleasedThing -= EventManagerReleased;

    }
    void Start()
    {
        rend = GetComponent<Renderer>();
        mat = rend.material;
    }

    private void EventManagerClicked()
    {
        Debug.Log("Clicked");
        mat.color = Color.magenta;

    }
    private void EventManagerReleased()
    {
        Debug.Log("Released");
        mat.color = Color.blue;
    }
}
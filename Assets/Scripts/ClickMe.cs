using UnityEngine;
using UnityEngine.EventSystems;


public class ClickMe : MonoBehaviour,
    IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler

{
    [SerializeField]
    private Renderer rend;
    [SerializeField]
    private Material mat;

    void Start()
    {
        rend = GetComponent<Renderer>();
        mat = rend.material;
        Debug.Log("Script Started");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Mouse Down");
        mat.color = Color.green;
        EventManager.OnClickedThing();
        SoundManager.Instance.PlaySound("pop2", 0.5f, false, null);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Mouse Up");
        mat.color = Color.white;
        EventManager.OnReleasedThing();
    }

    public void OnPointerEnter(PointerEventData eventData)

    {
        Debug.Log("Mouse Enter");
    }

    public void OnPointerExit(PointerEventData eventData)

    {
        Debug.Log("Mouse Exit");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Mouse Clicked");
    }
}

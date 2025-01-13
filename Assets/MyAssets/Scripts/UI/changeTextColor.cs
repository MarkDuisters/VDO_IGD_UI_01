using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class changeTextColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] TMP_Text text;

    void Start()
    {
        text.color = Color.green;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ChangeColor(Color.red);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ChangeColor(Color.green);
    }

    void ChangeColor(Color col)
    {
        text.color = col;
    }

}

using UnityEngine;
using UnityEngine.EventSystems;


public class GrowOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float scaleMultiplier = 1.2f;
    public float shrinkMultipler = 0.8f;

    private Vector3 originalScale;

    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData) // cursor hovering over button make it grow
    {
        transform.localScale = originalScale * scaleMultiplier;
        Debug.Log("Touched");
    }

    public void OnPointerExit(PointerEventData eventData) // cursor hovering over button make it grow
    {
        transform.localScale = originalScale;
    }
}

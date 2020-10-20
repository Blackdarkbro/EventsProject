using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour, IPointerClickHandler, IDragHandler,
    IPointerEnterHandler, IPointerExitHandler, IEndDragHandler, IDropHandler
{
    [SerializeField] Transform playerInventory;
    [SerializeField] Image defaultImg;
    [SerializeField] Image shipImg;

    private Vector2 cellPosition;
    private Vector3 originCellPosition;
    

    private void Start() {
        originCellPosition = transform.TransformVector(transform.position);
        Debug.Log(transform.position);

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnDrop(PointerEventData eventData)
    {
        transform.DOMove(originCellPosition, .5f);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(Vector2.one * 1.05f, 0.3f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
         transform.DOScale(Vector2.one, 0.3f);
    }
}

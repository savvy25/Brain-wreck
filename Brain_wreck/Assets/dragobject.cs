using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class dragobject : MonoBehaviour, IDragHandler {

           public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;

    }


}

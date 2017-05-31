using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DropZone : MonoBehaviour,IDropHandler {
    
    private static int level = 0;
    public void OnDrop(PointerEventData eventData)
    {
        DragZone d = eventData.pointerDrag.GetComponent<DragZone>();
        if (d != null)
        {
            Debug.Log("On Drop to" + gameObject.name);

            d.parentToReturnTo = this.transform;

            level = level + 1;

        }

        if (level == 2)
        {
           
    
        SceneManager.LoadScene(19);
    
        }

    }

	
}

using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class dropzoneequation: MonoBehaviour, IDropHandler
{

    private int level = 0;
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

            level = 0;
            SceneManager.LoadScene(19);

        }

    }


}


using UnityEngine;
using System.Collections;

public class quit_game : MonoBehaviour {

	public void quit()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }
}

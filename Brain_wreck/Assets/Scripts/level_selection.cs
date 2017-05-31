using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class level_selection : MonoBehaviour {

	public void level_selection_loader(int screen_index)
    {

        SceneManager.LoadScene(screen_index);

    }
}

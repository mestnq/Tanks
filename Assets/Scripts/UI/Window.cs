using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public abstract class Window : MonoBehaviour
    {
        private GameObject currentWindow;
    
        public void OpenWindow(GameObject windowPrefab)
        {
            currentWindow = Instantiate(windowPrefab);
            CloseWindow(currentWindow);
        }

        private void CloseWindow(GameObject windowPrefab)
        {
            Destroy(currentWindow);
        }
        
        // todo: потом перенести в другое место
        #region SceneManagement

        public void OpenScene(int sceneBuildIndex)
        {
            SceneManager.LoadScene(sceneBuildIndex);
        }

        #endregion
    }
}

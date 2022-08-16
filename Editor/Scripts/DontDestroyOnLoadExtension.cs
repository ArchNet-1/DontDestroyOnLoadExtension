using UnityEngine;

namespace ArchNet.Extension.DontDestroyOnLoad
{
    /// <summary>
    /// [EXTENSION] - [ARCH NET] - [DONT DESTROY ON LOAD]
    /// Allow a Gameobject to be eternal on the scene by not destroying it between scenes 
    /// author : LOUIS PAKEL
    /// </summary>

    public class DontDestroyOnLoadExtension : MonoBehaviour
    {
        /// <summary>
        /// This will work on every 3D object and Root UI 2D Object
        /// </summary>
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            Debug.Log($"{gameObject.name} will not be destroyed on load !");
        }
    }
}
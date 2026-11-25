// ArchNet · Dont Destroy On Load Extension
// Add this component to keep its GameObject alive when a new scene loads
// (managers, music player…). No code needed.
// Docs: https://archnet-plateform.fr/#DontDestroyOnLoadExtension

using UnityEngine;

namespace ArchNet.Extension
{
    [DisallowMultipleComponent]
    [AddComponentMenu("ArchNet/Dont Destroy On Load")]
    public class DontDestroyOnLoadExtension : MonoBehaviour
    {
        void Awake()
        {
            // DontDestroyOnLoad only works on root objects.
            if (transform.parent != null) transform.SetParent(null, true);
            DontDestroyOnLoad(gameObject);
        }
    }
}

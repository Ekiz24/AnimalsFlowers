using UnityEngine;

// Generic Singleton class to be inherited by other MonoBehaviour classes
public class Singleton<T> : MonoBehaviour
    where T : Component
{
    // Flag to indicate if the application is quitting
    private static bool _applicationIsQuitting = false;

    // Static instance of the singleton
    private static T _instance = null;
    public static T instance
    {
        get
        {
            if (_instance == null && !_applicationIsQuitting)
            {
                _instance = FindObjectOfType<T>(); // Find existing instance in the scene

                if (_instance == null)
                    _instance = new GameObject("_" + typeof(T).Name).AddComponent<T>(); // Create new instance if none found

                DontDestroyOnLoad(_instance); // Prevent the instance from being destroyed on scene load
            }

            return _instance;
        }
    }

    // Awake method to initialize the singleton instance
    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T; // Assign this instance to the singleton
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instance
        }
    }

    public void ForceLoad()
    {
        // no-op, force the lazy load of the singleton.
    }

    protected virtual void OnApplicationQuit()
    {
        _instance = null;
        Destroy(gameObject);
        _applicationIsQuitting = true;
    }
}
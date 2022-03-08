using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class EnableTracking : MonoBehaviour
{
    // Start is called before the first frame update

    public ARTrackedImageManager m_TrackedImageManager;

    public void Awake() {
        m_TrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

    public void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

    public void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var newImage in eventArgs.added)
        {
            // Handle added event
        }

        foreach (var updatedImage in eventArgs.updated)
        {
            // Handle updated event
        }

        foreach (var removedImage in eventArgs.removed)
        {
            // Handle removed event
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}

using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class DriftCamera : MonoBehaviour
{
    [Serializable]
    public class AdvancedOptions
    {
        public                   bool             updateCameraInUpdate;
        public                   bool             updateCameraInFixedUpdate = true;
        public                   bool             updateCameraInLateUpdate;
        [SerializeField] private InputActionAsset inputActionAsset;

        public InputActionAsset InputActionAsset
        {
            get { return inputActionAsset; }
        }
    }

    public float smoothing = 6f;
    public Transform lookAtTarget;
    public Transform positionTarget;
    public Transform sideView;
    public AdvancedOptions advancedOptions;
    
    private InputActionMap inputActionMap;
    private InputAction    inputSwitchViewAction;

    bool m_ShowingSideView;

    private void Start()
    {
        inputActionMap = advancedOptions.InputActionAsset.FindActionMap("Gameplay");

        inputSwitchViewAction = inputActionMap.FindAction("Switch View");

        inputSwitchViewAction.started += OnSwitchView;
    }

    private void FixedUpdate ()
    {
        if(advancedOptions.updateCameraInFixedUpdate)
            UpdateCamera ();
    }

    private void Update ()
    {
        if(advancedOptions.updateCameraInUpdate)
            UpdateCamera ();
    }

    private void LateUpdate ()
    {
        if(advancedOptions.updateCameraInLateUpdate)
            UpdateCamera ();
    }

    private void UpdateCamera ()
    {
        if (m_ShowingSideView)
        {
            transform.position = sideView.position;
            transform.rotation = sideView.rotation;
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, positionTarget.position, Time.deltaTime * smoothing);
            transform.LookAt(lookAtTarget);
        }
    }

    private void OnSwitchView(InputAction.CallbackContext context)
    {
        m_ShowingSideView = !m_ShowingSideView;
    }
}

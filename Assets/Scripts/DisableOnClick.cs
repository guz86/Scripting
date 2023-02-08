using UnityEngine;

    public class DisableOnClick : MonoBehaviour
    {
        private void OnMouseDown()
        {
            gameObject.SetActive(false);
        }
    }
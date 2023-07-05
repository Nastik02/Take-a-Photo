using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class CameraZoom : MonoBehaviour
    {
        private float zoomstep;
        private float zoom;
        private float velocity=3f;
        private float SmoothTime = 0.25f;
        [SerializeField]private Camera cam;

        public void Zoom()
        {
            cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, 300, ref velocity, SmoothTime);
            StartCoroutine(_Destroy());
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                Zoom();
                //scream.Play();
                //crch.SendMessage("Move");
            }
        }
        private IEnumerator _Destroy()
        {
            yield return new WaitForSeconds(0.5f);
            Destroy(this.gameObject);
        }

        
    }
}
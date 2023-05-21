using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    internal class ParticlDestroer: MonoBehaviour
    {
        private SpriteRenderer sprite;
        private void Awake()
        {
            sprite= GetComponent<SpriteRenderer>();
            Color color = sprite.material.color;
            color.a = 0f;
            sprite.material.color= color;
        }
        private void Start()
        {
            StartCoroutine(Destroy());
        }
        private IEnumerator Destroy()
        {
            for(float f = 0.05f; f <= 1; f += 0.05f)
            {
                Color color = sprite.material.color;
                color.a = f;
                sprite.material.color = color;
                yield return new WaitForSeconds(0.008f);
            }
            Destroy(this.gameObject);
        }
    }
}

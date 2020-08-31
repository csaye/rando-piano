using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

namespace RandoPiano
{
    [RequireComponent(typeof(Slider))]
    public class VolumeSlider : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private AudioMixer audioMixer = null;

        private Slider slider;

        private void Start()
        {
            slider = GetComponent<Slider>();
        }

        public void UpdateVolume()
        {
            audioMixer.SetFloat("Volume", slider.value);
        }
    }
}

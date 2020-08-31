using UnityEngine;
using UnityEngine.UI;

namespace RandoPiano
{
    [RequireComponent(typeof(Slider))]
    public class TempoSlider : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private NoteGenerator noteGenerator = null;

        private Slider slider;

        private void Start()
        {
            slider = GetComponent<Slider>();
        }

        public void UpdateTempo()
        {
            noteGenerator.noteSpeed = slider.value;
        }
    }
}

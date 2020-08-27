using UnityEngine;

namespace RandoPiano
{
    [RequireComponent(typeof(AudioSource))]
    public class NotePlayer : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private AudioClip[] notes = new AudioClip[7];

        private AudioSource audioSource;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void PlayNote(int note)
        {
            int octaveShift = Mathf.FloorToInt(note / 7.0f);

            int adjustedNote = note;

            while (adjustedNote < 0)
            {
                adjustedNote += 7;
            }

            adjustedNote = adjustedNote % 7;

            audioSource.pitch = Mathf.Pow(2, octaveShift);
            audioSource.clip = notes[adjustedNote];
            audioSource.Play();
        }
    }
}

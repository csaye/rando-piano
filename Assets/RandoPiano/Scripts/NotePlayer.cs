using UnityEngine;

namespace RandoPiano
{
    [RequireComponent(typeof(AudioSource))]
    public class NotePlayer : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private AudioClip[] notes = new AudioClip[12];

        public void PlayNote(int note)
        {

        }
    }
}

using UnityEngine;

namespace RandoPiano
{
    public class NoteRenderer : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Sprite upNote = null;
        [SerializeField] private Sprite downNote = null;
        [SerializeField] private GameObject[] noteObjects = new GameObject[32];

        private int currentNote = 31;

        public void RenderNote(int note)
        {
            currentNote++;

            if (currentNote >= 32)
            {
                ClearNoteObjects();
                currentNote = 0;
            }

            GameObject currentObject = noteObjects[currentNote];

            currentObject.SetActive(true);

            if (note < 0)
            {
                currentObject.GetComponent<SpriteRenderer>().sprite = downNote;
            }
            else
            {
                currentObject.GetComponent<SpriteRenderer>().sprite = upNote;
            }

            Transform currentTransform = currentObject.transform;
            currentTransform.localPosition = new Vector3(currentTransform.localPosition.x, GetNoteY(note), 0);

        }

        private void ClearNoteObjects()
        {
            foreach (GameObject noteObject in noteObjects)
            {
                noteObject.SetActive(false);
            }
        }

        private float GetNoteY(int note)
        {
            return note * 0.125f;
        }
    }
}

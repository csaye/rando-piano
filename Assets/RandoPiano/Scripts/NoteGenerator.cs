﻿using System.Collections;
using UnityEngine;

namespace RandoPiano
{
    public class NoteGenerator : MonoBehaviour
    {
        [Header("Attributes")]
        [SerializeField] [Range(-5, 0)] private int minNote = 0;
        [SerializeField] [Range(0, 5)] private int maxNote = 0;

        [Header("References")]
        [SerializeField] private NotePlayer notePlayer = null;
        [SerializeField] private NoteRenderer noteRenderer = null;
        [SerializeField] private PlayPauseButton playPauseButton = null;

        public float noteSpeed {get; set;} = 1f;

        private void Start()
        {
            StartCoroutine(GenerateNotes());
        }

        private IEnumerator GenerateNotes()
        {
            int note;

            while (true)
            {   
                yield return new WaitForSeconds(noteSpeed);

                if (!playPauseButton.playing) continue;

                note = GetRandomNote();

                notePlayer.PlayNote(note);
                noteRenderer.RenderNote(note);
            }
        }

        private int GetRandomNote()
        {
            return Random.Range(minNote, maxNote + 1);
        }
    }
}

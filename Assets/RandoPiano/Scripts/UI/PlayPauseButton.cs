using UnityEngine;
using UnityEngine.UI;

namespace RandoPiano
{
    [RequireComponent(typeof(Button),typeof(Image))]
    public class PlayPauseButton : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Sprite playButton = null;
        [SerializeField] private Sprite playButtonHighlight = null;
        [SerializeField] private Sprite pauseButton = null;
        [SerializeField] private Sprite pauseButtonHighlight = null;

        public bool playing {get; private set;} = false;

        private Button button;
        private Image image;

        private void Start()
        {
            button = GetComponent<Button>();
            image = GetComponent<Image>();
        }

        public void OnClick()
        {
            playing = !playing;

            if (playing)
            {
                SetPauseButton();
            }
            else
            {
                SetPlayButton();
            }
        }

        private void SetPlayButton()
        {
            image.sprite = playButton;

            SpriteState spriteState = new SpriteState();

            spriteState.highlightedSprite = playButtonHighlight;
            spriteState.pressedSprite = playButtonHighlight;

            button.spriteState = spriteState;
        }

        private void SetPauseButton()
        {
            image.sprite = pauseButton;

            SpriteState spriteState = new SpriteState();

            spriteState.highlightedSprite = pauseButtonHighlight;
            spriteState.pressedSprite = pauseButtonHighlight;

            button.spriteState = spriteState;
        }
    }
}

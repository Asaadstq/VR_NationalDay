using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayVideoOnButtonPress : MonoBehaviour
{
    public Button playButton;       // The UI button in world space
    public VideoPlayer videoPlayer; // The video player component
    public RawImage rawImage;       // The Raw Image for displaying the video

    void Start()
    {
        // Assign the Button onClick event to trigger PlayVideo method
        playButton.onClick.AddListener(PlayVideo);
        
        // Disable the Raw Image until the video starts
        rawImage.enabled = false;
    }

    void PlayVideo()
    {
        // Enable the Raw Image to display the video
        rawImage.enabled = true;
        
        // Start playing the video
        videoPlayer.Play();
    }
}

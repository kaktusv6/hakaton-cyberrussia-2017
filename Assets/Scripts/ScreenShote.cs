using UnityEngine;
using System.Collections;
 
public class ScreenShote : MonoBehaviour {
	public int resWidth = 1024; 
	public int resHeight = 720;
 
	private bool takeHiResShot = false;

	private Camera camera;

	void Start()
	{
		camera = Camera.main;
		resWidth = camera.pixelWidth;
		resHeight = camera.pixelHeight;
	}
	public static string ScreenShotName(int width, int height) {
		return string.Format("{0}/screenshots/screen_{1}x{2}_{3}.png", 
			Application.dataPath, 
			width, height, 
			System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
	}
 
	public void TakeHiResShot() {
		takeHiResShot = true;
	}

	void ScreenShot()
	{
		RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
		camera.targetTexture = rt;
		Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
		camera.Render();
		RenderTexture.active = rt;
		screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
		camera.targetTexture = null;
		RenderTexture.active = null; // JC: added to avoid errors
		Destroy(rt);
		byte[] bytes = screenShot.EncodeToPNG();
		string filename = ScreenShotName(resWidth, resHeight);
		System.IO.File.WriteAllBytes(filename, bytes);
		Debug.Log(string.Format("Took screenshot to: {0}", filename));
		takeHiResShot = false;
	}
}
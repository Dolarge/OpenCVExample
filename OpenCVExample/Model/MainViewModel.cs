using OpenCvSharp;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace OpenCVExample.Model
{
    public class MainViewModel
    {
        VideoCapture cap;
        WriteableBitmap wb;
        const int frameWidth = 640;
        const int frameHeight = 480;
        bool loop = false;


        public MainViewModel()
        {
            
        }

        public void WindowLoad()
        {

        }

        public bool initWebCamera()
        {
            try
            {
                cap = VideoCapture.FromCamera(CaptureDevice.Any, 0);
                cap.FrameWidth = frameWidth;
                cap.FrameHeight = frameHeight;
                cap.Open(0);
                wb = new WriteableBitmap(cap.FrameWidth, cap.FrameHeight, 96, 96, PixelFormats.Bgr24, null);
                Image.Source = wb;

                return true;
            }
            catch
            {
                return false;
            }


        }

    }
}

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
                Mat src = new Mat("lenna.png", ImreadModes.Grayscale);
                Mat dst = new Mat();

                Cv2.Canny(src, dst, 50, 200);
                using (new Window("src image", src))
                using (new Window("dst image", dst))
                {
                    Cv2.WaitKey();
                }
                return true;
            }
            catch
            {
                return false;
            }


        }

    }
}

using OpenCvSharp;
using System.ComponentModel;
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
        private readonly VideoCapture capture;

        public MainViewModel()
        {
            capture = new VideoCapture();
        }

        public void WindowLoad()
        {
            capture.Open(0, VideoCaptureAPIs.ANY);
            if (!capture.IsOpened())
            {

                return;
            }
            //창 연결
            //ClientSize = new System.Drawing.Size(capture.FrameWidth, capture.FrameHeight); BackgroundWorker.RunWorkerAsync();

        }

        private void CloseForm()
        {
            //backgroundWorker1.CancelAsync(); 
            //capture.Dispose();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //var bgWorker = (BackgroundWorker)sender;
            //while (!bgWorker.CancellationPending)
            //{
            //    using (var frameMat = capture.RetrieveMat())
            //    {
            //        var frameBitmap = BitmapConverter.ToBitmap(frameMat); bgWorker.ReportProgress(0, frameBitmap);
            //    }
            //    Thread.Sleep(100);
            //}
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

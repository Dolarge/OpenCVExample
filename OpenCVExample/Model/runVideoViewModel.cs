using OpenCvSharp;

namespace OpenCVExample.Model
{
    public class runVideoViewModel
    {

        public void viedoRun()
        {
            //video 초기화
            //""안에 경로
            VideoCapture VideoCapture = new VideoCapture("");
            
            //프레임 표시를 위해 선언
            Mat frame = new Mat();

            //현재 프레임이 동영상 파일의 총프레임과 같아질때까지
            while (VideoCapture.PosFrames != VideoCapture.FrameCount)
            {
                //Frame load
                VideoCapture.Read(frame);
                //표시
                Cv2.ImShow("frame", frame);
                //특정 시간만큼 대기
                Cv2.WaitKey(33);
                //click event 대기시에
                //원하는 이벤트 개발

            }

            frame.Dispose();
            VideoCapture.Release();
            Cv2.DestroyAllWindows();

        }
    }
}

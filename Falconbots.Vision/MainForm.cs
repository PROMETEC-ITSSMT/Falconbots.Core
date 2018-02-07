namespace FalconBots.Vision
{
    using System.Threading;
    using System.Windows.Forms;
    using System.Drawing;
    using OpenCvSharp;
    using System.Threading.Tasks;
    public partial class MainForm : Form
    {
        private Thread _cameraThread;

        public MainForm()
        {
            CaptureCamera();
            CrearVentana();
        }

        private void CaptureCamera()
        {
            _cameraThread = new Thread(CaptureCameraCallback);
            _cameraThread.Start();
        }

        private void CaptureCameraCallback()
        {
            using (var cap = CvCapture.FromCamera(2))
            {
                cap.SetCaptureProperty(CaptureProperty.FrameWidth, Layout.Width);
                cap.SetCaptureProperty(CaptureProperty.FrameHeight, Layout.Height);
                var mat = new CvMat();
                var img = new IplImage();
                while (true)
                {
                    img = cap.QueryFrame();

                    var img1 = img;
                    var taskA = Task.Factory.StartNew(() =>
                    {
                        var b = img1.ToBitmap();

                        ImgOut.Image = b;

                        img = null;
                        b = null;
                    });
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cameraThread != null && _cameraThread.IsAlive)
            {
                _cameraThread.Abort();
            }
        }
    }
}

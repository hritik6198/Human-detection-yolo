
using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Dnn;

namespace Hmd_confined
{
    public partial class Form1 : Form
    {
        private Net net;
        private VideoCapture capture;
        private Mat frame;



        public Form1()
        {
            InitializeComponent();
            net = CvDnn.ReadNetFromCaffe("deploy.prototxt", "mobilenet_iter_73000.caffemodel");
            capture = new VideoCapture(0);
            capture.Open(0);
            if (!capture.IsOpened())
            {
                MessageBox.Show("Error: Could not open video capture device.");
                return;
            }

           frame = new Mat();
           Application.Idle += ProcessFrame;
        }

       private void ProcessFrame(object sender, EventArgs e)
        {
           capture.Read(frame);

            if (frame.Empty())
                return;

           Cv2.Rectangle(frame, new Rect(100, 100, 800, 400), Scalar.Blue, 2);

            DetectHumans(frame);

            pictureBox1.Image = MatToBitmap(frame);
        }

        private Bitmap MatToBitmap(Mat mat)
       {
            var bitmap = new Bitmap(mat.Cols, mat.Rows, (int)mat.Step(), System.Drawing.Imaging.PixelFormat.Format24bppRgb, mat.Data);
            return new Bitmap(bitmap);
       }

        private void DetectHumans(Mat inputFrame)
        {
            OpenCvSharp.Size size = new OpenCvSharp.Size(300, 300);

            using (var blob = CvDnn.BlobFromImage(inputFrame, 0.007843, size, new Scalar(127.5, 127.5, 127.5), false))
            {
                net.SetInput(blob, "data");
                Mat detection = net.Forward("detection_out");

                for (int i = 0; i < detection.Size(2); i++)
                {
                   float confidence = detection.At<float>(0, 0, i, 2);
                    int classId = (int)detection.At<float>(0, 0, i, 1);

                   if (classId == 15 && confidence > 0.5) // Check for human detection with confidence threshold
                    {
                       int x1 = (int)(detection.At<float>(0, 0, i, 3) * inputFrame.Width);
                        int y1 = (int)(detection.At<float>(0, 0, i, 4) * inputFrame.Height);
                        int x2 = (int)(detection.At<float>(0, 0, i, 5) * inputFrame.Width);
                        int y2 = (int)(detection.At<float>(0, 0, i, 6) * inputFrame.Height);

                        Cv2.Rectangle(inputFrame, new Rect(x1, y1, x2 - x1, y2 - y1), Scalar.Green, 2);
                    }
                }
            }
        }
    }
}
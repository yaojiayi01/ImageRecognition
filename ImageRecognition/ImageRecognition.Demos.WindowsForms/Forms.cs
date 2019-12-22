using Emgu.CV;
using Emgu.CV.Cuda;
using Emgu.CV.UI;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageRecognition.Demos.WindowsForms
{
    public partial class Forms : Form
    {
        public Forms()
        {
            InitializeComponent();
        }
        private void SelectImage(Action<string> callback)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();     //显示选择文件对话框
            openFileDialog1.Filter = "All files (*.*)|*.*|image files |*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                callback(openFileDialog1.FileName);
                
            }
            openFileDialog1.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectImage((name) =>
            {
                this.orgimgpath.Text = name;          //显示文件路径
                ShowOrgImage();
            });
        }
        private void ShowOrgImage()
        {
            orgimg.Refresh();
            using (var img = Image.FromFile(this.orgimgpath.Text))
            {
                orgimg.Image = (Image)img.Clone();
            }
        }

        private void facedetection_btn_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string imagePath = orgimgpath.Text;

                long detectionTime;

                IImage image = FaceDetection.Tagging(imagePath, "data/haarcascade_frontalface_default.xml", "data/haarcascade_eye.xml", out detectionTime);
                //display the image 
                using (InputArray iaImage = image.GetInputArray())
                    ImageViewer.Show(image, String.Format(
                       "检测使用  {0} 模式，耗时 {1} milliseconds",
                       (iaImage.Kind == InputArray.Type.CudaGpuMat && CudaInvoke.HasCuda) ? "CUDA" :
                       (iaImage.IsUMat && CvInvoke.UseOpenCL) ? "OpenCL"
                       : "CPU",
                       detectionTime));
            });
        }

        private void pedestriandetectionbtn_Click(object sender, EventArgs e)
        {
            string imagePath = orgimgpath.Text;

            long detectionTime;
            Task.Run(() =>
            {
                IImage image = PedestrianDetection.Tagging(imagePath, out detectionTime);
                //display the image 
                ImageViewer.Show(
                   image,
                   String.Format("Pedestrian detection using {0} in {1} milliseconds.",
                      CudaInvoke.HasCuda ? "GPU" :
                      CvInvoke.UseOpenCL ? "OpenCL" :
                      "CPU",
                      detectionTime));
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectImage((name) =>
            {
                string observedImage = this.orgimgpath.Text;
                //起个线程去 进行匹配吧
                Task.Run(()=> {
                    long matchTime;
                    var result = DrawMatches.Match(observedImage, name, out matchTime);
                    ImageViewer.Show(result, String.Format("Matched in {0} milliseconds", matchTime));
                });
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //灰度处理
            string imagePath = this.orgimgpath.Text;
            //起个线程去 进行匹配吧
            Task.Run(() => {
                long runTime;
                var result = Base.Gray(imagePath,out runTime);
                ImageViewer.Show(result, String.Format("time  {0} milliseconds", runTime));
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //边缘
            string imagePath = this.orgimgpath.Text;
            //起个线程去 进行匹配吧
            Task.Run(() => {
                long runTime;
                var result = Base.Canny(imagePath, out runTime);
                ImageViewer.Show(result, String.Format("time  {0} milliseconds", runTime));
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string imagePath = this.orgimgpath.Text;
            //起个线程去 进行匹配吧
            Task.Run(() => {
                long runTime;
                var result = Base.Canny(imagePath, out runTime);
                //ImageViewer.Show(result, String.Format("time  {0} milliseconds", runTime));
                var result1 =Base.FindContours(result,out runTime);
                ImageViewer.Show(result1, String.Format("time  {0} milliseconds", runTime));
            });
        }
    }
}

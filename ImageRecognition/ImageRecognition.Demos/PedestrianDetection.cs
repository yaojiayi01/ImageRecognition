using Emgu.CV;
#if !(__IOS__ || NETFX_CORE)
using Emgu.CV.Cuda;
#endif
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Diagnostics;
using System.Drawing;

namespace ImageRecognition.Demos
{
    /// <summary>
    /// 行人检测 -代码来自EmguCV 例子
    /// </summary>
    public static class PedestrianDetection
    {
        /// <summary>
        /// Find the pedestrian in the image
        /// </summary>
        /// <param name="image">The image</param>
        /// <param name="processingTime">The processing time in milliseconds</param>
        /// <returns>The region where pedestrians are detected</returns>
        public static Rectangle[] Find(IInputArray image, out long processingTime)
        {
            Stopwatch watch;
            Rectangle[] regions;

            using (InputArray iaImage = image.GetInputArray())
            {
#if !(__IOS__ || NETFX_CORE)
                //if the input array is a GpuMat
                //check if there is a compatible Cuda device to run pedestrian detection
                if (iaImage.Kind == InputArray.Type.CudaGpuMat)
                {
                    //this is the Cuda version
                    using (CudaHOG des = new CudaHOG(new Size(64, 128), new Size(16, 16), new Size(8, 8), new Size(8, 8)))
                    {
                        des.SetSVMDetector(des.GetDefaultPeopleDetector());

                        watch = Stopwatch.StartNew();
                        using (GpuMat cudaBgra = new GpuMat())
                        using (VectorOfRect vr = new VectorOfRect())
                        {
                            CudaInvoke.CvtColor(image, cudaBgra, ColorConversion.Bgr2Bgra);
                            des.DetectMultiScale(cudaBgra, vr);
                            regions = vr.ToArray();
                        }
                    }
                }
                else
#endif
                {
                    //this is the CPU/OpenCL version
                    using (HOGDescriptor des = new HOGDescriptor())
                    {
                        des.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector());
                        watch = Stopwatch.StartNew();

                        MCvObjectDetection[] results = des.DetectMultiScale(image);
                        regions = new Rectangle[results.Length];
                        for (int i = 0; i < results.Length; i++)
                            regions[i] = results[i].Rect;
                        watch.Stop();
                    }
                }

                processingTime = watch.ElapsedMilliseconds;

                return regions;
            }
        }

        public static IImage Tagging(string imagePath, out long processingTime)
        {
                Mat image = new Mat(imagePath);
                Rectangle[] results;

                if (CudaInvoke.HasCuda)
                {
                    using (GpuMat gpuMat = new GpuMat(image))
                        results = Find(gpuMat, out processingTime);
                }
                else
                {
                    using (UMat uImage = image.GetUMat(AccessType.ReadWrite))
                        results = Find(uImage, out processingTime);
                }

                foreach (Rectangle rect in results)
                {
                    CvInvoke.Rectangle(image, rect, new Bgr(Color.Red).MCvScalar);
                }
                return image;
        }
    }
}

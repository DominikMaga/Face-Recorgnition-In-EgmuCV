using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using ZedGraph;


namespace WindowsFormsApp5
{
    public partial class paneBlue : Form
    {
        public paneBlue()
        {
            InitializeComponent();
        }
        FilterInfoCollection filtr;
        VideoCaptureDevice device;
        private void Form1_Load(object sender, EventArgs e)
        {
            filtr = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filtr)
                cboDevice.Items.Add(device.Name);
            cboDevice.SelectedIndex = 0;
            device = new VideoCaptureDevice();

            
            btnMyDetect.BackColor = btnStart.BackColor;
            btnOryginalDetect.BackColor = btnStart.BackColor;
            btnAllDetect.BackColor = btnStart.BackColor;
            btnMyDetect.Visible = false;
            btnOryginalDetect.Visible = false;
            btnAllDetect.Visible = false;
            panelBlue.Visible = false;
            panelRed.Visible = false;
            lab1.Visible = false;
            lab2.Visible = false;
        }
  

       static readonly CascadeClassifier myClassifier = new CascadeClassifier("cascade.xml");
       static readonly CascadeClassifier oryginalClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
            {
                device.Stop();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnMyDetect.Visible = true;
            btnOryginalDetect.Visible = true;
            btnAllDetect.Visible = true;
            if (device.IsRunning)
            {
                device.Stop();
           }
           device = new VideoCaptureDevice(filtr[cboDevice.SelectedIndex].MonikerString);
          device.NewFrame += Device_Frame;
           device.Start();
        }

        private void Device_Frame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            picture.Image = bitmap;

        }
        private void btnMyDetect_Click(object sender, EventArgs e)
        {
            panelBlue.Visible = false;
            panelRed.Visible = false;
            lab1.Visible = false;
            lab2.Visible = false;
            if (device.IsRunning)
            {
                device.Stop();
            }
            device = new VideoCaptureDevice(filtr[cboDevice.SelectedIndex].MonikerString);
            device.NewFrame += Device_MyNewFrame;
            device.Start();
        }

        private void btnOryginalDetect_Click(object sender, EventArgs e)
        {
            panelBlue.Visible = false;
            panelRed.Visible = false;
            lab1.Visible = false;
            lab2.Visible = false;
            if (device.IsRunning)
            {
                device.Stop();
            }
            device = new VideoCaptureDevice(filtr[cboDevice.SelectedIndex].MonikerString);
            device.NewFrame += Device_OryginalNewFrame;
            device.Start();
        }
        private void btnAllDetect_Click(object sender, EventArgs e)
        {
            panelBlue.Visible = true;
            panelRed.Visible = true;
            lab1.Visible = true;
            lab2.Visible = true;
            if (device.IsRunning)
            {
                device.Stop();
            }
            device = new VideoCaptureDevice(filtr[cboDevice.SelectedIndex].MonikerString);
            device.NewFrame += Device_AllNewFrame;
            device.Start();

        }
        private void Device_MyNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = myClassifier.DetectMultiScale(grayImage, 1.2, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Blue, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }

            picture.Image = bitmap;
        }

        private void Device_OryginalNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = oryginalClassifier.DetectMultiScale(grayImage, 1.2, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Blue, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }

            picture.Image = bitmap;
        }
        private void Device_AllNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] myRectangles = myClassifier.DetectMultiScale(grayImage, 1.2, 1);
            Rectangle[] orygRectangles = oryginalClassifier.DetectMultiScale(grayImage, 1.2, 1);
            foreach (Rectangle rectangle in orygRectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Blue, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }
            foreach (Rectangle rectangle in myRectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }

            picture.Image = bitmap;
        }

 
    }
}

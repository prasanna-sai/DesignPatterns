using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DelegateClass dc = new DelegateClass();
            //DelegateClass.TestDelegate dg1 = Sum;
            //dc.Process(dg1, 2, 3);
            //dg1 += Multiply;
            //dc.Process(dg1, 2, 3);
            //dg1 -= Sum;
            //dc.Process(dg1, 2, 3);

            //DelegateClassNew dc1 = new DelegateClassNew();
            //Func<int, int, int> dg2 = Sum;
            //dc1.Process(dg2, 2, 3);
            //dg2 += Multiply;
            //dc1.Process(dg2, 2, 3);
            //dg2 -= Multiply;
            //dc1.Process(dg2, 2, 3);

            //var vc = new VideoEncoder();
            //var ms = new MailService();
            //vc.VideoEncoded += ms.SubscriberMail;
            //vc.Encode(new Video());
            //vc.VideoEncoded += ms.SubscriberSMS;
            //vc.Encode(new Video());
            //vc.VideoEncoded -= ms.SubscriberSMS;
            //vc.Encode(new Video());

            var vc1 = new VideoEncoderNew();
            var ms1 = new MailService();
            vc1.VideoEncoded += ms1.SubscriberMail;
            vc1.Encode(new Video());
            vc1.VideoEncoded += ms1.SubscriberSMS;
            vc1.Encode(new Video());
            vc1.VideoEncoded -= ms1.SubscriberSMS;
            vc1.Encode(new Video());
        }

        public static int Sum(int x, int y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
            return (x * y);
        }

        public double Divide(int x, int y)
        {
            return x / (y * 1.0);
        }
    }

    public class DelegateClass
    {
        public delegate int TestDelegate(int x, int y);

        public void Process(TestDelegate d, int x, int y)
        {
            double z = d(x, y);
        }
    }

    public class DelegateClassNew
    {

        public void Process(Func<int,int,int> d, int x, int y)
        {
            double z = d(x, y);
        }
    }

    public class VideoEncoder
    {
        public delegate void VideoEncoderEventHandler(object sender, EventArgs e);

        public event VideoEncoderEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            OnVideoEncoded();
        }

        public void OnVideoEncoded()
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }

    public class VideoEncoderNew
    {
        public event EventHandler VideoEncoded;

        public void Encode(Video video)
        {
            OnVideoEncoded();
        }

        public void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public int x;
        public int y;
    }

    public class Video
    {

    }

    public class MailService
    {
        public void SubscriberMail(object sender, EventArgs e)
        {
            Console.WriteLine("This is subscriber mail");
        }

        public void SubscriberSMS(object sender, EventArgs e)
        {
            Console.WriteLine("This is subscriber SMS");
        }
    }
}

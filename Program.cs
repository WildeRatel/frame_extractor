using Emgu.CV;
using Emgu.CV.Structure;

string video_path = args[0];
using (VideoCapture capture = new VideoCapture(video_path))
{
    using (Mat frame = new Mat())
    {
        int frame_index = 0;
        int frame_interval = int.Parse(args[1]);

        while (capture.Read(frame))
        {
            if (!frame.IsEmpty)
            {
                if (frame_index % frame_interval == 0)
                {
                    frame.Save($"frame_{frame_index}.png");
                }
                frame_index++;
            }
        }
    }
}
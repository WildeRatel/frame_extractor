/*
    Copyright 2026 Ruben Martin Ferreira (WildeRatel)

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */

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
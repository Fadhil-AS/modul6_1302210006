using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210006
{
    internal class SayaTubeUser_1302210006
    {
        private int id;
        private List<SayaTubeVideo_1302210006> uploadedVideos;
        public string Username;

        public SayaTubeUser_1302210006(string username) {
            Random rand = new Random();
            this.id = rand.Next(1000, 99999);
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo_1302210006>();
        }

        public int GetTotalVideoPlayCount_1302210006() {
            
            int totalVideoPlayCount = 0;

            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                totalVideoPlayCount += uploadedVideos[i].getPlayCount_1302210006();
            }
            return totalVideoPlayCount;
        }

        public void AddVideo_1302210006(SayaTubeVideo_1302210006 upload) {
            uploadedVideos.Add(upload);
        }

        public void PrintAllVideoPlayCount() {
            Console.WriteLine("User: " + Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + i+1 + " judul: " + uploadedVideos[i].getTitle());
            }   
        }
    }
}

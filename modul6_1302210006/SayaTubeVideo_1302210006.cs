using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210006
{
    internal class SayaTubeVideo_1302210006
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo_1302210006(string title) { 
            Random rdm = new Random();
            this.id = rdm.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public int getPlayCount_1302210006() { 
            return playCount; 
        }
        public string getTitle() { return title; }
        public void IncreasePlayCount(int playCount) {
            this.playCount++;
        }

        public void PrintVideoDetails() {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("PlayCount " + playCount);
        }
    }
}

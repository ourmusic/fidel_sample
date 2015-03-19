using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalMVC.Models
{
    public class VideoQueue
    {
        private LinkedList<Video> videoList = new LinkedList<Video>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        void AddVideo(Video v)
        {
            if(!videoList.Contains(v)) videoList.AddLast(v);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Video RemoveFirstVideo()
        {
            Video ret = videoList.First();
            videoList.RemoveFirst();
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        public void RemoveUnwantedVideo(Video v)
        {
            LinkedListNode<Video> l = videoList.Last;
            while(l.Previous.Value != v) l = l.Previous;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        public void Upvote(Video v)
        {
            LinkedListNode<Video> vid = videoList.Find(v);
            vid.Value.Upvote();
            CheckOrder(vid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        public void Downvote(Video v)
        {
            LinkedListNode<Video> vid = videoList.Find(v);
            vid.Value.Downvote();
            CheckOrder(vid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public void CheckOrder(LinkedListNode<Video> node)
        {
            LinkedListNode<Video> temp = node;
            if (node.Value.GetVotes() < node.Next.Value.GetVotes())
            {
                while(temp.Value.GetVotes() < temp.Next.Value.GetVotes())
                {
                    temp = node.Next;
                }
                videoList.Remove(node);
                videoList.AddBefore(temp, node);
            }
            else if(node.Value.GetVotes() > node.Previous.Value.GetVotes())
            {
                while(temp.Value.GetVotes() > temp.Previous.Value.GetVotes())
                {
                    temp = node.Previous;
                }
                videoList.Remove(node);
                videoList.AddAfter(temp, node);
            }
        }

    }
}
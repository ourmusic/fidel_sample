using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalMVC.Models
{
    public class VideoQueue
    {
        private LinkedList<Video> videoList = new LinkedList<Video>();

        void addVideo(Video v)
        {
            if(!videoList.Contains(v)) videoList.AddLast(v);
        }
        Video removeFirstVideo()
        {
            Video ret = videoList.First();
            videoList.RemoveFirst();
            return ret;
        }
        void removeUnwantedVideo(Video v)
        {
            LinkedListNode<Video> l = videoList.Last;
            while(l.Previous.Value != v) l = l.Previous;
            
        }
        void upvote(Video v)
        {
            LinkedListNode<Video> vid = videoList.Find(v);
            vid.Value.upvote();
            checkOrder(vid);
        }
        void downvote(Video v)
        {
            LinkedListNode<Video> vid = videoList.Find(v);
            vid.Value.downvote();
            checkOrder(vid);
        }
        void checkOrder(LinkedListNode<Video> node)
        {
            LinkedListNode<Video> temp = node;
            if (node.Value.getVotes() < node.Next.Value.getVotes())
            {
                while(temp.Value.getVotes() < temp.Next.Value.getVotes())
                {
                    temp = node.Next;
                }
                videoList.Remove(node);
                videoList.AddBefore(temp, node);
            }
            else if(node.Value.getVotes() > node.Previous.Value.getVotes())
            {
                while(temp.Value.getVotes() > temp.Previous.Value.getVotes())
                {
                    temp = node.Previous;
                }
                videoList.Remove(node);
                videoList.AddAfter(temp, node);
            }
        }

    }
}
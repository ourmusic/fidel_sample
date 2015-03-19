using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalMVC.Models
{
    public class Video
    {
        //may need to change these variables to be public
        private string title;        //title of the video 
        private string url;          //url of the video
        private string artist;       //artist of the video
        private string album;        //album of the video
        private int votes;           //votes to determine play order

        /// <summary>
        /// constructor for video class, initially all unknown
        /// </summary>
        public Video()
        {
            this.title = "";
            this.url = "";
            this.artist = "";
            this.album = "";
            this.votes = 0;
        }

        /// <summary>
        /// Title Helper Functions
        /// </summary>
        /// <returns></returns>
        public string GetTitle()
        {
            return this.title;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        public void SetTitle(string title)
        {
            this.title = title;
        }

        /// <summary>
        /// Artist Helper Functions
        /// </summary>
        /// <returns></returns>
        public string GetArtist()
        {
            return this.artist;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="artist"></param>
        public void SetArtist(string artist)
        {
            this.artist = artist;
        }

        /// <summary>
        /// Album Helper Functions
        /// </summary>
        /// <returns></returns>
        public string GetAlbum()
        {
            return this.album;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="album"></param>
        public void SetAlbum(string album)
        {
            this.album = album;
        }

        /// <summary>
        /// URL Helper Functions
        /// </summary>
        /// <returns></returns>
        public string GetUrl()
        {
            return this.url;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        public void SetUrl(string url)
        {
            this.url = url;
        }

        /// <summary>
        /// Votes Helper Functions
        /// </summary>
        /// <returns></returns>
        public int GetVotes()
        {
            return this.votes;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Upvote()
        {
            this.votes++;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Downvote()
        {
            this.votes--;
        }
    }

}
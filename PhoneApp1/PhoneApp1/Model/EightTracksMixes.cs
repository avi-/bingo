using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace PhoneApp1.DataServices
{
    public class CoverUrls
    {
        public string sq56 { get; set; }
        public string sq100 { get; set; }
        public string sq133 { get; set; }
        public string max133w { get; set; }
        public string max200 { get; set; }
        public string sq250 { get; set; }
        public string sq500 { get; set; }
        public string max1024 { get; set; }
        public string original { get; set; }
    }

    public class AvatarUrls
    {
        public string sq56 { get; set; }
        public string sq72 { get; set; }
        public string sq100 { get; set; }
        public string max200 { get; set; }
        public string max250w { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string slug { get; set; }
        public AvatarUrls avatar_urls { get; set; }
        public bool followed_by_current_user { get; set; }
    }

    public class Mix
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool published { get; set; }
        public string description { get; set; }
        public int plays_count { get; set; }
        public int likes_count { get; set; }
        public string slug { get; set; }
        public string path { get; set; }
        public CoverUrls cover_urls { get; set; }
        public string restful_url { get; set; }
        public string tag_list_cache { get; set; }
        public string first_published_at { get; set; }
        public bool liked_by_current_user { get; set; }
        public bool nsfw { get; set; }
        public User user { get; set; }
    }

    public class EightTracksMixes
    {
        public int id { get; set; }
        public string path { get; set; }
        public string restful_url { get; set; }
        public int total_entries { get; set; }
        public int page { get; set; }
        public int per_page { get; set; }
        public int next_page { get; set; }
        public object previous_page { get; set; }
        public int total_pages { get; set; }
        public string canonical_path { get; set; }
        public string name { get; set; }
        public List<Mix> mixes { get; set; }
        public string status { get; set; }
        public object errors { get; set; }
        public object notices { get; set; }
        public bool logged_in { get; set; }
        public List<string> api_warning { get; set; }
        public int api_version { get; set; }
    }
}

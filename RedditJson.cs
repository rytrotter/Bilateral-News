﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilateralNews
{
    class RedditJson
    {
        public class PostData
        {
            public object approved_at_utc { get; set; }
            public string subreddit { get; set; }
            public string selftext { get; set; }
            public string author_fullname { get; set; }
            public bool saved { get; set; }
            public object mod_reason_title { get; set; }
            public float gilded { get; set; }
            public bool clicked { get; set; }
            public string title { get; set; }
            public List<object> link_flair_richtext { get; set; }
            public string subreddit_name_prefixed { get; set; }
            public bool hidden { get; set; }
            public float pwls { get; set; }
            public object link_flair_css_class { get; set; }
            public float downs { get; set; }
            public float? thumbnail_height { get; set; }
            public bool hide_score { get; set; }
            public string name { get; set; }
            public bool quarantine { get; set; }
            public string link_flair_text_color { get; set; }
            public object author_flair_background_color { get; set; }
            public string subreddit_type { get; set; }
            public float ups { get; set; }
            public string domain { get; set; }
            public float? thumbnail_width { get; set; }
            public object author_flair_template_id { get; set; }
            public bool is_original_content { get; set; }
            public List<object> user_reports { get; set; }
            public bool is_reddit_media_domain { get; set; }
            public bool is_meta { get; set; }
            public object category { get; set; }
            public object link_flair_text { get; set; }
            public bool can_mod_post { get; set; }
            public float score { get; set; }
            public object approved_by { get; set; }
            public string thumbnail { get; set; }
            public bool edited { get; set; }
            public object author_flair_css_class { get; set; }
            public List<object> author_flair_richtext { get; set; }
            public object content_categories { get; set; }
            public bool is_self { get; set; }
            public object mod_note { get; set; }
            public float created { get; set; }
            public string link_flair_type { get; set; }
            public float wls { get; set; }
            public object banned_by { get; set; }
            public string author_flair_type { get; set; }
            public bool contest_mode { get; set; }
            public object selftext_html { get; set; }
            public object likes { get; set; }
            public object suggested_sort { get; set; }
            public object banned_at_utc { get; set; }
            public object view_count { get; set; }
            public bool archived { get; set; }
            public bool no_follow { get; set; }
            public bool is_crosspostable { get; set; }
            public bool pinned { get; set; }
            public bool over_18 { get; set; }
            public bool media_only { get; set; }
            public bool can_gild { get; set; }
            public bool spoiler { get; set; }
            public bool locked { get; set; }
            public object author_flair_text { get; set; }
            public bool visited { get; set; }
            public object num_reports { get; set; }
            public object distinguished { get; set; }
            public string subreddit_id { get; set; }
            public object mod_reason_by { get; set; }
            public object removal_reason { get; set; }
            public string link_flair_background_color { get; set; }
            public string id { get; set; }
            public bool is_robot_indexable { get; set; }
            public object report_reasons { get; set; }
            public string author { get; set; }
            public float num_crossposts { get; set; }
            public float num_comments { get; set; }
            public bool send_replies { get; set; }
            public string whitelist_status { get; set; }
            public List<object> mod_reports { get; set; }
            public bool author_patreon_flair { get; set; }
            public object author_flair_text_color { get; set; }
            public string permalink { get; set; }
            public string parent_whitelist_status { get; set; }
            public string url { get; set; }

        }

        public class Child
        {
            public string kind { get; set; }
            public PostData data { get; set; }
        }

        public class Data
        {
            public string modhash { get; set; }
            public float dist { get; set; }
            public List<Child> children { get; set; }
            public string after { get; set; }
            public object before { get; set; }
        }

        public class RootObject
        {
            public string kind { get; set; }
            public Data data { get; set; }
        }
    }
}

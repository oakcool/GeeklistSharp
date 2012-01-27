﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace GeeklistSharp.Model
{
	[DataContract]
	public class User
	{
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[DataMember(Name = "name")]
		public string Name { get; set; }

		[DataMember(Name = "screen_name")]
		public string ScreenName { get; set; }

        [DataMember(Name = "avatar")]
        public Avatar Avatar { get; set; }

        [DataMember(Name = "blog_link")]
        public Uri BlogLink { get; set; }

        [DataMember(Name = "company")]
        public Company Company { get; set; }

        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "bio")]
        public string Bio { get; set; }

        [DataMember(Name = "social_links")]
        public List<Uri> Links { get; set; }

        [DataMember(Name = "social")]
        public Social Social { get; set; }

        [DataMember(Name = "criteria")]
        public Criteria Criteria { get; set; }

        [DataMember(Name = "stats")]
        public Stats Stats { get; set; }

        [DataMember(Name = "is_beta")]
        public bool IsBeta { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }

        [DataMember(Name = "active_at")]
        public string ActiveAt { get; set; }
        
        [DataMember(Name = "trending_at")]
        public string TrendingAt { get; set; }

        [DataMember(Name = "trending_hist")]
        public List<string> TrendingHistory { get; set; }
	}

    [DataContract]
    public class Avatar
    {
        [DataMember(Name = "small")]
        public Uri Small { get; set; }

        [DataMember(Name = "large")]
        public Uri Large { get; set; }
    }

    [DataContract]
    public class Company
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }

    [DataContract]
    public class Social
    {
        [DataMember(Name = "twitter_screen_name")]
        public string TwitterScreenName { get; set; }

        [DataMember(Name = "twitter_friends_count")]
        public long TwitterFriends { get; set; }

        [DataMember(Name = "twitter_followers_count")]
        public long TwitterFollowers { get; set; }
    }

    [DataContract]
    public class Criteria
    {
        [DataMember(Name = "looking_for")]
        public List<string> LookingFor { get; set; }

        [DataMember(Name = "available_for")]
        public List<string> AvailabeFor { get; set; }
    }

    
}

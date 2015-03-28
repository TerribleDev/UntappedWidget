using System;
using System.Collections.Generic;
using System.Linq;
using CsQuery;
using UntappedWidgetGenerator.Interface;
using UntappedWidgetGenerator.Model;

namespace UntappedWidgetGenerator
{
    public class UntappedRepository : IUntappedRepository
    {
        public WidgetViewModel Get(string username)
        {
            if (String.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentNullException("username");
            }

            var userProfile = String.Format("https://untappd.com/user/{0}", username);
            var badgeProfile = String.Format("https://untappd.com/user/{0}/badges", username);
            var dom = CQ.CreateFromUrl(userProfile);
            var badgedom = CQ.CreateFromUrl(badgeProfile);
            var badges = new List<Badge>();
            badgedom[".badges .item a[href!=#]"].Each(a =>
            {
                badges.Add(new Badge()
                {
                    LinkUrl = "https://untappd.com" + a.GetAttribute("href"),
                    ImageUrl = a.Cq().Find("img").Attr("data-original"),
                    Title = a.Cq().Find(".name").Text()
                });
            });
            return new WidgetViewModel()
            {
                AvatarUrl = dom[".avatar-holder img"].Attr("src"),
                //todo: Actually use regex this is terrible
                HeaderBackgroundUrl =
                    dom[".profile_header"].Css("background-image").ToLower().TrimStart("url".ToCharArray()).TrimStart('(').TrimEnd(')').Trim('\''),
                Info = dom[".info h1"].Text(),
                Username = dom[".username"].Text(),
                Badges = badges.OrderBy(a=>Guid.NewGuid()).ToList()
                
            };
        }
    }
}

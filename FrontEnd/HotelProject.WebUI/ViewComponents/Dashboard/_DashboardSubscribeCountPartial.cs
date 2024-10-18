﻿using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/binotegitimcom"),
                Headers =
                {
                    { "x-rapidapi-key", "82ed99d7d1msh3c918ae92a0e65fp150a8bjsnd3de8e5a3333" },
                    { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.Ifollowers = resultInstagramFollowersDtos.followers;
                ViewBag.Ifollowing = resultInstagramFollowersDtos.following;
            }

            
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter154.p.rapidapi.com/user/details?username=binotkurscom"),
                Headers =
            {
            { "x-rapidapi-key", "82ed99d7d1msh3c918ae92a0e65fp150a8bjsnd3de8e5a3333" },
             { "x-rapidapi-host", "twitter154.p.rapidapi.com" },
            },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.Tfollowers = resultTwitterFollowersDto.follower_count;
                ViewBag.Tfollowing = resultTwitterFollowersDto.following_count;
            }
            return View();
        }
    }
}

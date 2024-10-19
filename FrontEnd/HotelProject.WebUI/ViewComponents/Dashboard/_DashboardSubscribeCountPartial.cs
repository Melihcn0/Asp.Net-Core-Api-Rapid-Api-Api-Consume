using HotelProject.WebUI.Dtos.FollowersDto;
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
	RequestUri = new Uri("https://instagram-scraper-api2.p.rapidapi.com/v1/info?username_or_id_or_url=melihwvia"),
                Headers =
                {
        { "x-rapidapi-key", "82ed99d7d1msh3c918ae92a0e65fp150a8bjsnd3de8e5a3333" },
        { "x-rapidapi-host", "instagram-scraper-api2.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.Ifollowers = resultInstagramFollowersDtos.data.follower_count;
                ViewBag.Ifollowing = resultInstagramFollowersDtos.data.following_count;
            }


            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter-api45.p.rapidapi.com/screenname.php?screenname=onsekizmartuni"),
                Headers =
            {
            { "x-rapidapi-key", "82ed99d7d1msh3c918ae92a0e65fp150a8bjsnd3de8e5a3333" },
            { "x-rapidapi-host", "twitter-api45.p.rapidapi.com" },
            },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.Tfollowers = resultTwitterFollowersDto.sub_count;
                ViewBag.Tfollowing = resultTwitterFollowersDto.friends;
            }

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=www.linkedin.com%2Fin%2Fmelihcan-k-024aa4269&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
                Headers =
            {
        { "x-rapidapi-key", "82ed99d7d1msh3c918ae92a0e65fp150a8bjsnd3de8e5a3333" },
        { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
            },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLinkedInFollowersDto resultLinkedInFollowersDto = JsonConvert.DeserializeObject<ResultLinkedInFollowersDto>(body3);
                ViewBag.LConnection = resultLinkedInFollowersDto.data.connection_count;
                ViewBag.Lfollowing = resultLinkedInFollowersDto.data.follower_count;
            }
            return View();
        }
    }
}
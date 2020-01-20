using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SAPChatHub.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet("Register")]
        [ActionName("Register")]
        public ActionResult Register(string cid)
        {
            string cookieResult = "";

            if (Request.Cookies["sapchatclientkey"] != null)
            {
                cookieResult  = Request.Cookies["sapchatclientkey"].ToString();
            }
            else
            {
                var cookieOption = new CookieOptions { Expires = DateTime.Now.AddYears(1) };
                var guid = $"{Guid.NewGuid()}---{DateTime.Now.Ticks}"; ;
                Response.Cookies.Append("sapchatclientkey", guid,cookieOption);
                cookieResult = "added just now";
            }
            return Ok(cookieResult);
        }

        [HttpGet("CIDRegister")]
        [ActionName("CIDRegister")]
        public ActionResult CIDRegister(string cid)
        {
            string cookieResult = "";

            if (Request.Cookies["sapchatclientkey"] != null)
            {
                cookieResult = Request.Cookies["sapchatclientkey"].ToString();
            }
            

            return Ok($"cid {cid} for {cookieResult}");
        }
    }
}
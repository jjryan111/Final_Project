﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using Newtonsoft.Json;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    public class HomeController : Controller
    {
        string size = "?height=300&width=300";
        string urlHeader = "http://api.harvardartmuseums.org";
        string param = "/object?person=33430";
        string APIkey = "&apikey=db4038a0-79da-11e7-aa25-e32c9c02c857";

        public ActionResult Image()
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://api.harvardartmuseums.org" + param + APIkey);
            request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string ApiText = rd.ReadToEnd();
            JObject o = JObject.Parse(ApiText);
            //ViewBag.ApiText = o["url"];

            //for use with one image:
            ViewBag.ApiText = o["records"][0]["images"][0]["baseimageurl"] + size;
            return View();
        }

        public ActionResult Data(Queries q)
        {
            //string call = q.SearchURL;
            //HttpWebRequest request = WebRequest.CreateHttp("http://api.harvardartmuseums.org" + param + APIkey);
            //HttpWebRequest request = WebRequest.CreateHttp("http://api.harvardartmuseums.org/object?aggregation={records:{people:{culture:American}}}" + APIkey);

            //HttpWebRequest request = WebRequest.CreateHttp("\"" + call + "\"");
            //request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //StreamReader rd = new StreamReader(response.GetResponseStream());
            //string ApiText = rd.ReadToEnd();
            //JObject o = JObject.Parse(ApiText);
            //ViewBag.ApiText = o["url"];
            //ViewBag.search = call;
            //for use with one image:
            //ViewBag.ApiText = o["images"][0]["baseimageurl"] + size;
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
        public void update_action(string medium)
        {
            if (medium == "Photography")
            {
                Response.Redirect("/Home/Photo.cshtml");
//                Server.Transfer("/Home/Photo.cshtml");
            }
            else
            {
                Server.Transfer("/Home/Index.cshtml");
            }            
        }
        public ActionResult InitResp (string r)
        {
            string p = "Photo";
            string i = "Index";
            if (r  == "Photography")
               
            {
                return View(p);
            }

            else
            {
                return View(r);
            }
        }
        public ActionResult About(MedReg r)
        {

            ViewBag.Welcome = r.firstName + " You submitted " + r.medium + "?";
            return View();

        }
        public ActionResult Medium()
        {

            return View();

        }
        public ActionResult Photo()
        {

            return View();

        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
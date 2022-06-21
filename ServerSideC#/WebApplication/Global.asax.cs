﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Timers;
using DailyHelpMe;
using WebApplication.Services;

namespace WebApplication
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        static Timer timer1NotifiNoApprove = new Timer();
        static Timer timer2TopThree = new Timer();
        static Timer timer3RequestPast = new Timer();
        string path = null;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //code for timers

             var totalMilliSecondsPerDay = TimeSpan.FromDays(1).TotalMilliseconds;
            //var totalMilliSecondsPerDay = 100;


            timer1NotifiNoApprove.Interval = totalMilliSecondsPerDay;
            timer1NotifiNoApprove.Elapsed += tm_Tick1;
            path = Server.MapPath("/");

            //var totalMilliSecondsPerDay = TimeSpan.FromDays(1).TotalMilliseconds;
            //var timer = new Timer(totalMilliSecondsPerDay);

            timer2TopThree.Interval = totalMilliSecondsPerDay;
            timer2TopThree.Elapsed += tm_Tick2;
            StartTimer2();

            timer3RequestPast.Interval = totalMilliSecondsPerDay;
            timer3RequestPast.Elapsed += tm_Tick3;
            StartTimer3();
        }

        //code for timer1
        private void tm_Tick1(object sender, ElapsedEventArgs e)
        {
            EndTimer1();
            TimerServices.CheckIf24Hpassed(path);
        }

        public static void StartTimer1()
        {
            timer1NotifiNoApprove.Enabled = true;
        }

        public static void EndTimer1()
        {
            timer1NotifiNoApprove.Enabled = false;

        }

        //code for time2
        private void tm_Tick2(object sender, ElapsedEventArgs e)
        {
            EndTimer2();
            if (DateTime.Today.Day == 1)
            {
                TimerServices.CheckTopThree();
            }
        }

        public static void StartTimer2()
        {
            timer2TopThree.Enabled = true;
        }

        public static void EndTimer2()
        {
            timer2TopThree.Enabled = false;

        }

        //code for time3
        private void tm_Tick3(object sender, ElapsedEventArgs e)
        {
            EndTimer3();
            TimerServices.CheckIfRequestPasted();
        }

        public static void StartTimer3()
        {
            timer3RequestPast.Enabled = true;
        }

        public static void EndTimer3()
        {
            timer3RequestPast.Enabled = false;

        }
    }
}



﻿#region Copyright
// <copyright file="MvxWebBrowserTask.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
// 
// Author - Stuart Lodge, Cirrious. http://www.cirrious.com
#endregion
#region using

using System;
using Cirrious.MvvmCross.Interfaces.Services.Tasks;
using Microsoft.Phone.Tasks;

#endregion

namespace Cirrious.MvvmCross.WindowsPhone.Services.Tasks
{
    public class MvxWebBrowserTask : MvxWindowsPhoneTask, IMvxWebBrowserTask
    {
        #region IMvxWebBrowserTask Members

        public void ShowWebPage(string url)
        {
            var webBrowserTask = new WebBrowserTask {Uri = new Uri(url)};
            Do(webBrowserTask.Show);
        }

        #endregion
    }
}
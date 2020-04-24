﻿using System.Collections.Generic;
using PodEZ.PodEZTemplate.DashboardCustomization.Dto;

namespace PodEZ.PodEZTemplate.Web.Areas.App.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}

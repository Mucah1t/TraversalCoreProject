﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeature());
        public IViewComponentResult Invoke()
        {
            //var values = featureManager.TGetList();
            ViewBag.image1 = 1;
            return View();
        }
    }
}

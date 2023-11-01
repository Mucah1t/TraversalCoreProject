﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestination());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();

            return View(values);
        }
        
    }
}

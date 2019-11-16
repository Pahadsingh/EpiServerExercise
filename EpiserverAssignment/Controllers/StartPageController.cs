using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EpiserverAssignment.Models.Pages;
using AutoMapper;
using EpiserverAssignment.Models;
using EpiserverAssignment.Infrastruchure;
using EpiserverAssignment.ViewModels;

namespace EpiserverAssignment.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            IMapper iMapper = AutoMapperConfig.CreateIMapper();

            var source1 = new ContentModel();
            source1.DemoText = "EpiServer Assignment Content list item 1";
            var destination1 = iMapper.Map<ContentModel, ContentModelDTO>(source1);


            var source2 = new ContentModel();
            source2.DemoText = "EpiServer Assignment Content list item 2";
            var destination2 = iMapper.Map<ContentModel, ContentModelDTO>(source2);


            var contentModellist = new List<ContentModel>()
            {
                new ContentModel {DemoText = destination1.DemoText},
                new ContentModel {DemoText = destination2.DemoText}
            };

            var contentViewModelList = new ContentViewModel
            {
                ContentList = contentModellist,
                Heading = currentPage.Name
            };
            return View(contentViewModelList);

            //return View(currentPage);
        }
    }
}
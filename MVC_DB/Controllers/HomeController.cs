using Microsoft.AspNetCore.Mvc;
using MVC_DB.DAL;
using MVC_DB.Models;
using MVC_DB.ViewModels;

namespace MVC_DB.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            CS cs = new CS()
            {
                Name = "UI/UX Design",
                Description = "Lorem Ipsum",
                image="UI.jpg"
            };
            CS cs1 = new CS()
            {
                Name = "Social Media",
                Description = "Lorem Ipsum",
                image="Social.jpg"
            };
            CS cs2 = new CS()
            {
                Name = "Marketing",
                Description = "Lorem Ipsum",
                image="marketing.jpg"
            };
            CS cs3 = new CS()
            {
                Name = "Graphic",
                Description = "Lorem Ipsum",
                image="graphic.jpg"
            };
            CS cs4 = new CS()
            {
                Name = "Digital Marketing",
                Description = "Lorem Ipsum",
                image="digital.jpg"
            };
            CS cs5 = new CS()
            {
                Name = "Market Research",
                Description = "Lorem Ipsum",
                image="research.jpg"
            };
            CS cs6 = new CS()
            {
                Name = "Business",
                Description = "Lorem Ipsum",
                image="business.jpg"
            };
            CS cs7 = new CS()
            {
                Name = "Branding",
                Description = "Lorem Ipsum",
                image="branding.jpg"
            };
            List<CS> Cses = new List<CS>();
            Cses.Add(cs);
            Cses.Add(cs1);
            Cses.Add(cs2);
            Cses.Add(cs3);
            Cses.Add(cs4);
            Cses.Add(cs5);
            Cses.Add(cs6);
            Cses.Add(cs7);
            Works work = new Works()
            {
                Name = "Social Media",
                Description = "Lorem Ipsum",
                img = "SocialMedia.jpg"
            };
            Works work1 = new Works()
            {
                Name = "Web Marketing",
                Description = "Lorem Ipsum",
                img = "WebMarketing.jpg"
            };
            Works work2 = new Works()
            {
                Name = "R@D",
                Description = "Lorem Ipsum",
                img = "RD.jpg"
            };
            Works work3 = new Works()
            {
                Name = "Public Relation",
                Description = "Lorem Ipsum",
                img = "PublicRelation.jpg"
            };
            Works work4 = new Works()
            {
                Name = "Branding",
                Description = "Lorem Ipsum",
                img = "Branding2.jpg"
            };
            Works work5 = new Works()
            {
                Name = "Creative Design",
                Description = "Lorem Ipsum",
                img = "CreativeDesign.jpg"
            };
            List<Works> workList = new List<Works>();
            workList.Add(work);
            workList.Add(work1);
            workList.Add(work2);
            workList.Add(work3);
            workList.Add(work4);
            workList.Add(work5);
            HomeVM homeVM = new HomeVM()
            {
                Cses = Cses,
                Works = workList
            };
            
            foreach (var item in homeVM.Works)
            {
                switch (item.Name)
                {
                    case "Social Media":
                    case "Web Marketing":
                    case "R@D":
                    case "Public Relation":
                        item.FilterClass = "graphic";
                        break;
                    case "UI/UX Design":
                        item.FilterClass = "ui";
                        break;
                    case "Branding":
                    case "Creative Design":
                        item.FilterClass = "branding";
                        break;
                    default:
                        item.FilterClass = ""; 
                        break;
                }
            }
            return View(homeVM);
        }
    }
}

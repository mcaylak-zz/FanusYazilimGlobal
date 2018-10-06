using FanusYazilim.BusinessLayer.Concrete.Managers;
using FanusYazilim.Entities;
using FanusYazilim.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FanusYazilim.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private CategoryManager _CategoryRepo = new CategoryManager();
        private AdvertisementManager _AdvertisementRepo = new AdvertisementManager();
        private ContentManager _ContentRepo = new ContentManager(); 

        #region Category


        public ActionResult Category()
        {
            List<Category> _categoryList = new List<Category>();
            _categoryList = _CategoryRepo.AllList();
            return View(_categoryList);
        }
        [HttpPost]
        public ActionResult Category(CategoryViewModel model)
        {
            Category add = new Category();
            add.Name = model.Name;
            _CategoryRepo.Insert(add);
            List<Category> _categoryList = new List<Category>();
            _categoryList = _CategoryRepo.AllList();
            return View(_categoryList);
        }
        public ActionResult AddCategory()
        {
            List<Category> _categoryList = new List<Category>();
            _categoryList = _CategoryRepo.AllList();
            return View(_categoryList);

        }
       
        public ActionResult DeleteCategory(CategoryViewModel category)
        {
            Category delete = _CategoryRepo.Find(r=>r.CategoryID==category.CategoryID);
            _CategoryRepo.Delete(delete);
            return RedirectToAction("Category");
        }

        #endregion

        #region Advertisement

        public ActionResult Advertisement()
        {
            List<Advertisement> advertisements =new List<Advertisement>();
            advertisements = _AdvertisementRepo.AllList();
            return View(advertisements);

        }
        public ActionResult AddAdvertisement()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdvertisement(AdvertisementViewModel advertisementViewModel)
        {
            Advertisement add = new Advertisement();
            add.ImagePath = advertisementViewModel.ImagePath;
            add.Owner = advertisementViewModel.Owner;
            _AdvertisementRepo.Insert(add);
            return RedirectToAction("Advertisement");
        }
        public ActionResult DeleteAdvertisement(AdvertisementViewModel advertisementViewModel)
        {
            Advertisement delete = _AdvertisementRepo.Find(r => r.AdvertisementID == advertisementViewModel.AdvertisementID);
            _AdvertisementRepo.Delete(delete);
            return RedirectToAction("Advertisement");
        }
        #endregion

        #region Content

        public ActionResult Content()
        {
            List<Category> _categoryList = new List<Category>();
            _categoryList = _CategoryRepo.AllList();

            
            return View(_categoryList);
        }
        public ActionResult Contents()
        {
            List<Category> _categoryList = new List<Category>();
            _categoryList = _CategoryRepo.AllList();

            return View(_categoryList);
        }
        public ActionResult AddContent(CategoryViewModel categoryViewModel)
        {
            ViewBag.CategoryID = categoryViewModel.CategoryID;
            return View();
        }
        [HttpPost]
        public ActionResult AddContent(CategoryViewModel categoryViewModel,String Content)
        {
            Category insert = _CategoryRepo.Find(r => r.CategoryID == categoryViewModel.CategoryID);
            Content add = new Content();
            add.Description = Content;
            add.CategoryID = insert.CategoryID;
            insert.Contents.Add(add);
            _CategoryRepo.Update(insert);
            

            return View();
        }
    
        #endregion

        public ActionResult Statistics()
        {
            return View();
        }
    }
}
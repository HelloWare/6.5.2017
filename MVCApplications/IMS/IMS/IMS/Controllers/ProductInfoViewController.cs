using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMS.Models;
using IMS.Repositories;

namespace IMS.Controllers
{
    public class ProductInfoViewController : Controller
    {
        PartTypeRepo partTypeRepo = new PartTypeRepo();
        PartRepo partRepo = new PartRepo();
        CategoryRepo categoryRepo = new CategoryRepo();
        PriceRepo priceRepo = new PriceRepo();
        InventoryRepo inventoryRepo = new InventoryRepo();
        // GET: ProductInfoView
        public ActionResult Index(int id)
        {
            ProductInfoViewModel productInfoViewModel = new ProductInfoViewModel();
            if (id == -1)
            {
                productInfoViewModel.Part = new Part { PicturePath= "https://beebom-redkapmedia.netdna-ssl.com/wp-content/uploads/2016/01/Reverse-Image-Search-Engines-Apps-And-Its-Uses-2016.jpg", Id= -1};
                productInfoViewModel.Prices = new List<Price>();
                productInfoViewModel.Inventories = new List<Inventory>();
            }
            else
            { 
                productInfoViewModel.Part = partRepo.Select(id);
                productInfoViewModel.Prices = priceRepo.GetPricesForPart(id).ToList();
                productInfoViewModel.Inventories = inventoryRepo.GetInventoriesForPart(id).ToList();
            }
            ViewBag.PartTypeId = new SelectList(partTypeRepo.SelectAll(), "Id", "Name");
            ViewBag.CategoryId = new SelectList(categoryRepo.SelectAll(), "Id", "Name");
            return View(productInfoViewModel);
        }
        // POST: ProductInfoView
        [HttpPost]
        public ActionResult Index(ProductInfoViewModel productInfoViewModel)
        {
            #region Part
            if (productInfoViewModel.Part.Id == -1)
            {
                productInfoViewModel.Part.Id = partRepo.Insert(productInfoViewModel.Part);
            }
            else
            {
                partRepo.Update(productInfoViewModel.Part);
            }
            #endregion

            #region Prices
            if (productInfoViewModel.Prices!=null&&productInfoViewModel.Prices.Count != 0)
            {
                IEnumerable<int> allPriceIdsForPart = priceRepo.GetPricesForPart(productInfoViewModel.Part.Id).Select(p => p.Id);
                foreach (var item in productInfoViewModel.Prices)
                {
                    if (allPriceIdsForPart.Contains(item.Id))
                    {
                        priceRepo.Update(item);
                    }
                    else
                    {
                        item.PartId = productInfoViewModel.Part.Id;
                        priceRepo.Insert(item);
                    }
                }
            }
            #endregion

            #region Inventories
            if (productInfoViewModel.Inventories!=null&&productInfoViewModel.Inventories.Count != 0)
            {
                IEnumerable<int> allInventoryIdsForPart = inventoryRepo.GetInventoriesForPart(productInfoViewModel.Part.Id).Select(i => i.Id);
                foreach (var item in productInfoViewModel.Inventories)
                {
                    if (allInventoryIdsForPart.Contains(item.Id))
                    {
                        inventoryRepo.Update(item);
                    }
                    else
                    {
                        item.PartId = productInfoViewModel.Part.Id;
                        inventoryRepo.Insert(item);
                    }
                }

                //IEnumerable<Inventory> allInventoryIdsForPart2 = inventoryRepo.GetInventoriesForPart(productInfoViewModel.Part.Id);
                //foreach (var item in productInfoViewModel.Inventories)
                //{
                //    bool isNew = true;
                //    foreach (var inventory in allInventoryIdsForPart2)
                //    {
                //        if (inventory.Id == item.Id)
                //        {
                //            isNew = false;
                //             break;
                //        }
                //    }
                //    if (!isNew)
                //    {
                //        inventoryRepo.Update(item);
                //    }
                //    else
                //    {
                //        item.PartId = productInfoViewModel.Part.Id;
                //        inventoryRepo.Insert(item);
                //    }
                //}
            } 
            #endregion
            return RedirectToAction("Index");
        }

        // GET: ProductInfoView/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductInfoView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductInfoView/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductInfoView/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductInfoView/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductInfoView/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductInfoView/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

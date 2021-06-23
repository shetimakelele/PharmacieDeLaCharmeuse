using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacieDeLaCharmeuse.Core.Data;
using PharmacieDeLaCharmeuse.Core.Data.Models;

namespace PharmacieDelaCharmeuse.Controllers
{
    public class ImageController : Controller
    {
        // recupere entities pour le controleur en entier

        #region Champs privés
        private readonly DefaultContext _context = null;
        private readonly IWebHostEnvironment _hostEnvironment;
        #endregion

        #region Constructeurs
        public ImageController(DefaultContext context,IWebHostEnvironment hostEnvironment)
        {
            this._context = context;
            this._hostEnvironment = hostEnvironment;
        }
        #endregion
        //Get image
        public IActionResult Index()
        {
            this.ViewBag.MonTitre = "Liste des Images";

            //on recupere notre liste

            var query = from item in this._context.ImageModels
                        select item;

            return View(query.ToList());
        }

        //Get upload
        public IActionResult Upload()
        {
            return View();
        }
        // post upload
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Upload ([Bind("ImageId, TitreImage, ImageFile")]ImageModel imageModel)
        {
            if (ModelState.IsValid)
            {
                //save image to wwwroot/image
                String wwwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
                string extension = Path.GetExtension(imageModel.ImageFile.FileName);
                imageModel.NomImage = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwwRootPath + "/Image", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await imageModel.ImageFile.CopyToAsync(fileStream);
                }
            // insert
                this._context.ImageModels.Add(imageModel);
                this._context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(imageModel);
        }


        public ActionResult Details(int id)
        {

            return View(this._context.ImageModels.First(item => item.ImageId == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imageModel = await _context.ImageModels.FindAsync(id);

            //Delete image from wwwroot/image
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "image", imageModel.NomImage);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);

            this._context.ImageModels.Remove(imageModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
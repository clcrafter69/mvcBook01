using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCBook01.Models;

namespace MVCBook01.Controllers
{
    public class BookController : Controller
    {
        private static List<Book> _book = new List<Book>();
        private static int nextId = 0;
        // GET: Book
        public ActionResult Index()
        {
            return View(_book);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View(_book.Find(c => c.Id == id));
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book newBook,IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                newBook.Id = nextId++;
                _book.Add(newBook);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_book.Find(c => c.Id == id));
        }

        // POST: Book/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book modBook, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                _book.Remove(_book.Find(c => c.Id == id));

                _book.Add(modBook);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_book.Find(c => c.Id == id));
        }

        // POST: Book/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                
                _book.Remove(_book.Find(c => c.Id == id));

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                var car = _book.Find(c => c.Id == id);
                return View(_book);
            }
        }
    }
}
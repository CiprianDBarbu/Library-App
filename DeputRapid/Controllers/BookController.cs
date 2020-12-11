﻿using DeputRapid.Models;
using DeputRapid.Models.MyDatabaseInitializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DeputRapid.Controllers
{
    public class BookController : Controller
    {
        private DbCtx db = new DbCtx();

        // GET: Book
        [HttpGet]
        public ActionResult Index()
        {
            List<Book> books = db.Books.Include("Publisher").ToList();
            ViewBag.Books = books;

            return View();
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Book book = db.Books.Find(id);
                if (book != null)
                {
                    return View(book);
                }
                return HttpNotFound($"Couldn't find the book with the id {id}!");
            }
            return HttpNotFound("Missing book id parameter!");
        }

        [HttpGet]
        public ActionResult New()
        {
            Book book = new Book
            {
                BookTypesList = GetAllBookTypes(),
                Genres = new List<Genre>()
            };
            return View(book);
        }

        [HttpPost]
        public ActionResult New(Book bookRequest)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //bookRequest.Publisher = db.Publishers.FirstOrDefault(p => p.PublisherId.Equals(1));

                    db.Books.Add(bookRequest);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(bookRequest);
            }
            catch (Exception e)
            {
                return View(bookRequest);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                Book book = db.Books.Find(id);

                if (book == null)
                {
                    return HttpNotFound("Couldn't find the book with id " + id.ToString());
                }
                book.BookTypesList = GetAllBookTypes();
                return View(book);
            }
            return HttpNotFound("Missing book id parameter!");
        }

        [HttpPut]
        public ActionResult Edit(int id, Book bookRequest)
        {
            try
            {
                bookRequest.BookTypesList = GetAllBookTypes();
                if (ModelState.IsValid)
                {
                    Book book = db.Books
                        .Include("Publisher")
                        .SingleOrDefault(b => b.BookId.Equals(id));

                    if (TryUpdateModel(book))
                    {
                        book.Title = bookRequest.Title;
                        book.Author = bookRequest.Author;
                        book.Summary = bookRequest.Summary;
                        book.NoOfPages = bookRequest.NoOfPages;
                        db.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
                return View(bookRequest);
            }
            catch (Exception e)
            {
                return View(bookRequest);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Book book = db.Books.Find(id);
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound($"Couldn't find the book with id {id.ToString()}");
        }


        [NonAction]
        public IEnumerable<SelectListItem> GetAllBookTypes()
        {
            var selectList = new List<SelectListItem>();

            foreach(var cover in db.BookTypes.ToList())
            {
                selectList.Add(new SelectListItem
                {
                    Value = cover.BookTypeId.ToString(),
                    Text = cover.Name
                });
            }

            return selectList;
        }
    }
}
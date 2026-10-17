using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Lesson09.Models; // Bắt buộc phải có để hệ thống nhận diện được class Account

namespace Lesson09.Controllers
{
    public class AccountController : Controller
    {
        // 1. Khai báo DbContext để làm việc với Database
        private readonly BookStoreContext _context;

        // 2. Tiêm (Inject) DbContext thông qua Constructor
        public AccountController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: AccountController
        public ActionResult Index()
        {
            // Lấy danh sách tài khoản từ DB truyền ra View
            var dataList = _context.Accounts.ToList();
            return View(dataList);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(string id)
        {
            if (id == null) return NotFound();
            var account = _context.Accounts.FirstOrDefault(a => a.AccountId == id);
            if (account == null) return NotFound();
            return View(account);
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // 1. Khởi tạo một đối tượng Account rỗng
                Account account = new Account();

                // 2. Nhặt từng dữ liệu từ Form gán vào account
                account.AccountId = collection["AccountId"];
                account.Username = collection["Username"];
                account.Password = collection["Password"];
                account.FullName = collection["FullName"];
                account.Email = collection["Email"];
                account.Phone = collection["Phone"];
                account.Address = collection["Address"];
                account.Picture = collection["Picture"];

                // 3. Xử lý thủ công 2 cột Checkbox (Tránh lỗi bool?)
                string isAdminValue = collection["IsAdmin"];
                account.IsAdmin = !string.IsNullOrEmpty(isAdminValue) && isAdminValue.Contains("true");

                string activeValue = collection["Active"];
                account.Active = !string.IsNullOrEmpty(activeValue) && activeValue.Contains("true");

                // 4. Lưu vào Database
                _context.Accounts.Add(account);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Content("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null) return NotFound();
            var account = _context.Accounts.FirstOrDefault(a => a.AccountId == id);
            if (account == null) return NotFound();
            return View(account);
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                var account = _context.Accounts.FirstOrDefault(a => a.AccountId == id);
                if (account == null) return NotFound();

                account.Username = collection["Username"];
                account.Password = collection["Password"];
                account.FullName = collection["FullName"];
                account.Email = collection["Email"];
                account.Phone = collection["Phone"];
                account.Address = collection["Address"];
                account.Picture = collection["Picture"];

                string isAdminValue = collection["IsAdmin"];
                account.IsAdmin = !string.IsNullOrEmpty(isAdminValue) && isAdminValue.Contains("true");

                string activeValue = collection["Active"];
                account.Active = !string.IsNullOrEmpty(activeValue) && activeValue.Contains("true");

                _context.Accounts.Update(account);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null) return NotFound();
            var account = _context.Accounts.FirstOrDefault(a => a.AccountId == id);
            if (account == null) return NotFound();
            return View(account);
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                var account = _context.Accounts.FirstOrDefault(a => a.AccountId == id);
                if (account != null)
                {
                    _context.Accounts.Remove(account);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
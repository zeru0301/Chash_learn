using System.Diagnostics;
using energyEC.Models;
using energyEC.Data;  // 追加：DbContext の名前空間
using Microsoft.AspNetCore.Mvc;
using System.Linq; // 追加：ToList() を使うため
using System;
namespace energyEC.Controllers
{
    public class HomeController : Controller
    {
        // 追加：DbContext を Controller に注入
        private readonly AppDbContext _context;

        // 既存のコンストラクタに DbContext を追加
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Inquiry()
        {
            return View();
        }

        //商品表示コントローラー
        // Merchandise アクションを変更：DBから商品を取得して渡す
        public IActionResult Merchandise()
        {
            // データベースの Products テーブルから全件取得
            var products = _context.Products.ToList();

            // View に渡す
            return View(products);
        }


        public IActionResult Confirm(int ProductId, int Quantity)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == ProductId);
            if (product == null)
            {
                return NotFound();
            }
            var confirmData = new ConfirmViewModel
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                Quantity = Quantity
            };

            return View(confirmData);

        }
        //商品購入コントローラー 
        [HttpPost]
        public IActionResult Buy(int ProductId, int Quantity)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == ProductId);
            if (product == null)
            {
                return NotFound();
            }

            var history = new PurchaseHistory
            {
                ProductName = product.ProductName,
                ProductPieces = Quantity,
                HistoryTimestamp = DateTime.Now
            };

            _context.PurchaseHistory.Add(history);
            _context.SaveChanges();

            return RedirectToAction("Complete");

        }

        //商品購入後画面
        public IActionResult Complete()
        {
            return View();
        }
        

        //コンタクトフォーム
        [HttpPost]
        public IActionResult ContactConfim(ConfirmViewModel model) 
        {
            return View(model);
        }

        public IActionResult Contact(ConfirmViewModel model)
        {
            var inquiry = new InquiryHistory
            {
                inquiry_name = model.ContactName,
                inquiry_form = model.ContactForm,
                history_timestamp = DateTime.Now

            };
            _context.InquiryHistory.Add(inquiry);
            _context.SaveChanges();

            return RedirectToAction("Complete");
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

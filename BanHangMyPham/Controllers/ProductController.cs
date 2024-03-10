using BanHangMyPham.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BanHangMyPham.Controllers
{
	public class ProductController : Controller
	{
		private readonly PerfumeDbContext _context;
		/*Việc sử dụng readonly đảm bảo rằng biến _context chỉ được gán giá trị một lần trong constructor 
		  và không thể thay đổi giá trị sau khi đã được gán.*/
		public ProductController(PerfumeDbContext context) 
		{
			_context = context;
		}
		/* Lớp ProductController có thể truy cập và sử dụng để thực hiện các thao tác liên quan đến cơ sở dữ liệu, 
		  chẳng hạn như truy vấn hoặc lưu trữ dữ liệu về sản phẩm. */
		                                               
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Details(int id)
		{
			var product = _context.Products.Include(x=>x.CategoriesId).FirstOrDefault(x=>x.ProductId ==id); //Lỗi khi chạy tới đây
			/* Phương thức Details này trong lớp ProductController nhận đầu vào là một ID của sản phẩm. Nó sử dụng đối tượng _context để 
			  truy vấn cơ sở dữ liệu và lấy thông tin của sản phẩm có ProductId tương ứng với ID được cung cấp. */
			if(product == null)
			{
				return RedirectToAction("Index");
				/* Nếu sản phẩm không tồn tại trong cơ sở dữ liệu (tức là product bằng null), 
				 * phương thức sẽ chuyển hướng người dùng đến action "Index" (chẳng hạn, trang chính của ứng dụng). */
		}
			return View(product);
			// Nếu sản phẩm tồn tại, phương thức sẽ trả về một view chứa thông tin của sản phẩm để hiển thị cho người dùng.
		}
	}
}

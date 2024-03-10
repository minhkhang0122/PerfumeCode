using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanHangMyPham.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? ShortDescription { get; set; }

    public string? Description { get; set; }

    public int? CategoriesId { get; set; }

	public int? Price { get; set; }

    public int? Discount { get; set; }

    public string? Thumb { get; set; }

    public string? Video { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModifed { get; set; }

    public bool BestSeller { get; set; }

    public bool HomeFlag { get; set; }

    public bool Active { get; set; }

    public string? Tags { get; set; }

    public string? Title { get; set; }

    public string? Alias { get; set; }

    public string? MetaDesc { get; set; }

    public string? MetaKey { get; set; }

    public int? UnitInStock { get; set; }

    public virtual Category? Categories { get; set; }

    public virtual ICollection<OrdersDetail> OrdersDetails { get; set; } = new List<OrdersDetail>();
}

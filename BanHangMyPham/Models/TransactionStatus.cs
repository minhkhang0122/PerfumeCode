using System;
using System.Collections.Generic;

namespace BanHangMyPham.Models;

public partial class TransactionStatus
{
    public int TransactionStatusId { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

﻿namespace MODELS.DANHMUC.PHUONGXA.Requests
{
    public class PostPhuongXaRequest : BaseRequest
    {
        public Guid Id { get; set; }
        public string? MaLienThong { get; set; } = string.Empty;
        public string? Ma { get; set; } = string.Empty;
        public string? Ten { get; set; } = string.Empty;
        public string? MoTa { get; set; } = string.Empty;
        public int? ThuTuHienThi { get; set; }
        public Guid? QuanHuyenId { get; set; }
        public bool? IsThanhThi { get; set; }
    }
}
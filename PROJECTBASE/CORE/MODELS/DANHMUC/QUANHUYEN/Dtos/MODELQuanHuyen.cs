﻿namespace MODELS.DANHMUC.QUANHUYEN.Response
{
    public class MODELQuanHuyen : MODELBase
    {
        public Guid Id { get; set; }
        public string? MaLienThong { get; set; } = string.Empty;
        public string? Ma { get; set; } = string.Empty;
        public string? Ten { get; set; } = string.Empty;
        public string? MoTa { get; set; } = string.Empty;
        public int? ThuTuHienThi { get; set; }
        public Guid? TinhThanhId { get; set; }
    }
}
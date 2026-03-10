using Bitum.Application.MaterialUnits; // ← Проверьте namespace интерфейса
using QRCoder;

namespace Bitum.Infrastructure.QrCode
{
    public class QrCodeGenerator : IQrCodeGenerator
    {
        public byte[] Generate(string content)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            var pngByteQrCode = new PngByteQRCode(qrCodeData);
            return pngByteQrCode.GetGraphic(20);
        }
    }
}
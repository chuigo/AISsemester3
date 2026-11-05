using System;
using System.Collections.Generic;
using System.Text;
using BuisnessLogic;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    /// <summary>
    /// Отвечает за отрисовку изображения миньона
    /// </summary>
    public class ImageRender
    {
        private readonly ImageSelector _selector;
        public ImageRender(ImageSelector selector)
        {
            _selector = selector;
        }
        /// <summary>
        /// Создает итоговое изображение миньона заданного размера
        /// </summary>
        /// <param name="size">размер изображения</param>
        /// <param name="height">рост миньона</param>
        /// <param name="twoeyes">признак наличия 2ух глаз</param>
        /// <param name="isimposter">является ли миньон предателем</param>
        /// <returns></returns>
        public Image Render(Size size, int height, bool twoeyes, bool isimposter = false)
        {
            var bmp = new Bitmap(size.Width, size.Height);
            using var g = Graphics.FromImage(bmp);
            if (isimposter)
            {
                g.DrawImage(Resources.imposter, 0, 0, bmp.Width, bmp.Height);
            }
            else
            {
                g.DrawImage(_selector.BodyImage(height), 0, 0, bmp.Width, bmp.Height);
                g.DrawImage(_selector.EyesImage(twoeyes), 0, 0, bmp.Width, bmp.Height);
            }
            return bmp;
        }
    }
}
